using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Exceptions;
using Carpool.WebAPI.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class RezervacijaService : BaseCRUDService<Model.Rezervacija, RezervacijaSearchRequest, Database.Rezervacija, RezervacijaUpsertRequest, RezervacijaUpsertRequest>
    {
        private readonly IHttpContextAccessor _httpContext;
        public RezervacijaService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override Model.Rezervacija Delete(int id)
        {
            var entity = _context.Rezervacije.Find(id);
            var voznja = _context.Voznje.Find(entity.VoznjaID);
            voznja.SlobodnaMjesta++;
            _context.Remove(entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }

        public override List<Model.Rezervacija> Get(RezervacijaSearchRequest search)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var query = _context.Set<Database.Rezervacija>().AsQueryable();

            if (search.ByVoznjaId)
            {
                query = query.Where(x => x.VoznjaID == search.VoznjaID);
            }
            if (search.UserActive)
            {
                query = query.Where(x => x.KorisnikID == userId && x.Voznja.IsAktivna);
            }
            if (search.UserNonActive)
            {
                query = query.Where(x => x.KorisnikID == userId && !x.Voznja.IsAktivna);
            } 
            if (search.UserAll)
            {
                query = query.Where(x => x.KorisnikID == userId);
            }
            if (search.ByVoznjaUserId)
            {
                query = query.Where(x => x.KorisnikID == userId && x.VoznjaID == search.VoznjaID);
            }
            var result = query.Select(item => new Model.Rezervacija
            {
                DatumRezervacije = item.DatumRezervacije,
                KorisnickoIme = item.Korisnik.KorisnickoIme,
                UsputniGradNaziv = item.UsputniGrad.Grad.Naziv,
                RezervacijaID = item.RezervacijaID,
                GradPolaska = _context.Voznje.Where(v => v.VoznjaID == item.VoznjaID).Select(v => v.GradPolaska.Naziv).FirstOrDefault(),
                GradDestinacija = _context.Voznje.Where(v => v.VoznjaID == item.VoznjaID).Select(v => v.GradDestinacija.Naziv).FirstOrDefault(),
                VoznjaID=item.VoznjaID
            }).ToList();

            return _mapper.Map<List<Model.Rezervacija>>(result);
        }
        public override Model.Rezervacija GetById(int id)
        {
            var model = _context.Rezervacije.Where(r => r.RezervacijaID == id).Select(r => new Model.Rezervacija
            {
               DatumRezervacije=r.DatumRezervacije,
               KorisnickoIme=r.Korisnik.KorisnickoIme,
               UsputniGradNaziv=r.UsputniGrad.Grad.Naziv,
               VoznjaID=r.VoznjaID
            }).FirstOrDefault();

            return _mapper.Map<Model.Rezervacija>(model);
        }

        public override Model.Rezervacija Insert(RezervacijaUpsertRequest request)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var vozacID = _context.Voznje.Where(v => v.VoznjaID == request.VoznjaID).Select(v => v.VozacID).FirstOrDefault();
            if (userId == vozacID)
            {
                throw new UserException("Ne možete rezervisati vlastitu vožnju.");
            }

            var entity = _mapper.Map<Database.Rezervacija>(request);

            if (request.UsputniGradID != null)
            {
                var usputniID = _context.UsputniGradovi.Where(u => u.GradID == request.UsputniGradID).Select(u => u.UsputniGradoviID).FirstOrDefault();
                entity.UsputniGradId = usputniID;
            }

           
            entity.DatumRezervacije = DateTime.Now;
            entity.KorisnikID = userId;
            entity.OpisPrtljaga = "";

            _context.Rezervacije.Add(entity);
        
            var voznja = _context.Voznje.Find(request.VoznjaID);
            voznja.SlobodnaMjesta--;

            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }
    }
}

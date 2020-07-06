using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class VoznjaService : BaseCRUDService<Model.Voznja, VoznjaSearchRequest, Database.Voznja, VoznjaUspertRequest, VoznjaUspertRequest>
    {
        private readonly IHttpContextAccessor _httpContext;
        public VoznjaService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override Model.Voznja Update(int id, VoznjaUspertRequest request)
        {
            var entity = _context.Voznje.Find(id);
            if (request.ZavrsiVoznju)
            {
                entity.IsAktivna = false;
                //_context.SaveChanges();
                return _mapper.Map<Model.Voznja>(entity);
            }

            if (entity.AutomobilID != request.AutomobilID)
            {
                var stariAuto = _context.Autmobili.Find(entity.AutomobilID);
                stariAuto.IsAktivan = false;

                var noviAuto = _context.Autmobili.Find(request.AutomobilID);
                noviAuto.IsAktivan = true;
            }

            var usputniGradovi = _context.UsputniGradovi.Where(u => u.VoznjaID == entity.VoznjaID).ToList();
            foreach (var item in usputniGradovi)
            {
                _context.UsputniGradovi.Remove(item);
            }
            _context.SaveChanges();

            foreach (var usputni in request.UsputniGradoviGrad)
            {
                entity.UsputniGradovi.Add(new Database.UsputniGradovi
                {
                    GradPoRedu = 0,
                    CijenaUsputni = 0,
                    VoznjaID = entity.VoznjaID,
                    GradID = usputni.GradID
                });
            }
            _context.SaveChanges();

            return _mapper.Map<Model.Voznja>(entity);
        }

        public override Model.Voznja Delete(int id)
        {
            var entity = _context.Voznje.Find(id);

            var auto = _context.Autmobili.Find(entity.AutomobilID);
            auto.IsAktivan = false;

            var usputniGradovi = _context.UsputniGradovi.Where(u => u.VoznjaID == id).ToList();
            foreach (var item in usputniGradovi)
            {
                _context.UsputniGradovi.Remove(item);
            }
            _context.SaveChanges();

            _context.Voznje.Remove(entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Voznja>(entity);
        }

        public override Model.Voznja Insert(VoznjaUspertRequest request)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = _mapper.Map<Database.Voznja>(request);
            entity.VozacID = userId;

            _context.Voznje.Add(entity);
            _context.SaveChanges();

            foreach (var usputni in request.UsputniGradoviGrad)
            {
                _context.UsputniGradovi.Add(new Database.UsputniGradovi()
                {
                    VoznjaID = entity.VoznjaID,
                    CijenaUsputni = 0,
                    GradID = usputni.GradID,
                    GradPoRedu = 0
                });
            }

            var auto = _context.Autmobili.Find(request.AutomobilID);
            auto.IsAktivan = true;

            _context.SaveChanges();

            var model = _mapper.Map<Model.Voznja>(entity);
            model.UsputniGradoviE = entity.UsputniGradovi.Where(x => x.VoznjaID == entity.VoznjaID).Select(x => new Model.UsputniGradovi
            {
                UsputniGradoviID=x.UsputniGradoviID,
                VoznjaID=x.VoznjaID,
                CijenaUsputni=x.CijenaUsputni,
                GradID=x.GradID,
                GradPoRedu=x.GradPoRedu
            }).ToList();

            return model;
        }

        public override Model.Voznja GetById(int id)
        {
            var result = _context.Voznje.Include(item => item.UsputniGradovi).Where(item => item.VoznjaID == id).Select(item => new Model.Voznja
            {
                AutomobilID = item.AutomobilID,
                AutomobilNazivModel = item.Automobil.Naziv + " " + item.Automobil.Model,
                DatumObjave = item.DatumObjave,
                DatumPolaska = item.DatumPolaska,
                GradPolaskaID = item.GradPolaskaID,
                GradPolaska = item.GradPolaska.Naziv,
                GradDestinacijaID = item.GradDestinacijaID,
                GradDestinacija = item.GradDestinacija.Naziv,
                IsAktivna = item.IsAktivna,
                VozacID = item.VozacID,
                KorisnickoIme = item.Vozac.Korisnik.KorisnickoIme,
                PunaCijena = item.PunaCijena,
                SlobodnaMjesta = item.SlobodnaMjesta,
                VrijemePolaska = item.VrijemePolaska,
                VoznjaID = item.VoznjaID,
                UsputniGradoviE = item.UsputniGradovi.Select(y => new Model.UsputniGradovi()
                {
                    CijenaUsputni = y.CijenaUsputni,
                    GradID = y.GradID,
                    Grad = _mapper.Map<Model.Grad>(y.Grad),
                    GradPoRedu = y.GradPoRedu,
                    UsputniGradoviID = y.UsputniGradoviID,
                    Voznja = _mapper.Map<Model.Voznja>(y.Voznja),
                    VoznjaID = y.VoznjaID
                }).ToList(),
                UsputniGradoviGrad=item.UsputniGradovi.Select(x=> new Model.Grad
                {
                    GradID=x.GradID,
                    Naziv=_context.Gradovi.Where(g=>g.GradID==x.GradID).Select(g=>g.Naziv).FirstOrDefault()
                }).ToList(),
                UsputniGradoviNaziv = item.UsputniGradovi.Select(u => u.Grad.Naziv).ToList()
            }).FirstOrDefault();

            return _mapper.Map<Model.Voznja>(result);
        }

        public override List<Model.Voznja> Get(VoznjaSearchRequest search)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var query = _context.Set<Database.Voznja>().AsQueryable();

            if (search?.GradPolaskaID.HasValue == true)
            {
                query = query.Where(x => x.GradPolaskaID == search.GradPolaskaID);
            }
            if (search.IsVozac)
            {
                query = query.Where(x => x.VozacID == userId && x.IsAktivna == true);
            }
            if (search.IsZavrsena)
            {
                query = query.Where(x => x.VozacID == userId && x.IsAktivna==false);
            }
            if (search.IsSlobodnaMjesta)
            {
                query = query.Where(x => x.SlobodnaMjesta != 0 && x.IsAktivna == true);
            } 
            if (search.PosljednjeVoznje)
            {
                query = query.OrderByDescending(x=>x.DatumObjave).Take(3);
             
            }
            else
            {
                query = query.OrderByDescending(x => x.DatumObjave);
               
            }

            if (search.SearchFromHomePage)
            {
                query = query.Where(x => (x.GradPolaskaID==search.GradPolaskaID && x.GradDestinacijaID==search.GradDestinacijaID) || (x.UsputniGradovi.Any(u=>u.GradID==search.GradDestinacijaID) && x.GradPolaskaID == search.GradPolaskaID));
                query = query.Where(x => x.IsAktivna);
                //|| (x.UsputniGradovi.Any(a=>a.GradID == search.GradDestinacijaID) && x.GradPolaskaID==search.GradPolaskaID))
            }


            var result = query.Select(item => new Model.Voznja
            {
                AutomobilNazivModel = item.Automobil.Naziv + " " + item.Automobil.Model,
                DatumObjave = item.DatumObjave,
                DatumPolaska = item.DatumPolaska,
                GradPolaska = item.GradPolaska.Naziv,
                GradDestinacija = item.GradDestinacija.Naziv,
                IsAktivna = item.IsAktivna,
                KorisnickoIme = item.Vozac.Korisnik.KorisnickoIme,
                PunaCijena = item.PunaCijena,
                SlobodnaMjesta = item.SlobodnaMjesta,
                VrijemePolaska = item.VrijemePolaska,
                VoznjaID = item.VoznjaID
            }).ToList();

            return _mapper.Map<List<Model.Voznja>>(result);
        }
    }
}

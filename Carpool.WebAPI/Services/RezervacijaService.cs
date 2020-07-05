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

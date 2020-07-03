using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class VoznjaService : BaseCRUDService<Model.Voznja, VoznjaSearchRequest, Database.Voznja, VoznjaUpsertRequest, VoznjaUpsertRequest>
    {
        private readonly IHttpContextAccessor _httpContext;
        public VoznjaService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override Model.Voznja Insert(VoznjaUpsertRequest request)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = new Database.Voznja
            {
                AutomobilID=request.AutomobilID,
                DatumObjave=request.DatumObjave,
                DatumPolaska=request.DatumPolaska,
                GradDestinacijaID=request.GradDestinacijaID,
                GradPolaskaID=request.GradPolaskaID,
                IsAktivna=request.IsAktivna,
                PunaCijena=request.PunaCijena,
                SlobodnaMjesta=request.SlobodnaMjesta,
                VozacID=userId,
                VrijemePolaska=request.VrijemePolaska
            };

            _context.Voznje.Add(entity);
            _context.SaveChanges();

            entity.UsputniGradovi = new List<Database.UsputniGradovi>();

            foreach (var usputni in request.UsputniGradovi)
            {
                entity.UsputniGradovi.Add(new Database.UsputniGradovi
                {
                    GradPoRedu=0,
                    CijenaUsputni=0,
                    VoznjaID=entity.VoznjaID,
                    GradID=usputni.GradID
                });
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Voznja>(entity);
        }

        public override List<Model.Voznja> Get(VoznjaSearchRequest search)
        {
            var query = _context.Set<Database.Voznja>().AsQueryable();

            if (search?.GradPolaskaID.HasValue == true)
            {
                query = query.Where(x => x.GradPolaskaID == search.GradPolaskaID);
            }

            query = query.OrderBy(x=>x.DatumObjave);

            var result = query.ToList();

            return _mapper.Map<List<Model.Voznja>>(result);
        }
    }
}

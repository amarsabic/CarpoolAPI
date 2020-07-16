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
    public class VozacService : BaseCRUDService<Model.Vozac, VozacSearchRequest, Database.Vozac, VozacUpsertRequest, VozacUpsertRequest>
    {
        private readonly IHttpContextAccessor _httpContext;
        public VozacService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Vozac> Get(VozacSearchRequest search)
        {
            var userId = _httpContext.GetUserId();

            var query = _context.Vozaci.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.BrVozackeDozvole))
            {
                query = query.Where(x => x.BrVozackeDozvole.StartsWith(search.BrVozackeDozvole));
            }
            
            var result = query.ToList();

            return _mapper.Map<List<Model.Vozac>>(result);
        }

        public override Model.Vozac Insert(VozacUpsertRequest request)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var model = _mapper.Map<Database.Vozac>(request);
            model.VozacID = userId;

            _context.Vozaci.Add(model);
            _context.SaveChanges();

            var IsVozacSet = _context.Korisnici.Find(model.VozacID);
            IsVozacSet.IsVozac = true;
            _context.SaveChanges();

            return _mapper.Map<Model.Vozac>(model);
        }
    }
}

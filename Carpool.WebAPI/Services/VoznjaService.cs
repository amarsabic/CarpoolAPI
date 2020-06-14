using AutoMapper;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class VoznjaService : BaseCRUDService<Model.Voznja, VoznjaSearchRequest, Database.Voznja, VoznjaUpsertRequest, VoznjaUpsertRequest>
    {
        public VoznjaService(CarpoolContext context, IMapper mapper) : base(context, mapper)
        {
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

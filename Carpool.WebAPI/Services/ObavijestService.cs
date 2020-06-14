using AutoMapper;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class ObavijestService : BaseCRUDService<Model.Obavijesti, ObavijestiSearchRequest, Database.Obavijesti, ObavijestiUpsertRequest, ObavijestiUpsertRequest>
    {
        public ObavijestService(CarpoolContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Obavijesti> Get(ObavijestiSearchRequest request)
        {
            var query = _context.Obavijesti.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(request.Naslov));
            }

            var result = query.ToList();

            return _mapper.Map<List<Model.Obavijesti>>(result);
        }
    }
}

using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class OcjenaService : BaseCRUDService<Model.Ocjene, OcjenaSearchRequest, Database.Ocjene, OcjenaUpsertRequest, OcjenaUpsertRequest>
    {
        private readonly IHttpContextAccessor _httpContext;
        public OcjenaService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Ocjene> Get(OcjenaSearchRequest request)
        {
            var query = _context.Ocjene.AsQueryable();

            if (request.byVoznjaID)
            {
                query = query.Where(x => x.VoznjaID == request.VoznjaID);
            }

            var result = query.ToList();

            var list = new List<Model.Ocjene>();
            foreach (var item in result)
            {
                list.Add(new Model.Ocjene
                {
                  Komentar=item.Komentar,
                  KorisnickoIme=_context.Korisnici.Where(k=>k.KorisnikID==item.KorisnikID).Select(k=>k.KorisnickoIme).FirstOrDefault(),
                  OcjenaNaziv= _context.TipOcjene.Where(t => t.TipOcjeneID == item.TipOcjeneID).Select(k => k.Ocjena).FirstOrDefault(),
                  KorisnikID=item.KorisnikID,
                  VoznjaID=item.VoznjaID,
                  TipOcjeneID=item.TipOcjeneID,
                  OcjeneID=item.OcjeneID
                });
            }

            return list;
        }
    }
}

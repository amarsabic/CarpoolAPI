using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Controllers
{
    public class OcjenaController : BaseCRUDController<Model.Ocjene, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>
    {
        public OcjenaController(ICRUDService<Ocjene, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest> service) : base(service)
        {
        }

        [HttpGet("getbykorisnik")]
        public Model.Ocjene GetByKorisnik(int korisnik, int voznja)
        {
            return (_service as IOcjenaService).GetByKorisnik(korisnik, voznja);
        }
    }
}

using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Controllers
{
    public class ObavijestiController : BaseCRUDController<Obavijesti, ObavijestiSearchRequest, ObavijestiUpsertRequest, ObavijestiUpsertRequest>
    {
        public ObavijestiController(ICRUDService<Obavijesti, ObavijestiSearchRequest, ObavijestiUpsertRequest, ObavijestiUpsertRequest> service) : base(service)
        {
        }
    }
}

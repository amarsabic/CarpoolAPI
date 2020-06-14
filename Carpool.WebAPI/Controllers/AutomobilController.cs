using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.WebAPI.Controllers
{
    public class AutomobilController : BaseCRUDController<Model.Automobil, AutomobilSearchRequest, AutomobilInsertRequest, AutomobilInsertRequest>
    {
        public AutomobilController(ICRUDService<Automobil, AutomobilSearchRequest, AutomobilInsertRequest, AutomobilInsertRequest> service) : base(service)
        {
        }
    }
}

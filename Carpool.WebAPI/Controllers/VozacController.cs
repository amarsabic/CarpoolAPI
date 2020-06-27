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
    public class VozacController : BaseCRUDController<Model.Vozac, VozacSearchRequest, VozacUpsertRequest, VozacUpsertRequest>
    {
        public VozacController(ICRUDService<Vozac, VozacSearchRequest, VozacUpsertRequest, VozacUpsertRequest> service) : base(service)
        {
        }
    }
}
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

    public class UsputniGradoviController : BaseCRUDController<Model.UsputniGradovi, UsputniGradoviSearchRequest, UsputniGradoviUpsertRequest, UsputniGradoviUpsertRequest>
    {
        public UsputniGradoviController(ICRUDService<Model.UsputniGradovi, UsputniGradoviSearchRequest, UsputniGradoviUpsertRequest, UsputniGradoviUpsertRequest> service) : base(service)
        {
        }
    }
}
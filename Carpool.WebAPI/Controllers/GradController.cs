using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Model;
using Carpool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradController : BaseCRUDController<Model.Grad, object, Model.Grad, Model.Grad>
    {
        public GradController(ICRUDService<Grad, object, Grad, Grad> service) : base(service)
        {
        }
    }
}
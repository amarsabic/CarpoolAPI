using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.WebAPI.Controllers
{
    public class VoznjaController : BaseCRUDController<Voznja, VoznjaSearchRequest, VoznjaUspertRequest, VoznjaUspertRequest>
    {
        public VoznjaController(ICRUDService<Voznja, VoznjaSearchRequest, VoznjaUspertRequest, VoznjaUspertRequest> service) : base(service)
        {
        }

        [AllowAnonymous]
        [HttpGet("{id}/recommend")]
        public List<Model.Voznja> Recommend(int id)
        {
            return (_service as IVoznjaService).Recommend(id);
        }
    }
}
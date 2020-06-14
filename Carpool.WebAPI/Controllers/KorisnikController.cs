using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _korisnikService;
        public KorisnikController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }

        [HttpGet]
        public ActionResult<List<Model.Korisnik>> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _korisnikService.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Korisnik GetById(int id)
        {
            return _korisnikService.GetById(id);
        }

        [HttpPost]
        public Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            return _korisnikService.Insert(request);
        }


        [HttpPut("{id}")]
        public Model.Korisnik Update(int id, KorisnikInsertRequest request)
        {
            return _korisnikService.Update(id, request);
        }

    }
}
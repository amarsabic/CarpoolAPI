using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Exceptions;
using Carpool.WebAPI.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class AutomobilService : BaseCRUDService<Model.Automobil, AutomobilSearchRequest, Database.Automobil, AutomobilInsertRequest, AutomobilInsertRequest>
    {
        private readonly IHttpContextAccessor _httpContext;
        public AutomobilService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override Model.Automobil Delete(int id)
        {
            var entity = _context.Autmobili.Find(id);

            var voznjeAktivne = _context.Voznje.Where(v => v.AutomobilID == id && v.IsAktivna).ToList();
            var voznjeZavrsene = _context.Voznje.Where(v => v.AutomobilID == id && !v.IsAktivna).ToList();

            if (voznjeAktivne.Count == 0)
            {
                if (voznjeZavrsene.Count > 0)
                {
                    foreach (var zavrsene in voznjeZavrsene)
                    {
                        var rezervacije = _context.Rezervacije.Where(u => u.VoznjaID == zavrsene.VoznjaID).ToList();
                        if (rezervacije.Count() != 0)
                        {
                            foreach (var item in rezervacije)
                            {
                                _context.Rezervacije.Remove(item);
                            }
                        }

                        var usputniGradovi = _context.UsputniGradovi.Where(u => u.VoznjaID == zavrsene.VoznjaID).ToList();
                        if (usputniGradovi.Count() != 0)
                        {
                            foreach (var item in usputniGradovi)
                            {
                                _context.UsputniGradovi.Remove(item);
                            }
                        }

                        _context.Voznje.Remove(zavrsene);
                    }
                }
                _context.SaveChanges();

                _context.Autmobili.Remove(entity);
                _context.SaveChanges();

                return _mapper.Map<Model.Automobil>(entity);
            }
            else
            {
                throw new UserException("Vozilo trenutno u vožnji");
            }
        }

        public override List<Model.Automobil> Get(AutomobilSearchRequest request)
        {
            var userId = _httpContext.GetUserId();

            var query = _context.Autmobili.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(request?.Model))
            {
                query = query.Where(x => x.Model.StartsWith(request.Model));
            }
            if (!string.IsNullOrWhiteSpace(request?.Godiste))
            {
                query = query.Where(x => x.Godiste.StartsWith(request.Godiste));
            }
            if (!string.IsNullOrWhiteSpace(request?.BrojRegistracije))
            {
                query = query.Where(x => x.BrojRegOznaka == request.BrojRegistracije);
            }
            if (request.IsVozac)
            {
                query = query.Where(x => x.VozacID == int.Parse(userId));
            }
            if (request.PretragaPoVozacID)
            {
                query = query.Where(x => x.VozacID == request.VozacID);
            }
            if (request.ProvjeraAktivnosti)
            {
                query = query.Where(x => !x.IsAktivan);
            }
            var result = query.ToList();

            return _mapper.Map<List<Model.Automobil>>(result);
        }
        public override Model.Automobil Insert(AutomobilInsertRequest request)
        {
            var userId = _httpContext.GetUserId();

            var getAll = _context.Autmobili.ToList();
            foreach (var auto in getAll)
            {
                if (request.BrojRegOznaka == auto.BrojRegOznaka)
                    throw new UserException("Broj registarskih oznaka već postoji!");
            }

            var entity = _mapper.Map<Database.Automobil>(request);
            entity.VozacID = int.Parse(userId);
            entity.IsAktivan = false;

            _context.Autmobili.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Automobil>(entity);
        }

        public override Model.Automobil Update(int id, AutomobilInsertRequest request)
        {
            var entity = _context.Autmobili.Find(id);
            _context.Autmobili.Attach(entity);
            _context.Autmobili.Update(entity);

            if (request.Slika == null)
            {
                request.Slika = entity.Slika;
                request.SlikaThumb = entity.SlikaThumb;
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Automobil>(entity);
        }
    }
}

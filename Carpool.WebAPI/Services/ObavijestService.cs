﻿using AutoMapper;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class ObavijestService : BaseCRUDService<Model.Obavijesti, ObavijestiSearchRequest, Database.Obavijesti, ObavijestiUpsertRequest, ObavijestiUpsertRequest>
    {
        private readonly IHttpContextAccessor _httpContext;
        public ObavijestService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Obavijesti> Get(ObavijestiSearchRequest request)
        {

            var query = _context.Obavijesti.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(request.Naslov));
            }

            var result = query.ToList();

            var list = new List<Model.Obavijesti>();
            foreach (var item in result)
            {
                list.Add(new Model.Obavijesti
                {
                    DatumVrijemeObjave = item.DatumVrijemeObjave,
                    KorisnickoIme = _context.Korisnici.Where(k=>k.KorisnikID==item.VozacID).Select(k=>k.KorisnickoIme).FirstOrDefault(),
                    KratkiOpis = item.KratkiOpis,
                    Naslov = item.Naslov,
                    TipObavijestiID = item.TipObavijestiID,
                    NazivTipa = _context.TipObavijesti.Where(t=>t.TipObavijestiID==item.TipObavijestiID).Select(t=>t.NazivTipa).FirstOrDefault(),
                    ObavijestiID = item.ObavijestiID,
                    VozacID = item.VozacID
                });
            }

            return list;
        }

        public override Model.Obavijesti Insert(ObavijestiUpsertRequest request)
        {
            var userId = _httpContext.GetUserId();

            var entity = _mapper.Map<Database.Obavijesti>(request);
            entity.VozacID = int.Parse(userId);
            

            _context.Obavijesti.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Obavijesti>(entity);
        }
    }
}

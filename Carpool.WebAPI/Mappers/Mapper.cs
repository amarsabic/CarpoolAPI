﻿using AutoMapper;
using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            // CreateMap<Source, Dest>();
            CreateMap<Database.Korisnik, Model.Korisnik>().ReverseMap();
            CreateMap<Database.Korisnik, KorisnikInsertRequest>().ReverseMap();
            CreateMap<Model.Korisnik, KorisnikInsertRequest>().ReverseMap();
            CreateMap<Database.Automobil, Model.Automobil>();
            CreateMap<Database.Automobil, AutomobilInsertRequest>().ReverseMap();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Voznja, Model.Voznja>().ReverseMap();
            CreateMap<Database.Voznja, VoznjaUspertRequest>().ReverseMap();
            CreateMap<Model.Voznja, VoznjaUspertRequest>().ReverseMap();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();
            CreateMap<Database.Obavijesti, Model.Obavijesti>();
            CreateMap<Database.Obavijesti, ObavijestiUpsertRequest>().ReverseMap();
            CreateMap<Database.TipObavijesti, Model.TipObavijesti>();
            CreateMap<Database.TipOcjene, Model.TipOcjene>();
            CreateMap<Database.Grad, Model.Grad>().ReverseMap();
            CreateMap<Database.Vozac, Model.Vozac>();
            CreateMap<Database.Vozac, Model.Vozac>().ReverseMap();
            CreateMap<Database.Vozac, VozacUpsertRequest>().ReverseMap();
            CreateMap<Database.UsputniGradovi, Model.UsputniGradovi>().ReverseMap();
            CreateMap<Database.UsputniGradovi, UsputniGradoviUpsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, RezervacijaUpsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Rezervacija>().ReverseMap();
            CreateMap<Database.Ocjene, OcjenaUpsertRequest>().ReverseMap();
            CreateMap<Database.Ocjene, Model.Ocjene>().ReverseMap();
        }
    }
}

using AutoMapper;
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
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Korisnik, KorisnikInsertRequest>().ReverseMap();
            CreateMap<Database.Automobil, Model.Automobil>();
            CreateMap<Database.Automobil, AutomobilInsertRequest>().ReverseMap();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Automobil, Model.AutomobilComboBox>();
            CreateMap<Database.Voznja, Model.Voznja>();
            CreateMap<VoznjaUpsertRequest, Database.Voznja>();
            CreateMap<VoznjaUpsertRequest, Model.Voznja>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();
            CreateMap<Database.Obavijesti, Model.Obavijesti>();
            CreateMap<Database.Obavijesti, ObavijestiUpsertRequest>().ReverseMap();
            CreateMap<Database.TipObavijesti, Model.TipObavijesti>();
            CreateMap<Database.Grad, Model.Grad>().ReverseMap();
        }
    }
}

using Carpool.Model;
using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public interface IKorisnikService
    {
        List<Model.Korisnik> Get(KorisniciSearchRequest request);

        Model.Korisnik GetById(int id);

        Model.Korisnik Insert(KorisnikInsertRequest request);

        Model.Korisnik Update(int id, KorisnikInsertRequest request);

        Model.Korisnik Authenticiraj(string username, string pass);
        Model.Korisnik Auth();
        Korisnik Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Carpool.WebAPI.Database
{
    public class Korisnik
    {
        public Korisnik()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
        }
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Spol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }

        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public int GradID { get; set; }
        public Grad Grad { get; set; }
        public virtual Vozac Vozac { get; set; }
        public int? PreferencijeID { get; set; }
        public Preferencije Preferencije { get; set; }

        public bool IsVozac { get; set; }

        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public List<Rezervacija> Rezervacije { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}

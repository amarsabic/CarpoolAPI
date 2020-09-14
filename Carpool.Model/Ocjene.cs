using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Ocjene
    {
        public int OcjeneID { get; set; }
        public string Komentar { get; set; }
        public int TipOcjeneID { get; set; }
        public TipOcjene TipOcjene { get; set; }
        public int OcjenaNaziv { get; set; }
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public string KorisnickoIme { get; set; }
        public int VoznjaID { get; set; }
        public Voznja Voznja { get; set; }
    }
}

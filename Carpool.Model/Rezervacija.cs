using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int VoznjaID { get; set; }
        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
        public int? UsputniGradId { get; set; }
        public string UsputniGradNaziv { get; set; }
        public string OpisPrtljaga { get; set; }
    }
}

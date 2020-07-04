using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Obavijesti
    {
        public int ObavijestiID { get; set; }
        public string KratkiOpis { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumVrijemeObjave { get; set; }
        public int TipObavijestiID { get; set; }
        public string NazivTipa { get; set; }
        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
    }
}

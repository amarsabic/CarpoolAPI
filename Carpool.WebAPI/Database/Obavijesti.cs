using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Database
{
    public class Obavijesti
    {
        public int ObavijestiID { get; set; }
        public string KratkiOpis { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumVrijemeObjave { get; set; }

        public int TipObavijestiID { get; set; }
        public TipObavijesti TipObavijesti { get; set; }

        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}

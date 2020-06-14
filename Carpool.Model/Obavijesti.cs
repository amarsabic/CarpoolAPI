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
        public int VozacID { get; set; }
    }
}

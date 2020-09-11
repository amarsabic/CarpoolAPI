using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class ObavijestiSearchRequest
    {
        public string Naslov { get; set; }
        public string KratkiOpis { get; set; }
        public string KorisnikIme { get; set; }
        public DateTime DatumObjave { get; set; }
        public int? TipObavijestiID { get; set; }

        public bool IsKorisnik { get; set; }
    }
}

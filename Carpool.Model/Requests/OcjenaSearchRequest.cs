using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class OcjenaSearchRequest
    {
        public bool byVoznjaID { get; set; }
        public bool byVoznjaKorisnik { get; set; }
        public int KorisnikID { get; set; }
        public int VoznjaID { get; set; }
    }
}

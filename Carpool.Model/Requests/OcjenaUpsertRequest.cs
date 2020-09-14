using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
   public class OcjenaUpsertRequest
    {
        public string Komentar { get; set; }
        public int TipOcjeneID { get; set; }
        public int KorisnikID { get; set; }
        public int VoznjaID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class RezervacijaUpsertRequest
    {
        public int RezervacijaID { get; set; }
        public int VoznjaID { get; set; }
        public int? UsputniGradID { get; set; }
    }
}

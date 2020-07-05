using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class RezervacijaSearchRequest
    {
        public bool ByVoznjaId { get; set; } = false;
        public int VoznjaID { get; set; }
    }
}

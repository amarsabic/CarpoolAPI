using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class RezervacijaSearchRequest
    {
        public bool ByVoznjaId { get; set; } = false;
        public bool ByVoznjaUserId { get; set; } = false;
        public int VoznjaID { get; set; }
        public bool UserActive { get; set; }
        public bool UserAll { get; set; }
        public bool UserNonActive { get; set; }
    }
}

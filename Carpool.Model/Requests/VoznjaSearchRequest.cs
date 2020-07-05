using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class VoznjaSearchRequest
    {
        public int? GradPolaskaID { get; set; }
        public int? GradDestinacijaID { get; set; }
        public bool IsVozac { get; set; } = false;
        public bool IsSlobodnaMjesta { get; set; } = false;
        public bool PosljednjeVoznje { get; set; } = false;
    }
}

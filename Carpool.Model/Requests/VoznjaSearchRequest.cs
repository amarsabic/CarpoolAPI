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
        public bool IsVozacZavrsene { get; set; } = false;
        public bool IsVozacZavrseneDesktop { get; set; } = false;
        public int? VozacID { get; set; }
        public bool IsZavrsena{ get; set; } = false;
        public bool IsSlobodnaMjesta { get; set; } = false;
        public bool PosljednjeVoznje { get; set; } = false;
        public bool SearchFromHomePage { get; set; } = false;
        public bool Recommended { get; set; } = false;
        public DateTime DatumPolaska { get; set; }
        public DateTime VrijemePolaska { get; set; }
    }
}

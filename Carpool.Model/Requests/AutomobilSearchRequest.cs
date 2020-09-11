using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class AutomobilSearchRequest
    {
        public string Naziv { get; set; }

        public bool PretragaPoVozacID { get; set; }
        public int VozacID { get; set; }
        public string Model { get; set; }
        public string Godiste { get; set; }
        public string BrojRegistracije { get; set; }
        public bool IsVozac { get; set; }
        public bool ProvjeraAktivnosti { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class AutomobilSearchRequest
    {
        public string Naziv { get; set; }
        public string Model { get; set; }
        public string Godiste { get; set; }

        public bool IsVozac { get; set; }
    }
}

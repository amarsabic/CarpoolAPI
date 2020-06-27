using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class VozacUpsertRequest
    {
        public int VozacID { get; set; }
        public string BrVozackeDozvole { get; set; }
        public DateTime DatumIstekaVozackeDozvole { get; set; }
    }
}

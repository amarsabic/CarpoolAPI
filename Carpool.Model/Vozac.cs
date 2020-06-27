using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Vozac
    {
        public int VozacID { get; set; }
        public string BrVozackeDozvole { get; set; }
        public DateTime DatumIstekaVozackeDozvole { get; set; }
        public List<Automobil> Automobili { get; set; }
    }
}

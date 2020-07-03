using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Voznja
    {
        public DateTime DatumPolaska { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public DateTime DatumObjave { get; set; }
        public int SlobodnaMjesta { get; set; }
        public decimal PunaCijena { get; set; }
        public bool IsAktivna { get; set; }
        public int VozacID { get; set; }
        public int AutomobilID { get; set; }
        public int GradPolaskaID { get; set; }
        public int GradDestinacijaID { get; set; }
        public List<int> UsputniGradoviInt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Database
{
    public class UsputniGradovi
    {
        public int UsputniGradoviID { get; set; }
        public int GradPoRedu { get; set; }
        public decimal CijenaUsputni { get; set; }
        public int VoznjaID { get; set; }
        public Voznja Voznja { get; set; }
        public int GradID { get; set; }
        public Grad Grad { get; set; }
    }
}

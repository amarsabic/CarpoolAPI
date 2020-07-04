using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class UsputniGradoviUpsertRequest
    {
        public int GradPoRedu { get; set; }
        public decimal CijenaUsputni { get; set; }
        public int VoznjaID { get; set; }
        public int GradID { get; set; }
        public Grad Grad { get; set; }
    }
}

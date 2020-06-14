using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class AutomobilComboBox
    {
        public int AutomobilID { get; set; }
        public string Naziv { get; set; }
        public string Model { get; set; }

        public string NazivModel
        {
            get
            {
                return Naziv + " " + Model;
            }
        }
    }
}

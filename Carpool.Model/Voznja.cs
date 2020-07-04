using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Voznja
    {
        public int VoznjaID { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public DateTime DatumObjave { get; set; }
        public int SlobodnaMjesta { get; set; }
        public decimal PunaCijena { get; set; }
        public bool IsAktivna { get; set; }
        public string IsAktivnaString
        {
            get
            {
                if (IsAktivna)
                {
                    return "Aktivna";
                }
                else
                {
                    return "Neaktivna";

                }
            }
        }
        public int VozacID { get; set; }
        public string KorisnickoIme { get; set; }
        public int AutomobilID { get; set; }
        public string AutomobilNazivModel { get; set; }
        public int GradPolaskaID { get; set; }
        public string GradPolaska { get; set; }
        public int GradDestinacijaID { get; set; }
        public string GradDestinacija { get; set; }
        public List<UsputniGradovi> UsputniGradoviDva { get; set; }
        public List<string> UsputniGradoviNaziv { get; set; }
    }
}

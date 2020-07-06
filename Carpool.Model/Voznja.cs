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

        public string DatumPolaskaString
        {
            get
            {
                return DatumPolaska.ToShortDateString();
            }
        }

        public string VrijemePolaskaString
        {
            get
            {
                return DatumPolaska.ToShortTimeString();
            }
        }
        public string PunaCijenaPrikaz
        {
            get
            {
                return PunaCijena.ToString() + " BAM";
            }
        }
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
        public string KorisnickoImePrikaz
        {
            get
            {
                return "Objavio/la " + KorisnickoIme;
            }
        }
        public int AutomobilID { get; set; }
        public string AutomobilNazivModel { get; set; }
        public int GradPolaskaID { get; set; }
        public string GradPolaska { get; set; }
        public int GradDestinacijaID { get; set; }
        public string GradDestinacija { get; set; }
        public ICollection<UsputniGradovi> UsputniGradoviE { get; set; }
        public List<Grad> UsputniGradoviGrad { get; set; } = new List<Grad>();
        public List<string> UsputniGradoviNaziv { get; set; }
    }
}

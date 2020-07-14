using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Database
{
    public class Voznja
    {
        public Voznja()
        {
            UsputniGradovi = new HashSet<UsputniGradovi>();
            Rezervacije = new HashSet<Rezervacija>();
            Ocjene = new HashSet<Ocjene>();
        }
        public int VoznjaID { get; set; }
        public DateTime DatumPolaska { get; set; }
        public string VrijemePolaska { get; set; }
        public DateTime DatumObjave { get; set; }
        public int SlobodnaMjesta { get; set; }
        public decimal PunaCijena { get; set; }
        public bool IsAktivna { get; set; }
        public int VozacID { get; set; }
        public Vozac Vozac { get; set; }

        public int AutomobilID { get; set; }
        public Automobil Automobil { get; set; }

        public int GradPolaskaID { get; set; }
        public virtual Grad GradPolaska { get; set; }
        public int GradDestinacijaID { get; set; }
        public virtual Grad GradDestinacija { get; set; }

        public ICollection<UsputniGradovi> UsputniGradovi { get; set; }
        public ICollection<Rezervacija> Rezervacije { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
    }
}

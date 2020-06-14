using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Database
{
    public class Vozac
    {
        [ForeignKey("Korisnik")]
        public int VozacID { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public List<Automobil> Automobili { get; set; }
        public string BrVozackeDozvole { get; set; }
        public DateTime DatumIstekaVozackeDozvole { get; set; }
    }
}

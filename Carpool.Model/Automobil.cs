using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model
{
    public class Automobil
    {
        public int AutomobilID { get; set; }
        public string Naziv { get; set; }
        public string Model { get; set; }
        public string NazivModel { get { return Naziv + " " + Model; } }
        public string Godiste { get; set; }
        public string BrojRegOznaka { get; set; }
        public bool IsAktivan { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}

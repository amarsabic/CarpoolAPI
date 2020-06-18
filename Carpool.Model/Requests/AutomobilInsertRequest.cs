using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class AutomobilInsertRequest
    {
        public string Naziv { get; set; }
        public string Model { get; set; }
        public string Godiste { get; set; }
        public string BrojRegOznaka { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}

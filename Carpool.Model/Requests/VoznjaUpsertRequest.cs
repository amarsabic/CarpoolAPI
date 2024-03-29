﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Carpool.Model.Requests
{
    public class VoznjaUspertRequest
    {
        public DateTime DatumPolaska { get; set; }
        public string VrijemePolaska { get; set; }
        public DateTime DatumObjave { get; set; }
        public int SlobodnaMjesta { get; set; }
        public decimal PunaCijena { get; set; }
        public bool IsAktivna { get; set; }
        public bool ZavrsiVoznju { get; set; } = false;
        public int AutomobilID { get; set; }
        public int GradPolaskaID { get; set; }
        public int GradDestinacijaID { get; set; }
        public List<Grad> UsputniGradoviGrad { get; set; } = new List<Grad>();
    }
}

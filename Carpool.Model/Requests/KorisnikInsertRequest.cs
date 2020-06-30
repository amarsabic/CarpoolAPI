using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Carpool.Model.Requests
{
    public class KorisnikInsertRequest
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string OldPassword { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int GradID { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
    }
}

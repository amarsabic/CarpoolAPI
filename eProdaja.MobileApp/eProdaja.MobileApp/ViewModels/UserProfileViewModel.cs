using Carpool.Model;
using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        private readonly APIService _korisnik = new APIService("Korisnik");
        public UserProfileViewModel()
        {
          
        }

        string _username = string.Empty;
        public string KorisnickoIme
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }
        public ICommand LoadKorisnik { get; set; }

        public async Task Load()
        {
        
            try
            {
                var k = await _korisnik.GetById<Korisnik>(1);
                KorisnickoIme = k.KorisnickoIme;
                Slika = k.Slika;
            }
            catch (Exception)
            {

            }
        }
    }
}

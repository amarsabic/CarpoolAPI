using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnik");

        public RegisterViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
        }

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        DateTime _datum = DateTime.MaxValue;
        public DateTime Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }
        int _grad = 0;
        public int GradID
        {
            get { return _grad; }
            set { SetProperty(ref _grad, value); }
        }

        string _username = string.Empty;
        public string KorisnickoIme
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Lozinka
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _passwordConf = string.Empty;
        public string LozinkaPotvrda
        {
            get { return _passwordConf; }
            set { SetProperty(ref _passwordConf, value); }
        }

        public ICommand RegisterCommand { get; set; }

        async Task Register()
        {
            IsBusy = true;
           
     
        }
    }
}

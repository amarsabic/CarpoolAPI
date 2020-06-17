using Carpool.Model;
using Carpool.Model.Requests;
using eProdaja.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly APIService _korisnik = new APIService("Korisnik");
        private readonly APIService _gradovi = new APIService("Grad");
        public RegisterViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
            LoadCommand = new Command(async () => await LoadGradovi());
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

        ObservableCollection<Grad> _Gradovi = new ObservableCollection<Grad>();

        public ObservableCollection<Grad> Gradovi
        {
            get { return _Gradovi; }
            set { SetProperty(ref _Gradovi, value); }
        }

        private Grad _selectedGrad;
        public Grad SelectedGrad
        {
            get { return _selectedGrad; }
            set { SetProperty(ref _selectedGrad, value); }
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
        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }

        string _passwordConf = string.Empty;
        public string LozinkaPotvrda
        {
            get { return _passwordConf; }
            set { SetProperty(ref _passwordConf, value); }
        }
        public ICommand LoadCommand { get; set; }
        async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Grad>>(null);

            _Gradovi.Clear();
            foreach (var grad in result)
            {
                _Gradovi.Add(grad);
            }
        }


        public ICommand RegisterCommand { get; set; }

        public async Task Register()
        {
            var request = new KorisnikInsertRequest
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                KorisnickoIme = KorisnickoIme,
                GradID = SelectedGrad.GradID,
                Password = Lozinka,
                PasswordConfirmation = LozinkaPotvrda,
                BrojTelefona= Telefon
            };

            try
            {
                await _korisnik.Insert<dynamic>(request);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješna registracija", "OK");
                Application.Current.MainPage = new LoginPage();
            }
            catch (Exception)
            {

            }

        }
    }
}

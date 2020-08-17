using Carpool.Model;
using Carpool.Model.Requests;
using eProdaja.MobileApp.Services;
using eProdaja.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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
        bool _photoPicked = false;
        public bool PhotoPicked
        {
            get { return _photoPicked; }
            set { SetProperty(ref _photoPicked, value); }
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

        DateTime _datum;
        public DateTime Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set
            {
                SetProperty(ref _slika, value);
                PhotoPicked = true;
            }
        }
        public byte[] _slikaThumb = null;
        public byte[] SlikaThumb
        {
            get { return _slikaThumb; }
            set { SetProperty(ref _slikaThumb, value); }

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
        public async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Grad>>(null);

            _Gradovi.Clear();
            foreach (var grad in result)
            {
                _Gradovi.Add(grad);
            }
        }

        public ICommand RegisterCommand { get; set; }

        public bool Validate()
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);

            if (string.IsNullOrWhiteSpace(Ime) || string.IsNullOrWhiteSpace(Prezime) ||
                string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(KorisnickoIme) || string.IsNullOrWhiteSpace(Telefon) || string.IsNullOrWhiteSpace(Telefon) 
                || string.IsNullOrWhiteSpace(Lozinka) || string.IsNullOrWhiteSpace(LozinkaPotvrda))
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Popunite sva polja!", "OK");
                return false;
            }
            else if (Ime.Length < 3)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Ime mora sadržavati minimalno 3 karaktera!", "OK");
                return false;
            }
            else if (Prezime.Length < 2)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Prezime mora sadržavati minimalno 2 karaktera!", "OK");
                return false;
            }
            else if (!match.Success)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Mail mora biti u formatu mail@mail.com!", "OK");
                return false;
            }
            else if (KorisnickoIme.Length < 4)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime mora sadržavati minimalno 4 karaktera!", "OK");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Telefon, "^[0-9]*$"))
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Telefon može sadržavati samo brojeve!", "OK");
                return false;
            }
            else if (Telefon.Length != 9)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Telefon mora sadržavati 9 brojeva!", "OK");
                return false;
            }
            else if (SelectedGrad == null)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Odaberite grad!", "OK");
                return false;
            }
            else if (Datum == null)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Odaberite datum!", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task Register()
        {

            if (!Validate())
            {
                return;
            }
            var request = new KorisnikInsertRequest
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                KorisnickoIme = KorisnickoIme,
                GradID = SelectedGrad.GradID,
                Password = Lozinka,
                PasswordConfirmation = LozinkaPotvrda,
                BrojTelefona = Telefon,
                Slika = Slika,
                SlikaThumb = SlikaThumb,
                DatumRodjenja = Datum
            };

            try
            {
                await _korisnik.Insert<dynamic>(request);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješna registracija", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {

            }
        }
    }
}

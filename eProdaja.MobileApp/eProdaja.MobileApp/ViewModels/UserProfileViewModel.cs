using Carpool.Model;
using Carpool.Model.Requests;
using eProdaja.MobileApp.Views;
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
        private readonly APIService _vozac = new APIService("Vozac");
        private readonly APIService _gradovi = new APIService("Grad");
        public UserProfileViewModel()
        {
            LogoutCommand = new Command(async () => await Logout());
            AddVozacCommand = new Command(async () => await AddVozac());
            LoadGradoviCommand = new Command(async () => await LoadGradovi());
            EditCommand = new Command(async () => await SaveEdit());
            UpdatePasswordCommand = new Command(async () => await UpdatePassword());
        }



        int korisnikId;
        bool _isVozac;
        public bool IsVozac
        {
            get { return _isVozac; }
            set { SetProperty(ref _isVozac, value); }
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

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }

        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
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
        string _passwordOld = string.Empty;
        public string StaraLozinka
        {
            get { return _passwordOld; }
            set { SetProperty(ref _passwordOld, value); }
        }
        public ICommand LoadKorisnik { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand AddVozacCommand { get; set; }
        public ICommand LoadGradoviCommand { get; set; }

        public ICommand EditCommand { get; set; }
        public ICommand UpdatePasswordCommand { get; set; }

        public async Task UpdatePassword()
        {
            var request = new KorisnikInsertRequest
            {
                Password = Lozinka,
                PasswordConfirmation = LozinkaPotvrda,
                OldPassword = StaraLozinka
            };

            try
            {
                await _korisnik.Update<Korisnik>(korisnikId, request);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješna izmjena podataka", "OK");

                Lozinka = StaraLozinka = LozinkaPotvrda = "";
            }
            catch (Exception)
            {

            }
        }

        public async Task SaveEdit()
        {
            var request = new KorisnikInsertRequest
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                KorisnickoIme = KorisnickoIme,
                GradID = SelectedGrad.GradID,
                //  Password = Lozinka,
                //  PasswordConfirmation = LozinkaPotvrda,
                BrojTelefona = Telefon,
                Slika = Slika,
                SlikaThumb = Slika,
                DatumRodjenja = Datum

                //PASSWORD??????
            };

            try
            {
                await _korisnik.Update<Korisnik>(korisnikId, request);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješna izmjena podataka", "OK");
            }
            catch (Exception)
            {

            }
        }

        public async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Grad>>(null);

            _Gradovi.Clear();
            foreach (var grad in result)
            {
                _Gradovi.Add(grad);
            }
        }
        public async Task AddVozac()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AddVozacPage());
        }

        public async Task Logout()
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
        public async Task Load()
        {
            try
            {
                var k = await _korisnik.GetById<Korisnik>(0);
                KorisnickoIme = k.KorisnickoIme;
                Slika = k.Slika;
                Ime = k.Ime;
                Prezime = k.Prezime;
                Datum = k.DatumRodjenja;
                Email = k.Email;
                Telefon = k.BrojTelefona;


                foreach (var grad in _Gradovi)
                {
                    if (grad.GradID == k.GradID)
                    {
                        SelectedGrad = grad;
                    }
                }

                IsVozac = !k.IsVozac;
                korisnikId = k.KorisnikID;
            }
            catch (Exception er)
            {

            }
        }
    }
}

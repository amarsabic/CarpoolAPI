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
    public class RideDetailsViewModel:BaseViewModel
    {
        private readonly APIService _automobili = new APIService("Automobil");
        private readonly APIService _voznja = new APIService("Voznja");
        private readonly APIService _rezervacija = new APIService("Rezervacija");
        public RideDetailsViewModel()
        {
            InitCommand = new Command(async (param) => await Init((int)param));
            MainReservationCommand = new Command(async () => await MainReservation());
            RouteCityReservationCommand = new Command(async (param) => await RouteCityReservation((int)param));
        }

        ObservableCollection<Grad> _UsputniGradovi = new ObservableCollection<Grad>();

        public int voznjaID;

        public ObservableCollection<Grad> UsputniGradovi
        {
            get { return _UsputniGradovi; }
            set { SetProperty(ref _UsputniGradovi, value); }
        }

        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        public string _korisnickoIme = null;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        public string _gradPolaska = null;
        public string GradPolaska
        {
            get { return _gradPolaska; }
            set { SetProperty(ref _gradPolaska, value); }
        }
        public string _gradDestinacija = null;
        public string GradDestinacija
        {
            get { return _gradDestinacija; }
            set { SetProperty(ref _gradDestinacija, value); }
        }
        public string _punaCijenaPrikaz = null;
        public string PunaCijenaPrikaz
        {
            get { return _punaCijenaPrikaz; }
            set { SetProperty(ref _punaCijenaPrikaz, value); }
        }
        public int _slobodnaMjesta;
        public int SlobodnaMjesta
        {
            get { return _slobodnaMjesta; }
            set { SetProperty(ref _slobodnaMjesta, value); }
        }

        public decimal _punaCijena;
        public decimal PunaCijena
        {
            get { return _punaCijena; }
            set { SetProperty(ref _punaCijena, value); }
        }

        public string _datumPolaska;
        public string DatumPolaska
        {
            get { return _datumPolaska; }
            set { SetProperty(ref _datumPolaska, value); }
        }
        public string _datumObjave;
        public string DatumObjave
        {
            get { return _datumObjave; }
            set { SetProperty(ref _datumObjave, value); }
        }
        public string _vrijemePolaska;
        public string VrijemePolaska
        {
            get { return _vrijemePolaska; }
            set { SetProperty(ref _vrijemePolaska, value); }
        }
        public ICommand InitCommand { get; set; }
        public ICommand MainReservationCommand { get; set; }
        public ICommand RouteCityReservationCommand { get; set; }
        public async Task RouteCityReservation(int usputniGradID)
        {
            try
            {
                RezervacijaUpsertRequest request = new RezervacijaUpsertRequest
                {
                    VoznjaID = voznjaID,
                    UsputniGradID = usputniGradID
                };
                await _rezervacija.Insert<Rezervacija>(request);
                await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješna rezervacija", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new PaymentPage(voznjaID));
            }
            catch (Exception)
            {

            }
        }
        public async Task MainReservation()
        {
            try
            {
                RezervacijaUpsertRequest request = new RezervacijaUpsertRequest
                {
                    VoznjaID = voznjaID
                    
                };
                await _rezervacija.Insert<Rezervacija>(request);
                await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješna rezervacija", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new PaymentPage(voznjaID));
            }
            catch (Exception)
            {

            }
        }

        public async Task Init(int voznjaId)
        {
            try
            {
                var v = await _voznja.GetById<Voznja>(voznjaId);

                var auto = await _automobili.GetById<Automobil>(v.AutomobilID);
                Slika = auto.Slika;

                KorisnickoIme = v.KorisnickoIme;
                GradPolaska = v.GradPolaska;
                GradDestinacija = v.GradDestinacija;
                SlobodnaMjesta = v.SlobodnaMjesta;
                PunaCijena = v.PunaCijena;
                DatumPolaska = v.DatumPolaska.ToShortDateString();
                VrijemePolaska = v.VrijemePolaska.ToShortTimeString();
                PunaCijenaPrikaz = v.PunaCijenaPrikaz;
                DatumObjave = v.DatumObjave.ToShortDateString();

                voznjaID = v.VoznjaID;
                foreach (var item in v.UsputniGradoviGrad)
                {
                    UsputniGradovi.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }

    }
}

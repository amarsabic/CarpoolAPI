using Carpool.Model;
using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class ReservationViewModel : BaseViewModel
    {
        private readonly APIService _rezervacija = new APIService("Rezervacija");
        private readonly APIService _voznja= new APIService("Voznja");
        private readonly APIService _auto= new APIService("Automobil");
        public ReservationViewModel()
        {
            LoadRezervacijeCommand = new Command(async (param) => await LoadRezervacije((int)param));
            DeleteRezervacijaCommand = new Command(async (param) => await DeleteRezervacija((int)param));
        }

        ObservableCollection<Rezervacija> _Rezervacije = new ObservableCollection<Rezervacija>();

        public ObservableCollection<Rezervacija> Rezervacije
        {
            get { return _Rezervacije; }
            set { SetProperty(ref _Rezervacije, value); }
        }


        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
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


        public ICommand LoadRezervacijeCommand { get; set; }
        public ICommand DeleteRezervacijaCommand { get; set; }

        public async Task DeleteRezervacija(int rezervacijaId)
        {
            try
            {
                await _rezervacija.Delete<Rezervacija>(rezervacijaId);
                await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno uklonjena rezervacija", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {

            }
        }

        public async Task LoadRezervacije(int voznjaID)
        {
            try
            {
                var voz = await _voznja.GetById<Voznja>(voznjaID);
                var auto = await _auto.GetById<Automobil>(voz.AutomobilID);
                GradPolaska = voz.GradPolaska;
                GradDestinacija = voz.GradDestinacija;
                Slika = auto.Slika;

                RezervacijaSearchRequest search = new RezervacijaSearchRequest
                {
                    ByVoznjaId=true,
                    VoznjaID=voznjaID
                };

                var rez = await _rezervacija.Get<List<Rezervacija>>(search);
                if (rez.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nema aktivnih rezervacija", "OK");
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                else
                {
                    foreach (var item in rez)
                    {
                        Rezervacije.Add(item);
                    }

                }
            }
            catch (Exception)
            {

            }
        }

    }
}

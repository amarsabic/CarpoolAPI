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
    public class TravelPageViewModel : BaseViewModel
    {
        private readonly APIService _rezervacija = new APIService("Rezervacija");
        public TravelPageViewModel()
        {
            LoadCommand = new Command(async () => await Load());
            ZavrsenaCommand = new Command(async () => await Zavrsena());
            AktivnaCommand = new Command(async () => await Aktivna());
        }

        public ObservableCollection<Rezervacija> _RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();

        public bool _visibleUsputni = false;
        public bool VisibleUsputni
        {
            get { return _visibleUsputni; }
            set { SetProperty(ref _visibleUsputni, value); }
        }

        public bool _zavrsenaBool = false;
        public bool ZavrsenaBool
        {
            get { return _zavrsenaBool; }
            set { SetProperty(ref _zavrsenaBool, value); }
        }

        public bool _aktivnaBool = false;
        public bool AktivnaBool
        {
            get { return _aktivnaBool; }
            set { SetProperty(ref _aktivnaBool, value); }
        }

        public ICommand LoadCommand { get; set; }
        public ICommand AktivnaCommand { get; set; }
        public ICommand ZavrsenaCommand { get; set; }


        public async Task Load()
        {
            try
            {
                RezervacijaSearchRequest search = new RezervacijaSearchRequest
                {
                    UserAll = true
                };

                var model = await _rezervacija.Get<List<Rezervacija>>(search);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate niti jednu rezervaciju", "OK");
                    return;
                }

                _RezervacijeList.Clear();
                foreach (var rezervacija in model)
                {
                    _RezervacijeList.Add(rezervacija);
                }
                AktivnaBool = false;
            }
            catch (Exception)
            {

            }
        }

        public async Task Aktivna()
        {
            try
            {
                RezervacijaSearchRequest search = new RezervacijaSearchRequest
                {
                    UserActive=true
                };

                var model = await _rezervacija.Get<List<Rezervacija>>(search);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate niti jednu rezervaciju", "OK");
                    return;
                }

                _RezervacijeList.Clear();
                foreach (var rezervacija in model)
                {
                    _RezervacijeList.Add(rezervacija);
                }

                ZavrsenaBool = false;
                AktivnaBool = true;
            }
            catch (Exception)
            {

            }
        }

        public async Task Zavrsena()
        {
            try
            {
                RezervacijaSearchRequest search = new RezervacijaSearchRequest
                {
                    UserNonActive=true
                };

                var model = await _rezervacija.Get<List<Rezervacija>>(search);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate niti jednu rezervaciju", "OK");
                    return;
                }

                _RezervacijeList.Clear();
                foreach (var rezervacija in model)
                {
                    _RezervacijeList.Add(rezervacija);
                }

                ZavrsenaBool = true;
                AktivnaBool = false;
            }
            catch (Exception)
            {

            }
        }
    }
}

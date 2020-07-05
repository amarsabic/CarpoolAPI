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
    public class RidePageViewModel : BaseViewModel
    {
        private readonly APIService _voznja = new APIService("Voznja");
        private readonly APIService _korisnik = new APIService("Korisnik");
        private readonly APIService _grad = new APIService("Grad");
        private readonly APIService _automobil = new APIService("Automobil");
        public RidePageViewModel()
        {
            LoadCommand = new Command(async () => await Load());
            DodajCommand = new Command(async () => await Dodaj());
            MojeVoznjeCommand = new Command(async () => await MojeVoznje());
            PrikaziSveCommand = new Command(async () => await Load());
            Last5Command = new Command(async () => await Last5());
        }

        public ObservableCollection<Voznja> VoznjeList { get; set; } = new ObservableCollection<Voznja>();

        public bool IsVisible
        {
            get { return APIService.IsVozac; }
        }

        public bool _mojeVoznjeBool = false;
        public bool MojeVoznjeBool
        {
            get { return _mojeVoznjeBool; }
            set { SetProperty(ref _mojeVoznjeBool, value); }
        }


        public ICommand LoadCommand { get; set; }
        public ICommand DodajCommand { get; set; }
        public ICommand MojeVoznjeCommand { get; set; }
        public ICommand PrikaziSveCommand { get; set; }
        public ICommand Last5Command { get; set; }

        public async Task Last5()
        {
            try
            {
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                   PosljednjeVoznje=true,
                   IsSlobodnaMjesta=true
                };

                var model = await _voznja.Get<List<Voznja>>(search);

                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }
            }
            catch (Exception)
            {

            }
        }
        public async Task MojeVoznje()
        {
            try
            {
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                    IsVozac = APIService.IsVozac
                };

                var model = await _voznja.Get<List<Voznja>>(search);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate aktivnih vožnji", "OK");
                }

                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }
                MojeVoznjeBool = true;

            }
            catch (Exception)
            {

            }
        }
        public async Task Dodaj()
        {
            AutomobilSearchRequest search = new AutomobilSearchRequest
            {
                IsVozac=true,
                ProvjeraAktivnosti=true
            };
            var auto = await _automobil.Get<List<Automobil>>(search);
            if (auto.Count != 0)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AddRidePage(null));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate dodane automobile", "OK");
                await Application.Current.MainPage.Navigation.PushAsync(new AddAutomobilPage(null));
            } 
        }

        public async Task Load()
        {
            try
            {
                VoznjaSearchRequest req = new VoznjaSearchRequest
                {
                    IsSlobodnaMjesta=true
                };
                var model = await _voznja.Get<List<Voznja>>(req);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nema aktivnih vožnji", "OK");
                }

                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }
                MojeVoznjeBool = false;
            }
            catch (Exception)
            {

            }
        }
    }
}

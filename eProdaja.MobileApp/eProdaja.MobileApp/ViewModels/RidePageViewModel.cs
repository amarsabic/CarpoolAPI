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
            //if (APIService.IsVozac)
            //{
            //    DodajCommand = new Command(async () => await Dodaj());

            //}
            //else
            //{
            //    DodajCommand = new Command(async () => await Dodaj2());

            //}
            DodajCommand = new Command(async () => await Dodaj());
        }

        public ObservableCollection<Voznja> VoznjeList { get; set; } = new ObservableCollection<Voznja>();

        public bool IsVisible
        {
            get { return APIService.IsVozac; }
        }

        public ICommand LoadCommand { get; set; }
        public ICommand DodajCommand { get; set; }
        public async Task Dodaj()
        {
            AutomobilSearchRequest search = new AutomobilSearchRequest
            {
                IsVozac=true
            };
            var auto = await _automobil.Get<List<Automobil>>(search);
            if (auto.Count != 0)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AddRidePage());
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
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                    IsVozac = APIService.IsVozac
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
    }
}

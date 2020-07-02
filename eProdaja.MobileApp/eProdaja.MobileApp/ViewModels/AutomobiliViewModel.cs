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
    public class AutomobiliViewModel
    {
        private readonly APIService _automobilService = new APIService("Automobil");
        private readonly APIService _korisnikService = new APIService("Korisnik");
        public AutomobiliViewModel()
        {
            InitCommand = new Command(async () => await Init());
            DodajCommand = new Command(async () => await Dodaj());
            //CarTappedCommand = new Command(async () => await CarTapped());
        }
        public ObservableCollection<Automobil> AutomobilList { get; set; } = new ObservableCollection<Automobil>();

        public ICommand InitCommand { get; set; }
        public ICommand DodajCommand { get; set; }
        //public ICommand CarTappedCommand { get; set; }

        public async Task Dodaj()
        {
           var IsVozac = await _korisnikService.GetById<Korisnik>(0);
            if (IsVozac.IsVozac)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AddAutomobilPage(null));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Carpool", "Greška! Niste vozač", "OK");
                await Application.Current.MainPage.Navigation.PushAsync(new AddVozacPage());
            }
        } 
        public async Task Init()
        {
            var searchByVozac = new AutomobilSearchRequest
            {
                IsVozac = true
            };
            var list = await _automobilService.Get<List<Automobil>>(searchByVozac);

            if (list.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate dodane automobile", "OK");
            }

            AutomobilList.Clear();
            foreach (var automobil in list)
            {
                AutomobilList.Add(automobil);
            }

        }
    }
}

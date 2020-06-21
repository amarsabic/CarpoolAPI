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
    public class AutomobiliViewModel
    {
        private readonly APIService _automobilService = new APIService("Automobil");
        public AutomobiliViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Automobil> AutomobilList { get; set; } = new ObservableCollection<Automobil>();

        public ICommand InitCommand { get; set; }

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

            if (AutomobilList.Count == 0)
            {
                AutomobilList.Clear();
                foreach (var automobil in list)
                {
                    AutomobilList.Add(automobil);
                }
            }        
        }
    }
}

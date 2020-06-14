using Carpool.Model;
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
            var list = await _automobilService.Get<List<Automobil>>(null);

            AutomobilList.Clear();
            foreach (var automobil in list)
            {
                AutomobilList.Add(automobil);
            }
        }
    }
}

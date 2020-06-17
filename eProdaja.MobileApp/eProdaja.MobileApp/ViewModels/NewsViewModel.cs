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
    public class NewsViewModel
    {
        private readonly APIService _obavijesti = new APIService("Obavijesti");
        public NewsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Obavijesti> ObavijestiList { get; set; } = new ObservableCollection<Obavijesti>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _obavijesti.Get<List<Obavijesti>>(null);

            ObavijestiList.Clear();
            foreach (var obavijest in list)
            {
                ObavijestiList.Add(obavijest);
            }
        }
    }
}

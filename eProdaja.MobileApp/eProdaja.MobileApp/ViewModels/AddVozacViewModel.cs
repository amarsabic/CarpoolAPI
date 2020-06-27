using Carpool.Model;
using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class AddVozacViewModel : BaseViewModel
    {
        private readonly APIService _vozac = new APIService("Vozac");
        public AddVozacViewModel()
        {
            SaveCommand = new Command(async () => await Save());
        }

        string _brojVozacke = string.Empty;
        public string BrVozackeDozvole
        {
            get { return _brojVozacke; }
            set { SetProperty(ref _brojVozacke, value); }
        }

        DateTime _datumIsteka;
        public DateTime DatumIstekaVozackeDozvole
        {
            get { return _datumIsteka; }
            set { SetProperty(ref _datumIsteka, value); }
        }

        public ICommand SaveCommand { get; set; }

        async Task Save()
        {
            var request = new VozacUpsertRequest
            {
                BrVozackeDozvole = BrVozackeDozvole,
                DatumIstekaVozackeDozvole = DatumIstekaVozackeDozvole
            };

            try
            {
                await _vozac.Insert<Vozac>(request);
                await Application.Current.MainPage.DisplayAlert("OK", "Postali ste vozač!", "OK");

                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {

            }
        }
    }
}

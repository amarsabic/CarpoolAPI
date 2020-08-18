using Carpool.Model;
using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool Validate()
        {

            Regex regex = new Regex("^[A-Z0-9]+$");
            Match match = regex.Match(BrVozackeDozvole);

            if (string.IsNullOrWhiteSpace(BrVozackeDozvole))
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Unesite broj vozačke dozvole!", "OK");
                return false;
            }
            else if (BrVozackeDozvole.Length != 9)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Broj mora imati tačno 9 karaktera!", "OK");
                return false;
            }
            else if (!match.Success)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Broj mora sadržavati velika slova i brojeve!", "OK");
                return false;
            }
            else if (DatumIstekaVozackeDozvole < DateTime.Now)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Vaša vozačka dozvola je istekla!", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }

        async Task Save()
        {
            if (!Validate())
            {
                return;
            }
            var request = new VozacUpsertRequest
            {
                BrVozackeDozvole = BrVozackeDozvole,
                DatumIstekaVozackeDozvole = DatumIstekaVozackeDozvole
            };

            try
            {
                var vozac = await _vozac.Insert<Vozac>(request);
                await Application.Current.MainPage.DisplayAlert("Carpool", "Postali ste vozač!", "OK");

                if (vozac != null)
                {
                    APIService.IsVozac = true;
                }

                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {

            }
        }
    }
}

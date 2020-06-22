using Carpool.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class InfoAutomobilViewModel : BaseViewModel
    {
        private readonly APIService _automobilService = new APIService("Automobil");

        public InfoAutomobilViewModel()
        {
            InitCommand = new Command(async (param) => await Init((int)param));
            UkloniCommand = new Command(async () => await Ukloni());
        }

        int AutomobilID;

        string _nazivModel = string.Empty;
        public string NazivModel
        {
            get { return _nazivModel; }
            set { SetProperty(ref _nazivModel, value); }
        }
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
        string _model = string.Empty;
        public string Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }
        string _godiste = string.Empty;
        public string Godiste
        {
            get { return _godiste; }
            set { SetProperty(ref _godiste, value); }
        }
        string _brojReg = string.Empty;
        public string BrojRegOznaka
        {
            get { return _brojReg; }
            set { SetProperty(ref _brojReg, value); }
        }

        DateTime _datumIsteka = DateTime.MaxValue;
        public DateTime DatumIstekaRegistracije
        {
            get { return _datumIsteka; }
            set { SetProperty(ref _datumIsteka, value); }
        }
        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand UrediCommand { get; set; }
        public ICommand UkloniCommand { get; set; }

        public async Task Ukloni()
        {
            try
            {
                await _automobilService.Delete<Automobil>(AutomobilID);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješno brisanje", "OK");

                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {

            }
        }
        public async Task Init(int automobilId)
        {
            try
            {
                var auto = await _automobilService.GetById<Automobil>(automobilId);
                Slika = auto.Slika;
                Naziv = auto.Naziv;
                Model = auto.Model;
                BrojRegOznaka = auto.BrojRegOznaka;
                Godiste = auto.Godiste;
                DatumIstekaRegistracije = auto.DatumIstekaRegistracije;
                NazivModel = auto.Naziv + " " + auto.Model;
                AutomobilID = automobilId;
            }
            catch (Exception)
            {

            }

        }
    }
}

using Carpool.Model.Requests;
using eProdaja.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class AddAutomobilViewModel : BaseViewModel
    {
        private readonly APIService _automobilService = new APIService("Automobil");

        public AddAutomobilViewModel()
        {
            SaveCommand = new Command(async () => await Save());
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

        public byte[] _slikaThumb = null;
        public byte[] SlikaThumb
        {
            get { return _slikaThumb; }
            set { SetProperty(ref _slikaThumb, value); }
        }
        public ICommand SaveCommand { get; set; }

        async Task Save()
        {
            var model = new AutomobilInsertRequest
            {
                BrojRegOznaka = BrojRegOznaka,
                DatumIstekaRegistracije = DatumIstekaRegistracije,
                Godiste = Godiste,
                Model = Model,
                Naziv = Naziv,
                Slika=Slika,
                SlikaThumb=SlikaThumb
            };

            try
            {
                await _automobilService.Insert<dynamic>(model);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješno dodavanje", "OK");
                Application.Current.MainPage = new AutomobiliPage();
            }
            catch (Exception)
            {

            }
        }
    }
}

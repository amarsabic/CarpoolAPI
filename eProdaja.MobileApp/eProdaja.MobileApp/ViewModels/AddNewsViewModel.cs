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
    public class AddNewsViewModel : BaseViewModel
    {
        private readonly APIService _obavijestiService = new APIService("Obavijesti");
        private readonly APIService _tipObavijestiService = new APIService("TipObavijesti");

        public AddNewsViewModel()
        {
            SaveCommand = new Command(async() => await Save());
            LoadCommand = new Command(async() => await LoadTipovi());
            InitCommand = new Command(async() => await Init());
        }

        string _naslov = string.Empty;
        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }
        string _kratkiOpis = string.Empty;
        public string KratkiOpis
        {
            get { return _kratkiOpis; }
            set { SetProperty(ref _kratkiOpis, value); }
        }

        ObservableCollection<TipObavijesti> _tipovi = new ObservableCollection<TipObavijesti>();
        public ObservableCollection<TipObavijesti> TipObavijesti
        {
            get { return _tipovi; }
            set { SetProperty(ref _tipovi, value); }
        }

        private TipObavijesti _selectedTip;
        public TipObavijesti SelectedTip
        {
            get { return _selectedTip; }
            set { SetProperty(ref _selectedTip, value); }
        }

        DateTime _datum = DateTime.MaxValue;
        public DateTime DatumVrijemeObajve
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand InitCommand { get; set; }

        async Task Init()
        {
            try
            {
                await _obavijestiService.Insert<dynamic>(request);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješno objavljeno", "OK");
                Application.Current.MainPage = new NewsPage();
            }
            catch (Exception)
            {

            }
        }

        async Task Save()
        {

            var request = new ObavijestiUpsertRequest
            {
                Naslov=Naslov,
                KratkiOpis=KratkiOpis,
                DatumVrijemeObjave=DatumVrijemeObajve,
                TipObavijestiID=SelectedTip.TipObavijestiID
            };

            try
            {
                await _obavijestiService.Insert<dynamic>(request);
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješno objavljeno", "OK");
                Application.Current.MainPage = new NewsPage();
            }
            catch (Exception)
            {

            }
        }
        public async Task LoadTipovi()
        {
            var result = await _tipObavijestiService.Get<List<TipObavijesti>>(null);
       
                _tipovi.Clear();
                foreach (var tip in result)
                {
                    _tipovi.Add(tip);
                }
        }
    }
}

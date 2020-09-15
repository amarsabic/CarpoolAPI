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
            SaveCommand = new Command(async () => await Save());
            LoadCommand = new Command(async () => await LoadTipovi());
            InitCommand = new Command(async (param) => await Init((int)param));
            DeleteCommand = new Command(async () => await Ukloni());
        }

        int? obavijestID;
        int vozacID;

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

        DateTime _datum;
        public DateTime DatumVrijemeObjave
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public async Task Ukloni()
        {
            try
            {
                await _obavijestiService.Delete<Obavijesti>((int)obavijestID);

                await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno uklonjena obavijest", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {

            }
        }

        public async Task Init(int ObavijestiID)
        {
            try
            {
                var o = await _obavijestiService.GetById<Obavijesti>(ObavijestiID);

                Naslov = o.Naslov;
                KratkiOpis = o.KratkiOpis;
                foreach (var tip in _tipovi)
                {
                    if (tip.TipObavijestiID == o.TipObavijestiID)
                    {
                        SelectedTip = tip;
                    }
                }
                DatumVrijemeObjave = o.DatumVrijemeObjave;
                obavijestID = ObavijestiID;
                vozacID = o.KorisnikID;
            }
            catch (Exception err)
            {

            }
        }

        public bool Validate()
        {

            if (string.IsNullOrWhiteSpace(Naslov) || string.IsNullOrWhiteSpace(KratkiOpis))
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Popunite sva polja!", "OK");
                return false;
            }
            else if (Naslov.Length < 5 || Naslov.Length > 30)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Naslov mora sadržavati 5-30 karaktera", "OK");
                return false;
            }
            else if (KratkiOpis.Length < 30 || KratkiOpis.Length > 500)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Sadržaj mora sadržavati 30-500 karaktera", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }


        async Task Save()
        {
            if (Validate())
            {
                var request = new ObavijestiUpsertRequest
                {
                    Naslov = Naslov,
                    KratkiOpis = KratkiOpis,
                    DatumVrijemeObjave = DatumVrijemeObjave,
                    TipObavijestiID = SelectedTip.TipObavijestiID,
                    VozacID = vozacID
                };

                if (obavijestID != null)
                {
                    try
                    {
                        await _obavijestiService.Update<Obavijesti>(obavijestID, request);
                        await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješna izmjena", "OK");

                        await Application.Current.MainPage.Navigation.PopAsync();
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    try
                    {
                        await _obavijestiService.Insert<dynamic>(request);
                        await Application.Current.MainPage.DisplayAlert("OK", "Uspješno objavljeno", "OK");
                        await Application.Current.MainPage.Navigation.PopAsync();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        public async Task LoadTipovi()
        {
            var result = await _tipObavijestiService.Get<List<TipObavijesti>>(null);

            _tipovi.Clear();
            foreach (var tip in result)
            {
                _tipovi.Add(tip);
                SelectedTip = tip;
            }
        }
    }
}

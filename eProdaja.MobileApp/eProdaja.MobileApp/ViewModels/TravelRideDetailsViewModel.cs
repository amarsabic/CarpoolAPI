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
    public class TravelRideDetailsViewModel : BaseViewModel
    {
        private readonly APIService _automobili = new APIService("Automobil");
        private readonly APIService _voznja = new APIService("Voznja");
        private readonly APIService _rezervacija = new APIService("Rezervacija");
        private readonly APIService _tipOcjene = new APIService("TipOcjene");
        private readonly APIService _ocjena = new APIService("Ocjena");
        public TravelRideDetailsViewModel()
        {
            InitCommand = new Command(async (param) => await Init((int)param));
            UkloniCommand = new Command(async () => await Ukloni());
            LoadCommand = new Command(async () => await LoadTipovi());
            OcjenaCommand = new Command(async () => await Ocjena());
            LoadOcjenaCommand = new Command(async () => await LoadOcjena());
        }

        ObservableCollection<Grad> _UsputniGradovi = new ObservableCollection<Grad>();

        public int rezervacijaID;
        public int ocjenaID;

        ObservableCollection<TipOcjene> _tipovi = new ObservableCollection<TipOcjene>();
        public ObservableCollection<TipOcjene> TipOcjene
        {
            get { return _tipovi; }
            set { SetProperty(ref _tipovi, value); }
        }
        public string _komentar = null;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }

        public bool _provjeraOcjene = false;
        public bool ProvjeraOcjene
        {
            get { return _provjeraOcjene; }
            set { SetProperty(ref _provjeraOcjene, value); }
        }

        private TipOcjene _selectedTip;
        public TipOcjene SelectedTip
        {
            get { return _selectedTip; }
            set { SetProperty(ref _selectedTip, value); }
        }

        public bool _ukloniVisible;
        public bool UkloniVisible
        {
            get { return _ukloniVisible; }
            set { SetProperty(ref _ukloniVisible, value); }
        }

        public bool _ocjenaVisible;
        public bool OcjenaVisible
        {
            get { return _ocjenaVisible; }
            set { SetProperty(ref _ocjenaVisible, value); }
        }

        public ObservableCollection<Grad> UsputniGradovi
        {
            get { return _UsputniGradovi; }
            set { SetProperty(ref _UsputniGradovi, value); }
        }

        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        public string _korisnickoIme = null;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        public string _gradPolaska = null;
        public string GradPolaska
        {
            get { return _gradPolaska; }
            set { SetProperty(ref _gradPolaska, value); }
        }
        public string _gradDestinacija = null;
        public string GradDestinacija
        {
            get { return _gradDestinacija; }
            set { SetProperty(ref _gradDestinacija, value); }
        }
        public string _punaCijenaPrikaz = null;
        public string PunaCijenaPrikaz
        {
            get { return _punaCijenaPrikaz; }
            set { SetProperty(ref _punaCijenaPrikaz, value); }
        }
        public int _slobodnaMjesta;
        public int SlobodnaMjesta
        {
            get { return _slobodnaMjesta; }
            set { SetProperty(ref _slobodnaMjesta, value); }
        }

        public decimal _punaCijena;
        public decimal PunaCijena
        {
            get { return _punaCijena; }
            set { SetProperty(ref _punaCijena, value); }
        }

        public string _datumPolaska;
        public string DatumPolaska
        {
            get { return _datumPolaska; }
            set { SetProperty(ref _datumPolaska, value); }
        }
        public string _datumObjave;
        public string DatumObjave
        {
            get { return _datumObjave; }
            set { SetProperty(ref _datumObjave, value); }
        }
        public string _vrijemePolaska;
        public string VrijemePolaska
        {
            get { return _vrijemePolaska; }
            set { SetProperty(ref _vrijemePolaska, value); }
        }
        public ICommand InitCommand { get; set; }
        public ICommand UkloniCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand OcjenaCommand { get; set; }
        public ICommand LoadOcjenaCommand { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Komentar))
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Popunite sva polja!", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }


        public async Task LoadOcjena()
        {
            var r = await _rezervacija.GetById<Rezervacija>(rezervacijaID);
            var v = await _voznja.GetById<Voznja>(r.VoznjaID);

            var o = await _ocjena.GetByKorisnik<Ocjene>(APIService.UserID, v.VoznjaID);
            if (o != null)
            {
                _provjeraOcjene = true;
                ocjenaID = o.OcjeneID;
                Komentar = o.Komentar;

                foreach (var tip in _tipovi)
                {
                    if (tip.TipOcjeneID == o.TipOcjeneID)
                        SelectedTip = tip;
                }
            }
        }

        private async Task Ocjena()
        {
            if (Validate())
            {
                var r = await _rezervacija.GetById<Rezervacija>(rezervacijaID);

                var v = await _voznja.GetById<Voznja>(r.VoznjaID);

                OcjenaUpsertRequest req = new OcjenaUpsertRequest
                {
                    Komentar = Komentar,
                    KorisnikID = APIService.UserID,
                    TipOcjeneID = SelectedTip.TipOcjeneID,
                    VoznjaID = v.VoznjaID
                };

                try
                {
                    if (!_provjeraOcjene)
                    {
                        var o = await _ocjena.Insert<Ocjene>(req);
                        if (o != null)
                        {
                            await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno ste ocijenili vožnju", "OK");
                            await Application.Current.MainPage.Navigation.PopAsync();
                        }
                    }
                    else
                    {
                        var o = await _ocjena.Update<Ocjene>(ocjenaID, req);
                        if (o != null)
                        {
                            await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno ste promijenili ocjenu", "OK");
                            await Application.Current.MainPage.Navigation.PopAsync();
                        }
                    }
                }
                catch (Exception)
                {

                }
            }

        }

        public async Task LoadTipovi()
        {
            var result = await _tipOcjene.Get<List<TipOcjene>>(null);

            _tipovi.Clear();
            foreach (var tip in result)
            {
                _tipovi.Add(tip);
                SelectedTip = tip;
            }
        }

        public async Task Ukloni()
        {
            try
            {
                await _rezervacija.Delete<Rezervacija>(rezervacijaID);
                await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno uklonjena rezervacija", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {

            }
        }

        public async Task Init(int rezervacijaId)
        {
            try
            {
                var r = await _rezervacija.GetById<Rezervacija>(rezervacijaId);

                var v = await _voznja.GetById<Voznja>(r.VoznjaID);

                var auto = await _automobili.GetById<Automobil>(v.AutomobilID);
                Slika = auto.Slika;

                KorisnickoIme = v.KorisnickoIme;
                GradPolaska = v.GradPolaska;
                GradDestinacija = v.GradDestinacija;
                SlobodnaMjesta = v.SlobodnaMjesta;
                PunaCijena = v.PunaCijena;
                DatumPolaska = v.DatumPolaska.ToShortDateString();
                VrijemePolaska = v.VrijemePolaska;
                PunaCijenaPrikaz = v.PunaCijenaPrikaz;
                DatumObjave = v.DatumObjave.ToShortDateString();

                rezervacijaID = rezervacijaId;
                foreach (var item in v.UsputniGradoviGrad)
                {
                    UsputniGradovi.Add(item);
                }

                UkloniVisible = v.IsAktivna;
                OcjenaVisible = !v.IsAktivna;

            }
            catch (Exception)
            {

            }
        }

    }
}

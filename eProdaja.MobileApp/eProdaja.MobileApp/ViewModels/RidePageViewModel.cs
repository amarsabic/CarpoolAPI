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
    public class RidePageViewModel : BaseViewModel
    {
        private readonly APIService _voznja = new APIService("Voznja");
        private readonly APIService _korisnik = new APIService("Korisnik");
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _automobil = new APIService("Automobil");
        public RidePageViewModel()
        {
            LoadCommand = new Command(async () => await Load());
            LoadGradoviCommand = new Command(async () => await LoadGradovi());
            DodajCommand = new Command(async () => await Dodaj());
            MojeVoznjeCommand = new Command(async () => await MojeVoznje());
            PrikaziSveCommand = new Command(async () => await Load());
            Last5Command = new Command(async () => await Last5());
            SearchRideCommand = new Command(async () => await SearchRide());
            ZavrseneCommand = new Command(async () => await Zavrsene());
            SveCommand = new Command(async () => await Sve());
            RecommendedCommand = new Command(async () => await Recommended());

        }

        public ObservableCollection<Voznja> VoznjeList { get; set; } = new ObservableCollection<Voznja>();
        public ObservableCollection<Voznja> PreporuceneList { get; set; } = new ObservableCollection<Voznja>();
        public ObservableCollection<Voznja> SearchList { get; set; } = new ObservableCollection<Voznja>();
        public ObservableCollection<Grad> _Gradovi = new ObservableCollection<Grad>();

        public ObservableCollection<Grad> Gradovi
        {
            get { return _Gradovi; }
            set { SetProperty(ref _Gradovi, value); }
        }

        public bool _searchListBool = false;
        public bool SearchListBool
        {
            get { return _searchListBool; }
            set { SetProperty(ref _searchListBool, value); }
        }

        DateTime _minimumDate = DateTime.Now;
        public DateTime MinimumDate
        {
            get { return _minimumDate; }
            set { SetProperty(ref _minimumDate, value); }
        }
        DateTime _datumPolaska;
        public DateTime DatumPolaskaProvjera
        {
            get { return _datumPolaska; }
            set { SetProperty(ref _datumPolaska, value); }
        }
        bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }

        public bool _mojeVoznjeBool = false;
        public bool MojeVoznjeBool
        {
            get { return _mojeVoznjeBool; }
            set { SetProperty(ref _mojeVoznjeBool, value); }
        } 
        
        public bool _sveVoznje = false;
        public bool SveVoznjeBool
        {
            get { return _sveVoznje; }
            set { SetProperty(ref _sveVoznje, value); }
        }

        public bool _zavrseneVoznje = false;
        public bool ZavrseneVoznje
        {
            get { return _zavrseneVoznje; }
            set { SetProperty(ref _zavrseneVoznje, value); }
        }
    
        private Grad _selectedGradPolaska;
        public Grad SelectedPolazak
        {
            get { return _selectedGradPolaska; }
            set { SetProperty(ref _selectedGradPolaska, value); }
        }

        private Grad _selectedGradOdrediste;
        public Grad SelectedOdrediste
        {
            get { return _selectedGradOdrediste; }
            set { SetProperty(ref _selectedGradOdrediste, value); }
        }


        public ICommand LoadCommand { get; set; }
        public ICommand RecommendedCommand { get; set; }
        public ICommand LoadGradoviCommand { get; set; }
        public ICommand DodajCommand { get; set; }
        public ICommand MojeVoznjeCommand { get; set; }
        public ICommand PrikaziSveCommand { get; set; }
        public ICommand Last5Command { get; set; }
        public ICommand SearchRideCommand { get; set; }
        public ICommand ZavrseneCommand { get; set; }
        public ICommand SveCommand { get; set; }

        public async Task Zavrsene()
        {
            try
            {
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                    IsZavrsena=true
                };

                var model = await _voznja.Get<List<Voznja>>(search);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate završenih vožnji", "OK");
                    return;
                }
                ZavrseneVoznje = true;
                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }
            }
            catch (Exception)
            {

            }
        }
        public async Task SearchRide()
        {
            try
            {
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                    SearchFromHomePage = true,
                    GradDestinacijaID=SelectedOdrediste.GradID,
                    GradPolaskaID=SelectedPolazak.GradID,
                    DatumPolaska= DatumPolaskaProvjera
                };

                var model = await _voznja.Get<List<Voznja>>(search);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nema traženih rezultata", "OK");
                    SearchListBool = false;
                    return;
                }    
                

                SearchList.Clear();
                foreach (var voznja in model)
                {
                    SearchList.Add(voznja);
                }
                SearchListBool = true;
            }
            catch (Exception)
            {

            }
        }

        public async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Grad>>(null);

            _Gradovi.Clear();
            foreach (var grad in result)
            {
                _Gradovi.Add(grad);
            }
        }

        public async Task Last5()
        {
            try
            {
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                    PosljednjeVoznje = true,
                    IsSlobodnaMjesta = true
                };

                var model = await _voznja.Get<List<Voznja>>(search);

            
                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }
            }
            catch (Exception)
            {

            }
        }
        public async Task MojeVoznje()
        {
            try
            {
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                    IsVozac = APIService.IsVozac
                };

                var model = await _voznja.Get<List<Voznja>>(search);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate aktivnih vožnji", "OK");
                }
                MojeVoznjeBool = true;
                SveVoznjeBool = false;

                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }  
            }
            catch (Exception)
            {

            }
        }
        public async Task Dodaj()
        {
            AutomobilSearchRequest search = new AutomobilSearchRequest
            {
                IsVozac = true,
                ProvjeraAktivnosti = true
            };
            var auto = await _automobil.Get<List<Automobil>>(search);
            if (auto.Count != 0)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AddRidePage(null));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate dodane automobile", "OK");
                await Application.Current.MainPage.Navigation.PushAsync(new AddAutomobilPage(null));
            }
        }
        public async Task Sve()
        {
            try
            {
                VoznjaSearchRequest req = new VoznjaSearchRequest
                {
                    IsSlobodnaMjesta = true
                };
                var model = await _voznja.Get<List<Voznja>>(req);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nema aktivnih vožnji", "OK");
                }
                MojeVoznjeBool = false;
                SveVoznjeBool = true;

                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }
            }
            catch (Exception)
            {

            }
        }
        public async Task Load()
        {
            try
            {
                VoznjaSearchRequest req = new VoznjaSearchRequest
                {
                    IsSlobodnaMjesta = true
                };
                var model = await _voznja.Get<List<Voznja>>(req);

                if (model.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nema aktivnih vožnji", "OK");
                }
                MojeVoznjeBool = false;

                IsVisible = APIService.IsVozac;

                VoznjeList.Clear();
                foreach (var voznja in model)
                {
                    VoznjeList.Add(voznja);
                }
            }
            catch (Exception)
            {

            }
        }

        public async Task Recommended()
        {
            try
            {
                var recommended = await _voznja.Recommend<List<Voznja>>();
                PreporuceneList.Clear();
                foreach (var item in recommended)
                {
                    PreporuceneList.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

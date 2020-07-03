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
    public class AddRideViewModel:BaseViewModel
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _automobili = new APIService("Automobil");
        private readonly APIService _voznja = new APIService("Voznja");
        public AddRideViewModel()
        {
            LoadCommand = new Command(async () => await LoadGradovi());
            LoadAutomobiliCommand = new Command(async () => await LoadAutomobili());
            DeleteUsputniCommand = new Command(async (param) => await DeleteUsputni((int)param));
            SaveRideCommand = new Command(async () => await SaveRide());
        }

        ObservableCollection<Grad> _Gradovi = new ObservableCollection<Grad>();
        ObservableCollection<Grad> _SelectedGradovi = new ObservableCollection<Grad>();
        ObservableCollection<Grad> _UsputniGradovi = new ObservableCollection<Grad>();
        ObservableCollection<Automobil> _Automobili = new ObservableCollection<Automobil>();

        int _slobodnaMjesta;
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

        DateTime _minimumDate = DateTime.Now;
        public DateTime MinimumDate
        {
            get { return _minimumDate; }
            set { SetProperty(ref _minimumDate, value); }
        }

        DateTime _datumPolaska;
        public DateTime DatumPolaska
        {
            get { return _datumPolaska; }
            set { SetProperty(ref _datumPolaska, value); }
        }
        DateTime _vrijemePolaska;
        public DateTime VrijemePolaska
        {
            get { return _vrijemePolaska; }
            set { SetProperty(ref _vrijemePolaska, value); }
        }

        bool _checkListBool = false;
        public bool CheckListBool
        {
            get { return _checkListBool; }
            set { SetProperty(ref _checkListBool, value); }
        }
        public ObservableCollection<Grad> Gradovi
        {
            get { return _Gradovi; }
            set { SetProperty(ref _Gradovi, value); }
        }
        public ObservableCollection<Grad> UsputniGradovi
        {
            get { return _UsputniGradovi; }
            set { SetProperty(ref _UsputniGradovi, value); }
        }
        public ObservableCollection<Grad> SelectedGradovi
        {
            get { return _SelectedGradovi; }
            set { SetProperty(ref _SelectedGradovi, value);}
        }
        private Grad _selectedUsputni;
        public Grad SelectedUsputni
        {
            get { return _selectedUsputni; }
            set { SetProperty(ref _selectedUsputni, value);
                foreach (var selektirani in SelectedGradovi)
                {
                    if(selektirani == SelectedUsputni)
                    {
                       Application.Current.MainPage.DisplayAlert("Carpool", "Grad je već dodan!", "OK");
                       return;
                    }
                }
                _SelectedGradovi.Add(SelectedUsputni);
                if (SelectedGradovi.Count != 0)
                    CheckListBool=true;
            }
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
        public ObservableCollection<Automobil> Automobili
        {
            get { return _Automobili; }
            set { SetProperty(ref _Automobili, value); }
        }

        private Automobil _selectedAutomobil;
        public Automobil SelectedAutomobil
        {
            get { return _selectedAutomobil; }
            set { SetProperty(ref _selectedAutomobil, value); }
        }

        public ICommand LoadCommand { get; set; }
        public ICommand LoadAutomobiliCommand { get; set; }
        public ICommand DeleteUsputniCommand { get; set; }
        public ICommand SaveRideCommand { get; set; }

        public async Task SaveRide()
        {
            VoznjaUpsertRequest voznja = new VoznjaUpsertRequest
            {
                AutomobilID=SelectedAutomobil.AutomobilID,
                DatumObjave=DateTime.Now,
                DatumPolaska=DatumPolaska,
                GradDestinacijaID=SelectedOdrediste.GradID,
                GradPolaskaID=SelectedPolazak.GradID,
                IsAktivna=true,
                VrijemePolaska=VrijemePolaska,
                PunaCijena=PunaCijena,
                SlobodnaMjesta=SlobodnaMjesta       
            };

            foreach (var selektirani in SelectedGradovi)
            {
                voznja.UsputniGradovi.Add(new Grad { 
                    GradID=selektirani.GradID,
                    Naziv=selektirani.Naziv
                });
            }

            try
            {
                await _voznja.Insert<Voznja>(voznja);
                await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno objavljena vožnja", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new RouteCitiesModalPage());
            }
            catch (Exception)
            {
            }
        }
        public async Task DeleteUsputni(int gradId)
        {
            foreach (var selektirani in SelectedGradovi)
            {
                if (selektirani.GradID == gradId)
                {
                    _SelectedGradovi.Remove(selektirani);
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno obrisan grad", "OK");
                    if (SelectedGradovi.Count == 0)
                        CheckListBool = false;
                    return;
                }
            }
        }

        public async Task LoadAutomobili()
        {
            var searchByVozac = new AutomobilSearchRequest
            {
                IsVozac = true
            };
            var list = await _automobili.Get<List<Automobil>>(searchByVozac);

            //exception nema automobil
            if (list.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate dodane automobile", "OK");
                //pop async kad se napravi page 
            }

            _Automobili.Clear();
            foreach (var automobil in list)
            {
                _Automobili.Add(automobil);
            }
        }
        public async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Grad>>(null);

            _Gradovi.Clear();
            foreach (var grad in result)
            {
                _Gradovi.Add(grad);
                _UsputniGradovi.Add(grad);
            }
        }
    }
}


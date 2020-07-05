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
            InitCommand = new Command(async (param) => await Init((int)param));
            DeleteRideCommand = new Command(async () => await DeleteRide());
        }

        ObservableCollection<Grad> _Gradovi = new ObservableCollection<Grad>();
        ObservableCollection<Grad> _SelectedGradovi = new ObservableCollection<Grad>();
        ObservableCollection<Grad> _UsputniGradovi = new ObservableCollection<Grad>();
        ObservableCollection<Automobil> _Automobili = new ObservableCollection<Automobil>();

        int _slobodnaMjesta;
        int? voznjaID;

        public bool _IsVisibleUkloni = false;
        public bool IsVisibleUkloni
        {
            get { return _IsVisibleUkloni; }
            set { SetProperty(ref _IsVisibleUkloni, value); }
        }
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
        public ICommand InitCommand { get; set; }
        public ICommand DeleteRideCommand { get; set; }

        public async Task DeleteRide()
        {
            try
            {
                await _voznja.Delete<Voznja>((int)voznjaID);
                await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno obrisana vožnja", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception)
            {
            }
        }
        public async Task Init(int voznjaId)
        {
            try
            {
                var v = await _voznja.GetById<Voznja>(voznjaId);
                foreach (var polaziste in _Gradovi)
                {
                    if (polaziste.GradID == v.GradPolaskaID)
                    {
                        SelectedPolazak = polaziste;
                    }
                }
                foreach (var odrediste in _Gradovi)
                {
                    if (odrediste.GradID == v.GradDestinacijaID)
                    {
                        SelectedOdrediste = odrediste;
                    }
                }
        
                foreach (var usputni in v.UsputniGradoviE)
                {
                    SelectedGradovi.Add(new Grad
                    {
                        GradID=usputni.GradID,
                        Naziv=usputni.Grad.Naziv
                    });
                   CheckListBool = true;
                }

                SlobodnaMjesta = v.SlobodnaMjesta;
                PunaCijena = v.PunaCijena;
                DatumPolaska = v.DatumPolaska;
                VrijemePolaska = v.VrijemePolaska;
                foreach (var auto in Automobili)
                {
                    if(auto.AutomobilID == v.AutomobilID)
                    {
                        SelectedAutomobil = auto;
                    }
                }

                voznjaID = voznjaId;
                _IsVisibleUkloni = true;
            }
            catch (Exception)
            {

                throw;
            }
        }


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
                voznja.UsputniGradoviGrad.Add(new Grad { 
                    GradID=selektirani.GradID,
                    Naziv=selektirani.Naziv
                });
            }

            if (voznjaID == null)
            {
                try
                {
                    await _voznja.Insert<Voznja>(voznja);
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno objavljena vožnja", "OK");
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                catch (Exception er)
                {
                }
            }
            else
            {
                try
                {
                    await _voznja.Update<Voznja>(voznjaID, voznja);
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Uspješno promijenjeni podaci", "OK");
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                catch (Exception)
                {
                }
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
            if (voznjaID == null)
            {
                searchByVozac.ProvjeraAktivnosti = true;
            }
            else
            {
                searchByVozac.ProvjeraAktivnosti = false;
            }
            var list = await _automobili.Get<List<Automobil>>(searchByVozac);

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


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
    public class AddRouteCitiesViewModel:BaseViewModel
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _voznja = new APIService("Voznja");
        private readonly APIService _usputni = new APIService("UsputniGradovi");

        private readonly int novaVoznjaId;
        public AddRouteCitiesViewModel(int novaVoznjaID)
        {
            DeleteUsputniCommand = new Command(async (param) => await DeleteUsputni((int)param));
            LoadUsputniCommand = new Command(async () => await LoadUsputni());
            SaveCitiesCommand = new Command(async () => await SaveCities());

            novaVoznjaId = novaVoznjaID;
        }

        ObservableCollection<Grad> _SelectedGradovi = new ObservableCollection<Grad>();
        ObservableCollection<Grad> _UsputniGradovi = new ObservableCollection<Grad>();

        bool _checkListBool = false;
        public bool CheckListBool
        {
            get { return _checkListBool; }
            set { SetProperty(ref _checkListBool, value); }
        }

        public ObservableCollection<Grad> UsputniGradovi
        {
            get { return _UsputniGradovi; }
            set { SetProperty(ref _UsputniGradovi, value); }
        }
        public ObservableCollection<Grad> SelectedGradovi
        {
            get { return _SelectedGradovi; }
            set { SetProperty(ref _SelectedGradovi, value); }
        }
        private Grad _selectedUsputni;
        public Grad SelectedUsputni
        {
            get { return _selectedUsputni; }
            set
            {
                SetProperty(ref _selectedUsputni, value);
                foreach (var selektirani in SelectedGradovi)
                {
                    if (selektirani == SelectedUsputni)
                    {
                        Application.Current.MainPage.DisplayAlert("Carpool", "Grad je već dodan!", "OK");
                        return;
                    }
                }
                _SelectedGradovi.Add(SelectedUsputni);
                if (SelectedGradovi.Count != 0)
                    CheckListBool = true;
            }
        }

        public ICommand DeleteUsputniCommand { get; set; }
        public ICommand LoadUsputniCommand { get; set; }
        public ICommand SaveCitiesCommand { get; set; }

        public async Task SaveCities()
        {
            UsputniGradoviUpsertRequest request = new UsputniGradoviUpsertRequest
            {
                VoznjaID=novaVoznjaId,
                
                
            };
            await _usputni.Insert<UsputniGradovi>(null);
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
        public async Task LoadUsputni()
        {
            var result = await _gradovi.Get<List<Grad>>(null);

            _UsputniGradovi.Clear();
            foreach (var grad in result)
            {
                _UsputniGradovi.Add(grad);
            }
        }
    }
}

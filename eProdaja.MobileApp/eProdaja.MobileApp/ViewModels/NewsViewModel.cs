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
    public class NewsViewModel : BaseViewModel
    {
        private readonly APIService _obavijesti = new APIService("Obavijesti");
        private readonly APIService _tipObavijesti = new APIService("TipObavijesti");
        public NewsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Obavijesti> ObavijestiList { get; set; } = new ObservableCollection<Obavijesti>();
        public ObservableCollection<TipObavijesti> TipObavijestiList { get; set; } = new ObservableCollection<TipObavijesti>();

        TipObavijesti _selectedTipObavijesti = null;
        public TipObavijesti SelectedTipObavijesti
        {
            get { return _selectedTipObavijesti; }
            set
            {
                SetProperty(ref _selectedTipObavijesti, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            ObavijestiSearchRequest search = new ObavijestiSearchRequest();

            search.IsKorisnik = true;

            if (TipObavijestiList.Count == 0)
            {
                var tipovi = await _tipObavijesti.Get<List<TipObavijesti>>(null);
                foreach (var tip in tipovi)
                {
                    TipObavijestiList.Add(tip);
                }
            }

            if (_selectedTipObavijesti != null)
            {
                search.TipObavijestiID = SelectedTipObavijesti.TipObavijestiID;

                var listSelected = await _obavijesti.Get<List<Obavijesti>>(search);


                if (listSelected.Count == 0)
                {
                    var nazivTipa = SelectedTipObavijesti.NazivTipa;
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate obavijesti tipa " + nazivTipa, "OK");
                }

                ObavijestiList.Clear();
                foreach (var obavijest in listSelected)
                {
                    ObavijestiList.Add(obavijest);
                }
            }
            else
            {
                var list = await _obavijesti.Get<List<Obavijesti>>(search);

                if (list.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Carpool", "Trenutno nemate dodane obavijesti", "OK");
                }

                ObavijestiList.Clear();
                foreach (var obavijest in list)
                {
                    ObavijestiList.Add(obavijest);
                }
            }
        }
    }
}

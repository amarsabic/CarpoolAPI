﻿using Carpool.Model;
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
    public class NewsViewModel : BaseViewModel
    {
        private readonly APIService _obavijesti = new APIService("Obavijesti");
        private readonly APIService _tipObavijesti = new APIService("TipObavijesti");
        public NewsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            DodajCommand = new Command(async () => await Dodaj());
            MojeObavijestiCommand = new Command(async () => await MojeObavijesti());
            PrikaziSveCommand = new Command(async () => await PrikaziSve());
        }
        public ObservableCollection<Obavijesti> ObavijestiList { get; set; } = new ObservableCollection<Obavijesti>();
        public ObservableCollection<TipObavijesti> TipObavijestiList { get; set; } = new ObservableCollection<TipObavijesti>();

        public bool _mojeObavijestiBool = false;
        public bool MojeObavijestiBool
        {
            get { return _mojeObavijestiBool; }
            set { SetProperty(ref _mojeObavijestiBool, value); }
        }

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
        public ICommand DodajCommand { get; set; }
        public ICommand MojeObavijestiCommand { get; set; }
        public ICommand PrikaziSveCommand { get; set; }

        public async Task PrikaziSve()
        {
            ObavijestiSearchRequest search = new ObavijestiSearchRequest();

            var list = await _obavijesti.Get<List<Obavijesti>>(search);

            ObavijestiList.Clear();
            foreach (var obavijest in list)
            {
                ObavijestiList.Add(obavijest);
            }
            MojeObavijestiBool = false;
        }

        public async Task MojeObavijesti()
        {
            ObavijestiSearchRequest search = new ObavijestiSearchRequest();

            search.IsKorisnik = true;

            var list = await _obavijesti.Get<List<Obavijesti>>(search);

            ObavijestiList.Clear();
            foreach (var obavijest in list)
            {
                ObavijestiList.Add(obavijest);
            }
            MojeObavijestiBool = true;
        }

        public async Task Dodaj()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AddNewsPage(null));
        }

        public async Task Init()
        {
            ObavijestiSearchRequest search = new ObavijestiSearchRequest();

            //search.IsKorisnik = true;

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
                MojeObavijestiBool = false;
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
                MojeObavijestiBool = false;
            }
        }
    }
}

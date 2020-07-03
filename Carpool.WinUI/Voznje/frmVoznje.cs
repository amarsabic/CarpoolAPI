﻿using Carpool.Model.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI.Voznje
{
    public partial class frmVoznje : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _automobiliDVA = new APIService("Automobil");
        private readonly APIService _voznje = new APIService("Voznja");

        public frmVoznje()
        {
            InitializeComponent();
        }

        private async void frmVoznje_Load(object sender, EventArgs e)
        {
            dtmVrijeme.Format = DateTimePickerFormat.Custom;
            dtmVrijeme.CustomFormat = "HH:mm";
            dtmVrijeme.ShowUpDown = true;

            await LoadPolazak();
            await LoadDestinacija();
            await LoadAutomobili();
        }

        private async Task LoadPolazak()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());

            cmbPolazak.DataSource = result;
          
            cmbPolazak.DisplayMember = "Naziv";
            cmbPolazak.ValueMember = "GradID";
        }
        private async Task LoadDestinacija()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());

            cmbDestinacija.DataSource = result;

            cmbDestinacija.DisplayMember = "Naziv";
            cmbDestinacija.ValueMember = "GradID";
        }

        public class AutomobilCombo
        {
            public int AutomobilID { get; set; }
            public string Naziv { get; set; }
            public string Model { get; set; }

            public string NazivModel
            {
                get
                {
                    return Naziv + " " + Model;
                }
            }
        }

        private async Task LoadAutomobili()
        {
            var result = await _automobiliDVA.Get<List<AutomobilCombo>>(null);
            result.Insert(0, new AutomobilCombo());

            cmbAutomobil.DataSource = result;

            cmbAutomobil.DisplayMember = "NazivModel";
            cmbAutomobil.ValueMember = "AutomobilID";
        }

        private async void cmbPolazak_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbPolazak.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVoznje(id);
            }
        }

        private async Task LoadVoznje(int polazakId)
        {
            var result = await _voznje.Get<List<Model.Voznja>>(new VoznjaSearchRequest
            {
                GradPolaskaID = polazakId
            });

            dgvVoznje.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            VoznjaUpsertRequest request = new VoznjaUpsertRequest();

            var idPolazak = cmbPolazak.SelectedValue;

            if (int.TryParse(idPolazak.ToString(), out int polazakId))
            {
                request.GradPolaskaID = polazakId;
            }

            var idDestinacija = cmbDestinacija.SelectedValue;

            if (int.TryParse(idDestinacija.ToString(), out int destinacijaId))
            {
                request.GradDestinacijaID = destinacijaId;
            }

            var idAutomobil = cmbAutomobil.SelectedValue;

            if (int.TryParse(idAutomobil.ToString(), out int automobilId))
            {
                request.AutomobilID = automobilId;
            }

            request.DatumObjave = DateTime.Now;
            request.DatumPolaska = dtmPolazak.Value;
            request.VrijemePolaska = dtmVrijeme.Value;
            request.IsAktivna = true;
            //request.VozacID = 15; //promijeniti na ID vozaca koji kreira voznju
            request.PunaCijena = int.Parse(txtCijena.Text);
            request.SlobodnaMjesta = int.Parse(txtMjesta.Text);

           await _voznje.Insert<Model.Automobil>(request);

            MessageBox.Show("Uspješno dodavanje");
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            LoadJson();
        }
        public async void LoadJson()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\Amar Sabic\\Desktop\\cities.json-master\\cities.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                List<Model.Grad> gradovi = items.Where(x => x.country == "BA").Select(x=>new Model.Grad { 
                    Naziv=x.name
                }).ToList();

                foreach (var item in gradovi)
                {
                    await _gradovi.Insert<Model.Grad>(item);
                }
            }
        }
        public class Item
        {
            public string name;
            public string country;
        }
    }
}

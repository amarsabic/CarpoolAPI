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
            //dtmVrijeme.Format = DateTimePickerFormat.Custom;
            //dtmVrijeme.CustomFormat = "HH:mm";
            //dtmVrijeme.ShowUpDown = true;

            await LoadPolazak();
            await LoadDestinacija();
            await LoadAutomobili();
            await LoadVoznje();
        }

        private async Task LoadPolazak()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);

            cmbPolazak.DataSource = result;
          
            cmbPolazak.DisplayMember = "Naziv";
            cmbPolazak.ValueMember = "GradID";
        }
        private async Task LoadDestinacija()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);

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

            //cmbAutomobil.DataSource = result;

            //cmbAutomobil.DisplayMember = "NazivModel";
            //cmbAutomobil.ValueMember = "AutomobilID";
        }
        private async Task LoadVoznje()
        {
            VoznjaSearchRequest search = new VoznjaSearchRequest
            {
               IsSlobodnaMjesta=true
            };

            var result = await _voznje.Get<List<Model.Voznja>>(search);

            dgvVoznje.AutoGenerateColumns = false;
            dgvVoznje.DataSource = result;
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

        private async void btnPretragaDestinacije_Click(object sender, EventArgs e)
        {
            try
            {
                VoznjaSearchRequest search = new VoznjaSearchRequest
                {
                    SearchFromHomePage = true,
                    DatumPolaska=dtmDatumPolaska.Value
                };

                var idPolazak = cmbPolazak.SelectedValue;
                var idDestinacija = cmbDestinacija.SelectedValue;

                if (idPolazak != null)
                {
                    if (int.TryParse(idPolazak.ToString(), out int IDpolazak))
                    {
                        search.GradPolaskaID = IDpolazak;
                    }
                }
                else
                {
                    MessageBox.Show("Unesite grad polaska");
                    return;
                }

                if (idDestinacija!=null)
                {
                    if (int.TryParse(idDestinacija.ToString(), out int IDdestinacija))
                    {
                        search.GradDestinacijaID = IDdestinacija;
                    }
                }
                else
                {
                    MessageBox.Show("Unesite grad destinaciju");
                    return;
                }
                
                var result = await _voznje.Get<List<Model.Voznja>>(search);

                if (result.Count() == 0)
                {
                    MessageBox.Show("Trenutno nema rezultata za traženu destinaciju");
                }
                else
                {
                    dgvVoznje.AutoGenerateColumns = false;
                    dgvVoznje.DataSource = result;
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgvVoznje_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var voznjaId = int.Parse(dgvVoznje.SelectedRows[0].Cells[0].Value.ToString());

           frmUkloni frm = new frmUkloni(voznjaId);
           frm.Show(); 
        }

        private async void btnZavrsene_Click(object sender, EventArgs e)
        {
            VoznjaSearchRequest search = new VoznjaSearchRequest
            {
                IsZavrsena = true
            };

            var result = await _voznje.Get<List<Model.Voznja>>(search);

            dgvVoznje.AutoGenerateColumns = false;
            dgvVoznje.DataSource = result;
        }

        private async void btnAktivne_Click(object sender, EventArgs e)
        {
            VoznjaSearchRequest search = new VoznjaSearchRequest
            {
                IsSlobodnaMjesta = true
            };

            var result = await _voznje.Get<List<Model.Voznja>>(search);

            dgvVoznje.AutoGenerateColumns = false;
            dgvVoznje.DataSource = result;
        }

        //private async void btnPretragaKorisnika_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtKorisnik.Text))
        //    {
        //        MessageBox.Show("Unesite ID vozača");
        //    }
        //    else if (!System.Text.RegularExpressions.Regex.IsMatch(txtKorisnik.Text, "^[0-9]*$"))
        //    {
        //        MessageBox.Show("ID mora biti broj");
        //    }
        //    else
        //    {
        //        VoznjaSearchRequest search = new VoznjaSearchRequest
        //        {
        //            VozacID = int.Parse(txtKorisnik.Text)
        //        };

        //        var result = await _voznje.Get<List<Model.Voznja>>(search);

        //        if (result.Count() > 0)
        //        {
        //            dgvVoznje.AutoGenerateColumns = false;
        //            dgvVoznje.DataSource = result;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Ne postoji vozač sa traženim ID");
        //        }

        //    }
        //}
    }
}

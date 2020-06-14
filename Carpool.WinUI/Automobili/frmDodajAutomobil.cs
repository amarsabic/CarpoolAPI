using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI.Automobili
{
    public partial class frmDodajAutomobil : Form
    {
        private readonly APIService _apiService = new APIService("automobil");
        private int? _id = null;
        public frmDodajAutomobil(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDodaj_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _apiService.GetById<Model.Automobil>(_id);

                txtNaziv.Text = result.Naziv;
                txtModel.Text = result.Model;
                txtRegOznake.Text = result.BrojRegOznaka;
                txtGodiste.Text = result.Godiste;
            }
        }

        AutomobilInsertRequest request = new AutomobilInsertRequest();
        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNaziv.Text;
            request.Model = txtModel.Text;
            request.BrojRegOznaka = txtRegOznake.Text;
            request.Godiste = txtGodiste.Text;
         
            if (_id.HasValue)
            {

                //await _apiService.Update<Model.Automobil>(_id, request);
            }
            else
            {
                await _apiService.Insert<Model.Automobil>(request);
            }

            MessageBox.Show("Uspješno dodavanje");
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                request.SlikaThumb = file;

                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
            }
        }
    }
}

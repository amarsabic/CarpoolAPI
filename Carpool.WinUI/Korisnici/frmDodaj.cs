﻿using Carpool.Model.Requests;
using Carpool.WinUI.Izvještaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI.Korisnici
{
    public partial class frmDodaj : Form
    {
        private readonly APIService _apiService = new APIService("korisnik");
        private readonly APIService _ulogeService = new APIService("Uloga");
        private readonly APIService _gradovi = new APIService("Grad");

        private int? _id = null;
        public frmDodaj(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;

            if (_id.HasValue)
            {
                lblPassword.Visible = false;
                lblPotvrdaPassworda.Visible = false;
                txtPass.Visible = false;
                txtPassPotvrda.Visible = false;
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        KorisnikInsertRequest request = new KorisnikInsertRequest();
        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var roleList = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();

                //var request = new KorisnikInsertRequest()
                //{
                request.Email = txtEmail.Text;
                request.BrojTelefona = txtTelefon.Text;
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.KorisnickoIme = txtKorisnickoIme.Text;
                request.Password = txtPass.Text;
                request.PasswordConfirmation = txtPassPotvrda.Text;
                request.Uloge = roleList;
                request.DatumRodjenja = dtmDatumRodjenja.Value;
                //Slika=profilePicture
                //};

                if (cmbGrad.SelectedIndex == 0)
                {
                    MessageBox.Show("Unesite grad");
                    return;
                }

                var idGrad = cmbGrad.SelectedValue;


                if (int.TryParse(idGrad.ToString(), out int gradId))
                {
                    request.GradID = gradId;
                }


                Model.Korisnik entity = null;
                if (_id.HasValue)
                {
                    entity = await _apiService.Update<Model.Korisnik>(_id.Value, request);
                }
                else
                {
                    entity = await _apiService.Insert<Model.Korisnik>(request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    this.Close();
                }
            }
        }

        private async void frmDodaj_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Model.Korisnik>(_id);
                if (korisnik != null)
                {
                    txtIme.Text = korisnik.Ime;
                    txtPrezime.Text = korisnik.Prezime;
                    txtEmail.Text = korisnik.Email;
                    txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                    txtTelefon.Text = korisnik.BrojTelefona;
                    dtmDatumRodjenja.Value = korisnik.DatumRodjenja;
                    if (korisnik.Slika.Length != 0)
                    {
                        profilePicture.Image = ByteToImage(korisnik.Slika);
                        profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji ili je uklonjen!");
                    return;
                }
            }

            await LoadUloge();
            await LoadGradovi();
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);
            cmbGrad.DataSource = result;
            result.Insert(0, new Model.Grad());

            if (_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Model.Korisnik>(_id);
                var grad = await _gradovi.GetById<Model.Grad>(korisnik.GradID);

                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].GradID == grad.GradID)
                    {
                        cmbGrad.SelectedItem = result[i + 1];
                    }
                }
            }

            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "GradID";
        }
        private async Task LoadUloge()
        {
            var ulogeList = await _ulogeService.Get<List<Model.Uloge>>(null);

            clbUloge.DataSource = ulogeList;
            clbUloge.DisplayMember = "Naziv";
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) && txtIme.Text.Length < 3)
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField + "Minimalna dužina karaktera 3");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text) && txtPrezime.Text.Length < 3)
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField + "Minimalna dužina karaktera 3");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefon.Text, "^[0-9]*$"))
            {
                errorProvider.SetError(txtTelefon, "Telefon može sadržavati samo brojeve");
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!match.Success)
            {
                errorProvider.SetError(txtEmail, "Email mora biti u formatu mail@mail.com");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                await _apiService.Delete<Model.Korisnik>(_id.Value);
                MessageBox.Show("Uspješno obrisan korisnik");

                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmVoznjeReport frm = new frmVoznjeReport(_id);
            frm.Show();
        }

        private void txtKorisnickoIme_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtKorisnickoIme.Text.Length < 4)
            {
                errorProvider.SetError(txtKorisnickoIme, "Korisničko ime mora sadržavati najmanje 4 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = System.IO.File.ReadAllBytes(fileName);

                request.Slika = file;
                request.SlikaThumb = file;

                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                profilePicture.Image = image;
            }
        }
    }
}

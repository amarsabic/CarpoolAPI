using Carpool.Model.Requests;
using Carpool.WinUI.Izvještaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var roleList = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();

                var request = new KorisnikInsertRequest()
                {
                    Email = txtEmail.Text,
                    BrojTelefona = txtTelefon.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPass.Text,
                    PasswordConfirmation = txtPassPotvrda.Text,
                    Uloge=roleList
                };

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
                }

                this.Close();
            }
        }

        private async void frmDodaj_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Model.Korisnik>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtTelefon.Text = korisnik.BrojTelefona;
            }

            await LoadUloge();
            await LoadGradovi();
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());

            cmbGrad.DataSource = result;

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
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
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
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length < 3)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var request = new KorisnikInsertRequest
            {
                Password = txtPasswordNovi.Text,
                PasswordConfirmation = txtPotvrda.Text,
                OldPassword = txtPasswordStari.Text
            };

            try
            {
                await _apiService.Update<Model.Korisnik>(_id.Value, request);
                MessageBox.Show("Uspješno izvršeno");

                this.Close();
            }
            catch (Exception)
            {

            }


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
    }
}

using Carpool.Model.Requests;
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
    public partial class frmPassword : Form
    {
        private readonly APIService _apiService = new APIService("korisnik");
        public frmPassword()
        {
            InitializeComponent();
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
                var result = await _apiService.Update<Model.Korisnik>(1, request);
                if (result != null)
                {
                    MessageBox.Show("Uspješno izvršeno! Logirajte se ponovo!");
                    Application.Restart();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

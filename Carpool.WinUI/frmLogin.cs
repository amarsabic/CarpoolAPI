using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Automobil");
        public frmLogin()
        {
            InitializeComponent();

            if (Properties.Settings.Default.userName != string.Empty)
            {
                txtKorisnickoIme.Text = Properties.Settings.Default.userName;
                txtPassword.Text = Properties.Settings.Default.passUser;
                cbRemember.Checked = true;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtPassword.Text;

                await _service.Get<dynamic>(null);
                if (cbRemember.Checked)
                {
                    Properties.Settings.Default.userName = txtKorisnickoIme.Text;
                    Properties.Settings.Default.passUser = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                if (Properties.Settings.Default.userName != string.Empty && !cbRemember.Checked)
                {
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.passUser = "";
                    Properties.Settings.Default.Save();
                }
                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

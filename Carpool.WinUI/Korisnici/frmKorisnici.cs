using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using System.Threading;
using Carpool.Model.Requests;

namespace Carpool.WinUI.Korisnici
{  
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("korisnik");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var result = await _apiService.Get<List<Model.Korisnik>>(search);

            if (result.Count() == 0)
            {
                MessageBox.Show("Trenutno nema traženih rezultata");
            }
            else
            {
                dgvKorisnici.AutoGenerateColumns = false;
                dgvKorisnici.DataSource = result;
            }
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;

            frmDodaj frm = new frmDodaj(int.Parse(id.ToString()));
            frm.Show();
        }
        private async void btnPrikaziAdmine_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                IsAdmin = true
            };

            var result = await _apiService.Get<List<Model.Korisnik>>(search);

            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
        }
    }
}

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

namespace Carpool.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _rezervacije = new APIService("Rezervacija");

        private int? _id;
        public frmRezervacije(int? voznjaID)
        {
            InitializeComponent();
            _id = voznjaID;
        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            await LoadRezervacije();
        }

        private async Task LoadRezervacije()
        {
            RezervacijaSearchRequest search = new RezervacijaSearchRequest
            {
                ByVoznjaId = true,
                VoznjaID = (int)_id
            };

            var result = await _rezervacije.Get<List<Model.Rezervacija>>(search);

            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = result;
        }

        private void dgvRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var rezervacijaId = int.Parse(dgvRezervacije.SelectedRows[0].Cells[0].Value.ToString());

            frmUkloniRezervaciju frm = new frmUkloniRezervaciju(rezervacijaId);
            frm.Show();
        }
    }
}

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

namespace Carpool.WinUI.Obavijesti
{
    public partial class frmDetaljiObavijesti : Form
    {
        private readonly APIService _obavijestiService = new APIService("Obavijesti");
        public frmDetaljiObavijesti()
        {
            InitializeComponent();
        }

        private async void frmDetaljiObavijesti_Load(object sender, EventArgs e)
        {
            var list = await _obavijestiService.Get<List<Model.Obavijesti>>(null);

            dgvObavijestiList.AutoGenerateColumns = false;
            dgvObavijestiList.DataSource = list;
        }

        private void btnDodajObavijest_Click(object sender, EventArgs e)
        {
            frmDodajObavijest frm = new frmDodajObavijest();
            frm.Show();
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            ObavijestiSearchRequest request = new ObavijestiSearchRequest
            {
                Naslov = txtSearch.Text
            };

            var list = await _obavijestiService.Get<List<Model.Obavijesti>>(request);
            dgvObavijestiList.AutoGenerateColumns = false;
            dgvObavijestiList.DataSource = list;
        }

        private async void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            var list = await _obavijestiService.Get<List<Model.Obavijesti>>(null);
           
            if (list.Count() != 0)
            {
                dgvObavijestiList.AutoGenerateColumns = false;
                dgvObavijestiList.DataSource = list;
            }
            else
            {
                MessageBox.Show("Trenutno ne postoje obavijesti!");
            }
        }
    }
}

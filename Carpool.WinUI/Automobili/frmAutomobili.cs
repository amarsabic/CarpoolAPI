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

namespace Carpool.WinUI.Automobili
{
    public partial class frmAutomobili : Form
    {
        private readonly APIService _apiService = new APIService("automobil");
        public frmAutomobili()
        {
            InitializeComponent();
        }

 
        private void dgvAutomobili_DoubleClick(object sender, EventArgs e)
        {
            var id = dgvAutomobili.SelectedRows[0].Cells[0].Value;

            frmDodajAutomobil frm = new frmDodajAutomobil(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new AutomobilSearchRequest()
            {
                Naziv = txtSearch.Text
            };

            var result = await _apiService.Get<List<Model.Automobil>>(search);

            dgvAutomobili.DataSource = result;
        }
    }
}

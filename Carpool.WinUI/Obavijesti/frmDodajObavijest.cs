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
    public partial class frmDodajObavijest : Form
    {
        private readonly APIService _obavijestiService = new APIService("Obavijesti");
        private readonly APIService _tipObavijestiService = new APIService("TipObavijesti");
        public frmDodajObavijest()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            ObavijestiUpsertRequest request = new ObavijestiUpsertRequest();

            var idTip = cmbTipObavijesti.SelectedValue;
            if (int.TryParse(idTip.ToString(), out int tipId))
            {
                request.TipObavijestiID = tipId;
            }

            request.DatumVrijemeObjave = DateTime.Now;
            request.Naslov = txtNaslov.Text;
            request.KratkiOpis = rtxtSadrzaj.Text;

            await _obavijestiService.Insert<Model.Obavijesti>(request);

            MessageBox.Show("Uspješno dodana obavijest");
        }

        private async void frmDodaj_Load(object sender, EventArgs e)
        {
            await LoadTipove();
        }

        private async Task LoadTipove()
        {
            var result = await _tipObavijestiService.Get<List<Model.TipObavijesti>>(null);

            cmbTipObavijesti.DataSource = result;

            cmbTipObavijesti.DisplayMember = "NazivTipa";
            cmbTipObavijesti.ValueMember = "TipObavijestiID";
        }
    }
}

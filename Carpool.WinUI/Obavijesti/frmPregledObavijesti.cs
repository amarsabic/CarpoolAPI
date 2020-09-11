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
    public partial class frmPregledObavijesti : Form
    {
        private readonly APIService _obavijestiService = new APIService("Obavijesti");

        private int _id;
        public frmPregledObavijesti(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmPregledObavijesti_Load(object sender, EventArgs e)
        {
            var obavijest = await _obavijestiService.GetById<Model.Obavijesti>(_id);
            if (obavijest != null)
            {
                lblNaslov.Text = obavijest.Naslov;
                lblOpis.Text = obavijest.KratkiOpis;
            }
            else
            {
                this.Size = new Size(556, 300);
                lblNaslov.Text = "Obavijest ne postoji";
                lblOpis.Text = "Tražena obavijest je uklonjena ili više ne postoji";
                btnUkloni.Visible = false;
            }
        }

        private async void btnUkloni_Click(object sender, EventArgs e)
        {
            try
            {
                var auto = await _obavijestiService.Delete<Model.Obavijesti>(_id);
                if (auto != null)
                {
                    MessageBox.Show("Uspješno uklonjena obavijest!");
                }

                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}

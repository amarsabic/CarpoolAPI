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
    public partial class frmUkloniRezervaciju : Form
    {
        private readonly APIService _rezervacija = new APIService("Rezervacija");

        private int _id;
        public frmUkloniRezervaciju(int rezervacijaId)
        {
            InitializeComponent();
            _id = rezervacijaId;
        }

        private async void btnUkloni_Click(object sender, EventArgs e)
        {
            try
            {
                await _rezervacija.Delete<Model.Rezervacija>(_id);
                this.Close();
                MessageBox.Show("Uspješno izvršeno");
                this.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}

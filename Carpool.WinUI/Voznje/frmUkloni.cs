using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI.Voznje
{
    public partial class frmUkloni : Form
    {
        private readonly APIService _voznja = new APIService("Voznja");

        private int _id;
        public frmUkloni(int voznjaId)
        {
            InitializeComponent();
            _id = voznjaId;
        }

        private async void btnUkloni_Click(object sender, EventArgs e)
        {
            try
            {
                await _voznja.Delete<Model.Voznja>(_id);
                MessageBox.Show("Uspješno izvršeno");
                this.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}

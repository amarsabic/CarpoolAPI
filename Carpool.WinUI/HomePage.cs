using Carpool.WinUI.Automobili;
using Carpool.WinUI.Korisnici;
using Carpool.WinUI.Obavijesti;
using Carpool.WinUI.Rezervacije;
using Carpool.WinUI.Voznje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI
{
    public partial class HomePage : Form
    {
        private Button currentButton;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;
        public HomePage()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        //DRAG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            return ColorTranslator.FromHtml("#212529");
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Calibri", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(19, 19, 19);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblNaslov.Text = childForm.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
            frmVoznje frm = new frmVoznje();
            frm.TopLevel = false;
            OpenChildForm(frm, sender);
        }

        //private void btnRezervacije_Click(object sender, EventArgs e)
        //{
        //    frmRezervacije frm = new frmRezervacije(null);
        //    frm.TopLevel = false;
        //    OpenChildForm(frm, sender);
        //}

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            frmDetaljiObavijesti frm = new frmDetaljiObavijesti();
            frm.TopLevel = false;
            OpenChildForm(frm, sender);
        }

        private void btnAutomobili_Click(object sender, EventArgs e)
        {
            frmAutomobili frm = new frmAutomobili();
            frm.TopLevel = false;
            OpenChildForm(frm, sender);
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.TopLevel = false;
            OpenChildForm(frm, sender);
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(new Obavijesti.frmDodajObavijest(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblNaslov.Text = "Početna";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

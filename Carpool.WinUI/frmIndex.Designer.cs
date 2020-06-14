namespace Carpool.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAutomobilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajAutomobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voznjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.automobiliToolStripMenuItem,
            this.voznjeToolStripMenuItem,
            this.obavijestiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(998, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziKorisnikeToolStripMenuItem,
            this.dodajNovogKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // prikaziKorisnikeToolStripMenuItem
            // 
            this.prikaziKorisnikeToolStripMenuItem.Name = "prikaziKorisnikeToolStripMenuItem";
            this.prikaziKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.prikaziKorisnikeToolStripMenuItem.Text = "Prikazi korisnike";
            this.prikaziKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.prikaziKorisnikeToolStripMenuItem_Click);
            // 
            // dodajNovogKorisnikaToolStripMenuItem
            // 
            this.dodajNovogKorisnikaToolStripMenuItem.Name = "dodajNovogKorisnikaToolStripMenuItem";
            this.dodajNovogKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.dodajNovogKorisnikaToolStripMenuItem.Text = "Dodaj novog korisnika";
            this.dodajNovogKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogKorisnikaToolStripMenuItem_Click);
            // 
            // automobiliToolStripMenuItem
            // 
            this.automobiliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaAutomobilaToolStripMenuItem,
            this.dodajAutomobilToolStripMenuItem});
            this.automobiliToolStripMenuItem.Name = "automobiliToolStripMenuItem";
            this.automobiliToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.automobiliToolStripMenuItem.Text = "Automobili";
            // 
            // listaAutomobilaToolStripMenuItem
            // 
            this.listaAutomobilaToolStripMenuItem.Name = "listaAutomobilaToolStripMenuItem";
            this.listaAutomobilaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listaAutomobilaToolStripMenuItem.Text = "Lista automobila";
            this.listaAutomobilaToolStripMenuItem.Click += new System.EventHandler(this.listaAutomobilaToolStripMenuItem_Click);
            // 
            // dodajAutomobilToolStripMenuItem
            // 
            this.dodajAutomobilToolStripMenuItem.Name = "dodajAutomobilToolStripMenuItem";
            this.dodajAutomobilToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dodajAutomobilToolStripMenuItem.Text = "Dodaj automobil";
            this.dodajAutomobilToolStripMenuItem.Click += new System.EventHandler(this.dodajAutomobilToolStripMenuItem_Click);
            // 
            // voznjeToolStripMenuItem
            // 
            this.voznjeToolStripMenuItem.Name = "voznjeToolStripMenuItem";
            this.voznjeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.voznjeToolStripMenuItem.Text = "Voznje";
            this.voznjeToolStripMenuItem.Click += new System.EventHandler(this.voznjeToolStripMenuItem_Click);
            // 
            // obavijestiToolStripMenuItem
            // 
            this.obavijestiToolStripMenuItem.Name = "obavijestiToolStripMenuItem";
            this.obavijestiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.obavijestiToolStripMenuItem.Text = "Obavijesti";
            this.obavijestiToolStripMenuItem.Click += new System.EventHandler(this.obavijestiToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 624);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(998, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 646);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziKorisnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automobiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaAutomobilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajAutomobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voznjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiToolStripMenuItem;
    }
}




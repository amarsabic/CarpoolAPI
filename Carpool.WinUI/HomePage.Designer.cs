namespace Carpool.WinUI
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnVoznje = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnAutomobili = new System.Windows.Forms.Button();
            this.btnObavijesti = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panelMenu.Controls.Add(this.btnIzvjestaji);
            this.panelMenu.Controls.Add(this.btnVoznje);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnKorisnici);
            this.panelMenu.Controls.Add(this.btnAutomobili);
            this.panelMenu.Controls.Add(this.btnObavijesti);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 686);
            this.panelMenu.TabIndex = 0;
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.FlatAppearance.BorderSize = 0;
            this.btnIzvjestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvjestaji.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIzvjestaji.Image = ((System.Drawing.Image)(resources.GetObject("btnIzvjestaji.Image")));
            this.btnIzvjestaji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaji.Location = new System.Drawing.Point(0, 327);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnIzvjestaji.Size = new System.Drawing.Size(260, 41);
            this.btnIzvjestaji.TabIndex = 9;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // btnVoznje
            // 
            this.btnVoznje.FlatAppearance.BorderSize = 0;
            this.btnVoznje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoznje.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoznje.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVoznje.Image = ((System.Drawing.Image)(resources.GetObject("btnVoznje.Image")));
            this.btnVoznje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoznje.Location = new System.Drawing.Point(-3, 139);
            this.btnVoznje.Name = "btnVoznje";
            this.btnVoznje.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnVoznje.Size = new System.Drawing.Size(260, 41);
            this.btnVoznje.TabIndex = 8;
            this.btnVoznje.Text = "Vožnje";
            this.btnVoznje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoznje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoznje.UseVisualStyleBackColor = true;
            this.btnVoznje.Click += new System.EventHandler(this.btnVoznje_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 104);
            this.panelLogo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "POOL";
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.FlatAppearance.BorderSize = 0;
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKorisnici.Image = ((System.Drawing.Image)(resources.GetObject("btnKorisnici.Image")));
            this.btnKorisnici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKorisnici.Location = new System.Drawing.Point(0, 280);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnKorisnici.Size = new System.Drawing.Size(260, 41);
            this.btnKorisnici.TabIndex = 4;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKorisnici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnAutomobili
            // 
            this.btnAutomobili.FlatAppearance.BorderSize = 0;
            this.btnAutomobili.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomobili.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomobili.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAutomobili.Image = ((System.Drawing.Image)(resources.GetObject("btnAutomobili.Image")));
            this.btnAutomobili.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutomobili.Location = new System.Drawing.Point(0, 233);
            this.btnAutomobili.Name = "btnAutomobili";
            this.btnAutomobili.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAutomobili.Size = new System.Drawing.Size(260, 41);
            this.btnAutomobili.TabIndex = 3;
            this.btnAutomobili.Text = "Automobili";
            this.btnAutomobili.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutomobili.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutomobili.UseVisualStyleBackColor = true;
            this.btnAutomobili.Click += new System.EventHandler(this.btnAutomobili_Click);
            // 
            // btnObavijesti
            // 
            this.btnObavijesti.FlatAppearance.BorderSize = 0;
            this.btnObavijesti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObavijesti.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObavijesti.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnObavijesti.Image = ((System.Drawing.Image)(resources.GetObject("btnObavijesti.Image")));
            this.btnObavijesti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObavijesti.Location = new System.Drawing.Point(0, 186);
            this.btnObavijesti.Name = "btnObavijesti";
            this.btnObavijesti.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnObavijesti.Size = new System.Drawing.Size(260, 41);
            this.btnObavijesti.TabIndex = 2;
            this.btnObavijesti.Text = "Obavijesti";
            this.btnObavijesti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObavijesti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObavijesti.UseVisualStyleBackColor = true;
            this.btnObavijesti.Click += new System.EventHandler(this.btnObavijesti_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(169)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblNaslov);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(260, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1006, 104);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::Carpool.WinUI.Properties.Resources.x_mark_24;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 104);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNaslov.Location = new System.Drawing.Point(437, 36);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(92, 26);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Početna";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(260, 104);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1006, 582);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(969, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(942, 8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(34, 41);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(915, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 41);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 686);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnAutomobili;
        private System.Windows.Forms.Button btnObavijesti;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoznje;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}
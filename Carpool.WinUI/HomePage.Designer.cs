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
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnVoznje = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnAutomobili = new System.Windows.Forms.Button();
            this.btnObavijesti = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAutomobil = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKorisnici = new System.Windows.Forms.Label();
            this.panelAktivneVoznje = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBrojAktivnihVoznji = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAktivneVoznje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnPassword);
            this.panelMenu.Controls.Add(this.profilePicture);
            this.panelMenu.Controls.Add(this.btnIzvjestaji);
            this.panelMenu.Controls.Add(this.btnDodaj);
            this.panelMenu.Controls.Add(this.btnVoznje);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnKorisnici);
            this.panelMenu.Controls.Add(this.btnAutomobili);
            this.panelMenu.Controls.Add(this.btnObavijesti);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 691);
            this.panelMenu.TabIndex = 0;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(41, 126);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(166, 135);
            this.profilePicture.TabIndex = 7;
            this.profilePicture.TabStop = false;
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.FlatAppearance.BorderSize = 0;
            this.btnIzvjestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvjestaji.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIzvjestaji.Image = ((System.Drawing.Image)(resources.GetObject("btnIzvjestaji.Image")));
            this.btnIzvjestaji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaji.Location = new System.Drawing.Point(3, 611);
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
            this.btnVoznje.Location = new System.Drawing.Point(0, 423);
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
            this.btnKorisnici.Location = new System.Drawing.Point(3, 564);
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
            this.btnAutomobili.Location = new System.Drawing.Point(3, 517);
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
            this.btnObavijesti.Location = new System.Drawing.Point(3, 470);
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
            this.panelDesktopPanel.Controls.Add(this.pictureBox4);
            this.panelDesktopPanel.Controls.Add(this.panel2);
            this.panelDesktopPanel.Controls.Add(this.panel1);
            this.panelDesktopPanel.Controls.Add(this.panelAktivneVoznje);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(260, 104);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1006, 587);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Carpool.WinUI.Properties.Resources.rsz_1pngegg;
            this.pictureBox4.Location = new System.Drawing.Point(335, 240);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(332, 282);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelAutomobil);
            this.panel2.Location = new System.Drawing.Point(689, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 150);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Carpool.WinUI.Properties.Resources.car_3_1281;
            this.pictureBox3.Location = new System.Drawing.Point(126, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 123);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(14, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Automobila";
            // 
            // labelAutomobil
            // 
            this.labelAutomobil.AutoSize = true;
            this.labelAutomobil.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutomobil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAutomobil.Location = new System.Drawing.Point(12, 42);
            this.labelAutomobil.Name = "labelAutomobil";
            this.labelAutomobil.Size = new System.Drawing.Size(58, 45);
            this.labelAutomobil.TabIndex = 1;
            this.labelAutomobil.Text = "23";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelKorisnici);
            this.panel1.Location = new System.Drawing.Point(361, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 150);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Carpool.WinUI.Properties.Resources.conference_128;
            this.pictureBox2.Location = new System.Drawing.Point(123, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 128);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Aktivnih Korisnika";
            // 
            // labelKorisnici
            // 
            this.labelKorisnici.AutoSize = true;
            this.labelKorisnici.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnici.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKorisnici.Location = new System.Drawing.Point(12, 42);
            this.labelKorisnici.Name = "labelKorisnici";
            this.labelKorisnici.Size = new System.Drawing.Size(58, 45);
            this.labelKorisnici.TabIndex = 1;
            this.labelKorisnici.Text = "23";
            // 
            // panelAktivneVoznje
            // 
            this.panelAktivneVoznje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAktivneVoznje.Controls.Add(this.pictureBox1);
            this.panelAktivneVoznje.Controls.Add(this.label4);
            this.panelAktivneVoznje.Controls.Add(this.labelBrojAktivnihVoznji);
            this.panelAktivneVoznje.Location = new System.Drawing.Point(42, 35);
            this.panelAktivneVoznje.Name = "panelAktivneVoznje";
            this.panelAktivneVoznje.Size = new System.Drawing.Size(280, 150);
            this.panelAktivneVoznje.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carpool.WinUI.Properties.Resources.pin_8_128;
            this.pictureBox1.Location = new System.Drawing.Point(131, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 132);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aktivnih Vožnji";
            // 
            // labelBrojAktivnihVoznji
            // 
            this.labelBrojAktivnihVoznji.AutoSize = true;
            this.labelBrojAktivnihVoznji.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojAktivnihVoznji.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBrojAktivnihVoznji.Location = new System.Drawing.Point(12, 42);
            this.labelBrojAktivnihVoznji.Name = "labelBrojAktivnihVoznji";
            this.labelBrojAktivnihVoznji.Size = new System.Drawing.Size(58, 45);
            this.labelBrojAktivnihVoznji.TabIndex = 1;
            this.labelBrojAktivnihVoznji.Text = "23";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodaj.Location = new System.Drawing.Point(50, 280);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 31);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Uredi profil";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.DarkGray;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPassword.Location = new System.Drawing.Point(50, 317);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(148, 31);
            this.btnPassword.TabIndex = 33;
            this.btnPassword.Text = "Promijeni password";
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(50, 359);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(148, 31);
            this.btnLogout.TabIndex = 34;
            this.btnLogout.Text = "Odjavi se";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 691);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAktivneVoznje.ResumeLayout(false);
            this.panelAktivneVoznje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panelAktivneVoznje;
        private System.Windows.Forms.Label labelBrojAktivnihVoznji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKorisnici;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelAutomobil;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnLogout;
    }
}
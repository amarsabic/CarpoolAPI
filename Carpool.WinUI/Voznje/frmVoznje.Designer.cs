﻿namespace Carpool.WinUI.Voznje
{
    partial class frmVoznje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPolazak = new System.Windows.Forms.ComboBox();
            this.cmbDestinacija = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvVoznje = new System.Windows.Forms.DataGridView();
            this.btnPretragaDestinacije = new System.Windows.Forms.Button();
            this.VoznjaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradPolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradDestinacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutomobilNazivModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaskaString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePolaskaString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunaCijenaPrikaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoznje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grad polaska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grad destinacija";
            // 
            // cmbPolazak
            // 
            this.cmbPolazak.FormattingEnabled = true;
            this.cmbPolazak.Location = new System.Drawing.Point(25, 55);
            this.cmbPolazak.Name = "cmbPolazak";
            this.cmbPolazak.Size = new System.Drawing.Size(194, 21);
            this.cmbPolazak.TabIndex = 4;
            // 
            // cmbDestinacija
            // 
            this.cmbDestinacija.FormattingEnabled = true;
            this.cmbDestinacija.Location = new System.Drawing.Point(269, 55);
            this.cmbDestinacija.Name = "cmbDestinacija";
            this.cmbDestinacija.Size = new System.Drawing.Size(194, 21);
            this.cmbDestinacija.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // dgvVoznje
            // 
            this.dgvVoznje.AllowUserToAddRows = false;
            this.dgvVoznje.AllowUserToDeleteRows = false;
            this.dgvVoznje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoznje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoznjaID,
            this.GradPolaska,
            this.GradDestinacija,
            this.KorisnickoIme,
            this.AutomobilNazivModel,
            this.DatumPolaskaString,
            this.VrijemePolaskaString,
            this.DatumObjave,
            this.PunaCijenaPrikaz,
            this.IsAktivna});
            this.dgvVoznje.Location = new System.Drawing.Point(12, 248);
            this.dgvVoznje.Name = "dgvVoznje";
            this.dgvVoznje.ReadOnly = true;
            this.dgvVoznje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoznje.Size = new System.Drawing.Size(1190, 443);
            this.dgvVoznje.TabIndex = 19;
            this.dgvVoznje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVoznje_MouseDoubleClick);
            // 
            // btnPretragaDestinacije
            // 
            this.btnPretragaDestinacije.Location = new System.Drawing.Point(486, 52);
            this.btnPretragaDestinacije.Name = "btnPretragaDestinacije";
            this.btnPretragaDestinacije.Size = new System.Drawing.Size(101, 23);
            this.btnPretragaDestinacije.TabIndex = 20;
            this.btnPretragaDestinacije.Text = "Traži destinaciju";
            this.btnPretragaDestinacije.UseVisualStyleBackColor = true;
            this.btnPretragaDestinacije.Click += new System.EventHandler(this.btnPretragaDestinacije_Click);
            // 
            // VoznjaID
            // 
            this.VoznjaID.DataPropertyName = "VoznjaID";
            this.VoznjaID.HeaderText = "VoznjaID";
            this.VoznjaID.Name = "VoznjaID";
            this.VoznjaID.ReadOnly = true;
            this.VoznjaID.Visible = false;
            // 
            // GradPolaska
            // 
            this.GradPolaska.DataPropertyName = "GradPolaska";
            this.GradPolaska.HeaderText = "Polazak";
            this.GradPolaska.Name = "GradPolaska";
            this.GradPolaska.ReadOnly = true;
            // 
            // GradDestinacija
            // 
            this.GradDestinacija.DataPropertyName = "GradDestinacija";
            this.GradDestinacija.HeaderText = "Destinacija";
            this.GradDestinacija.Name = "GradDestinacija";
            this.GradDestinacija.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnik";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KorisnickoIme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AutomobilNazivModel
            // 
            this.AutomobilNazivModel.DataPropertyName = "AutomobilNazivModel";
            this.AutomobilNazivModel.HeaderText = "Automobil";
            this.AutomobilNazivModel.Name = "AutomobilNazivModel";
            this.AutomobilNazivModel.ReadOnly = true;
            this.AutomobilNazivModel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AutomobilNazivModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DatumPolaskaString
            // 
            this.DatumPolaskaString.DataPropertyName = "DatumPolaskaString";
            this.DatumPolaskaString.HeaderText = "Datum polaska";
            this.DatumPolaskaString.Name = "DatumPolaskaString";
            this.DatumPolaskaString.ReadOnly = true;
            // 
            // VrijemePolaskaString
            // 
            this.VrijemePolaskaString.DataPropertyName = "VrijemePolaskaString";
            this.VrijemePolaskaString.HeaderText = "Vrijeme";
            this.VrijemePolaskaString.Name = "VrijemePolaskaString";
            this.VrijemePolaskaString.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Objavljeno";
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // PunaCijenaPrikaz
            // 
            this.PunaCijenaPrikaz.DataPropertyName = "PunaCijenaPrikaz";
            this.PunaCijenaPrikaz.HeaderText = "Cijena";
            this.PunaCijenaPrikaz.Name = "PunaCijenaPrikaz";
            this.PunaCijenaPrikaz.ReadOnly = true;
            // 
            // IsAktivna
            // 
            this.IsAktivna.DataPropertyName = "IsAktivna";
            this.IsAktivna.HeaderText = "Aktivna";
            this.IsAktivna.Name = "IsAktivna";
            this.IsAktivna.ReadOnly = true;
            // 
            // frmVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 703);
            this.Controls.Add(this.btnPretragaDestinacije);
            this.Controls.Add(this.dgvVoznje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDestinacija);
            this.Controls.Add(this.cmbPolazak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVoznje";
            this.Text = "frmVoznje";
            this.Load += new System.EventHandler(this.frmVoznje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoznje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPolazak;
        private System.Windows.Forms.ComboBox cmbDestinacija;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvVoznje;
        private System.Windows.Forms.Button btnPretragaDestinacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoznjaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradPolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradDestinacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutomobilNazivModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaskaString;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePolaskaString;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunaCijenaPrikaz;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAktivna;
    }
}
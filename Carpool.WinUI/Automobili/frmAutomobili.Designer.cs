﻿namespace Carpool.WinUI.Automobili
{
    partial class frmAutomobili
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
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.AutomobilID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registracija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPretragaKorisnika = new System.Windows.Forms.Button();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.AllowUserToAddRows = false;
            this.dgvAutomobili.AllowUserToDeleteRows = false;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutomobilID,
            this.Slika,
            this.Naziv,
            this.Model,
            this.Godiste,
            this.Registracija,
            this.DatumIsteka});
            this.dgvAutomobili.Location = new System.Drawing.Point(13, 103);
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.ReadOnly = true;
            this.dgvAutomobili.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAutomobili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomobili.Size = new System.Drawing.Size(775, 351);
            this.dgvAutomobili.TabIndex = 0;
            this.dgvAutomobili.DoubleClick += new System.EventHandler(this.dgvAutomobili_DoubleClick);
            // 
            // AutomobilID
            // 
            this.AutomobilID.DataPropertyName = "AutomobilID";
            this.AutomobilID.HeaderText = "AutomobilID";
            this.AutomobilID.Name = "AutomobilID";
            this.AutomobilID.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Godiste
            // 
            this.Godiste.DataPropertyName = "Godiste";
            this.Godiste.HeaderText = "Godište";
            this.Godiste.Name = "Godiste";
            this.Godiste.ReadOnly = true;
            // 
            // Registracija
            // 
            this.Registracija.DataPropertyName = "BrojRegOznaka";
            this.Registracija.HeaderText = "Registracija";
            this.Registracija.Name = "Registracija";
            this.Registracija.ReadOnly = true;
            // 
            // DatumIsteka
            // 
            this.DatumIsteka.DataPropertyName = "DatumIstekaRegistracije";
            this.DatumIsteka.HeaderText = "Datum isteka";
            this.DatumIsteka.Name = "DatumIsteka";
            this.DatumIsteka.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(225, 56);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(83, 19);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Traži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "VozačID";
            // 
            // btnPretragaKorisnika
            // 
            this.btnPretragaKorisnika.Location = new System.Drawing.Point(615, 70);
            this.btnPretragaKorisnika.Name = "btnPretragaKorisnika";
            this.btnPretragaKorisnika.Size = new System.Drawing.Size(101, 23);
            this.btnPretragaKorisnika.TabIndex = 27;
            this.btnPretragaKorisnika.Text = "Pretraži";
            this.btnPretragaKorisnika.UseVisualStyleBackColor = true;
            this.btnPretragaKorisnika.Click += new System.EventHandler(this.btnPretragaKorisnika_Click);
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(566, 44);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(194, 20);
            this.txtKorisnik.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pretraga po nazivu automobila";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAutomobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPretragaKorisnika);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAutomobili);
            this.Name = "frmAutomobili";
            this.Text = "Automobili";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutomobilID;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registracija;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsteka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPretragaKorisnika;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
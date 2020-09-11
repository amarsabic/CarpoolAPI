namespace Carpool.WinUI.Obavijesti
{
    partial class frmDetaljiObavijesti
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
            this.dgvObavijestiList = new System.Windows.Forms.DataGridView();
            this.btnDodajObavijest = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.ObavijestiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KratkiOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemeObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObavijestiList
            // 
            this.dgvObavijestiList.AllowUserToAddRows = false;
            this.dgvObavijestiList.AllowUserToDeleteRows = false;
            this.dgvObavijestiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijestiList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObavijestiID,
            this.Naslov,
            this.KratkiOpis,
            this.NazivTipa,
            this.DatumVrijemeObjave,
            this.KorisnickoIme});
            this.dgvObavijestiList.Location = new System.Drawing.Point(32, 197);
            this.dgvObavijestiList.Name = "dgvObavijestiList";
            this.dgvObavijestiList.ReadOnly = true;
            this.dgvObavijestiList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijestiList.Size = new System.Drawing.Size(659, 331);
            this.dgvObavijestiList.TabIndex = 0;
            this.dgvObavijestiList.DoubleClick += new System.EventHandler(this.dgvObavijestiList_DoubleClick);
            // 
            // btnDodajObavijest
            // 
            this.btnDodajObavijest.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDodajObavijest.FlatAppearance.BorderSize = 0;
            this.btnDodajObavijest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajObavijest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodajObavijest.Location = new System.Drawing.Point(280, 153);
            this.btnDodajObavijest.Name = "btnDodajObavijest";
            this.btnDodajObavijest.Size = new System.Drawing.Size(161, 31);
            this.btnDodajObavijest.TabIndex = 1;
            this.btnDodajObavijest.Text = "Dodaj obavijest";
            this.btnDodajObavijest.UseVisualStyleBackColor = false;
            this.btnDodajObavijest.Click += new System.EventHandler(this.btnDodajObavijest_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(252, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Korisnik";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(252, 76);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(224, 20);
            this.txtKorisnik.TabIndex = 6;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(169)))));
            this.btnPretraga.FlatAppearance.BorderSize = 0;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPretraga.Location = new System.Drawing.Point(280, 116);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(161, 31);
            this.btnPretraga.TabIndex = 8;
            this.btnPretraga.Text = "Traži";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // ObavijestiID
            // 
            this.ObavijestiID.DataPropertyName = "ObavijestiID";
            this.ObavijestiID.HeaderText = "ID";
            this.ObavijestiID.Name = "ObavijestiID";
            this.ObavijestiID.ReadOnly = true;
            this.ObavijestiID.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // KratkiOpis
            // 
            this.KratkiOpis.DataPropertyName = "KratkiOpis";
            this.KratkiOpis.HeaderText = "Kratki opis";
            this.KratkiOpis.Name = "KratkiOpis";
            this.KratkiOpis.ReadOnly = true;
            // 
            // NazivTipa
            // 
            this.NazivTipa.DataPropertyName = "NazivTipa";
            this.NazivTipa.HeaderText = "Tip";
            this.NazivTipa.Name = "NazivTipa";
            this.NazivTipa.ReadOnly = true;
            // 
            // DatumVrijemeObjave
            // 
            this.DatumVrijemeObjave.DataPropertyName = "DatumVrijemeObjave";
            this.DatumVrijemeObjave.HeaderText = "Objavljeno";
            this.DatumVrijemeObjave.Name = "DatumVrijemeObjave";
            this.DatumVrijemeObjave.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnik";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // frmDetaljiObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 552);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDodajObavijest);
            this.Controls.Add(this.dgvObavijestiList);
            this.Name = "frmDetaljiObavijesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obavijesti";
            this.Load += new System.EventHandler(this.frmDetaljiObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObavijestiList;
        private System.Windows.Forms.Button btnDodajObavijest;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavijestiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn KratkiOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemeObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
    }
}
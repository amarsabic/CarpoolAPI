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
            this.btnTrazi = new System.Windows.Forms.Button();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KratkiOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemeObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VozacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObavijestiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipObavijestiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObavijestiList
            // 
            this.dgvObavijestiList.AllowUserToAddRows = false;
            this.dgvObavijestiList.AllowUserToDeleteRows = false;
            this.dgvObavijestiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijestiList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naslov,
            this.KratkiOpis,
            this.NazivTipa,
            this.DatumVrijemeObjave,
            this.KorisnickoIme,
            this.VozacID,
            this.ObavijestiID,
            this.TipObavijestiID});
            this.dgvObavijestiList.Location = new System.Drawing.Point(12, 188);
            this.dgvObavijestiList.Name = "dgvObavijestiList";
            this.dgvObavijestiList.ReadOnly = true;
            this.dgvObavijestiList.Size = new System.Drawing.Size(759, 250);
            this.dgvObavijestiList.TabIndex = 0;
            // 
            // btnDodajObavijest
            // 
            this.btnDodajObavijest.Location = new System.Drawing.Point(651, 150);
            this.btnDodajObavijest.Name = "btnDodajObavijest";
            this.btnDodajObavijest.Size = new System.Drawing.Size(120, 23);
            this.btnDodajObavijest.TabIndex = 1;
            this.btnDodajObavijest.Text = "Dodaj obavijest";
            this.btnDodajObavijest.UseVisualStyleBackColor = true;
            this.btnDodajObavijest.Click += new System.EventHandler(this.btnDodajObavijest_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(44, 130);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(214, 128);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
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
            this.KorisnickoIme.HeaderText = "Vozač";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // VozacID
            // 
            this.VozacID.DataPropertyName = "VozacID";
            this.VozacID.HeaderText = "Column1";
            this.VozacID.Name = "VozacID";
            this.VozacID.ReadOnly = true;
            this.VozacID.Visible = false;
            // 
            // ObavijestiID
            // 
            this.ObavijestiID.DataPropertyName = "ObavijestiID";
            this.ObavijestiID.HeaderText = "Column1";
            this.ObavijestiID.Name = "ObavijestiID";
            this.ObavijestiID.ReadOnly = true;
            this.ObavijestiID.Visible = false;
            // 
            // TipObavijestiID
            // 
            this.TipObavijestiID.DataPropertyName = "TipObavijestiID";
            this.TipObavijestiID.HeaderText = "Column1";
            this.TipObavijestiID.Name = "TipObavijestiID";
            this.TipObavijestiID.ReadOnly = true;
            this.TipObavijestiID.Visible = false;
            // 
            // frmDetaljiObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDodajObavijest);
            this.Controls.Add(this.dgvObavijestiList);
            this.Name = "frmDetaljiObavijesti";
            this.Text = "frmDetaljiObavijesti";
            this.Load += new System.EventHandler(this.frmDetaljiObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObavijestiList;
        private System.Windows.Forms.Button btnDodajObavijest;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn KratkiOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemeObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn VozacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavijestiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipObavijestiID;
    }
}
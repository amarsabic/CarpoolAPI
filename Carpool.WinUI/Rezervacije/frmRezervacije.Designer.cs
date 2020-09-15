namespace Carpool.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoznjaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradPolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradDestinacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsputniGradNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaID,
            this.VoznjaID,
            this.KorisnickoIme,
            this.DatumRezervacije,
            this.GradPolaska,
            this.GradDestinacija,
            this.UsputniGradNaziv});
            this.dgvRezervacije.Location = new System.Drawing.Point(13, 92);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(752, 425);
            this.dgvRezervacije.TabIndex = 0;
            this.dgvRezervacije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRezervacije_MouseDoubleClick);
            // 
            // RezervacijaID
            // 
            this.RezervacijaID.DataPropertyName = "RezervacijaID";
            this.RezervacijaID.HeaderText = "RezervacijaID";
            this.RezervacijaID.Name = "RezervacijaID";
            this.RezervacijaID.ReadOnly = true;
            // 
            // VoznjaID
            // 
            this.VoznjaID.DataPropertyName = "VoznjaID";
            this.VoznjaID.HeaderText = "VoznjaID";
            this.VoznjaID.Name = "VoznjaID";
            this.VoznjaID.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Putnik";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
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
            // UsputniGradNaziv
            // 
            this.UsputniGradNaziv.DataPropertyName = "UsputniGradNaziv";
            this.UsputniGradNaziv.HeaderText = "Usputni grad";
            this.UsputniGradNaziv.Name = "UsputniGradNaziv";
            this.UsputniGradNaziv.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(169)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(13, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 43);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Printaj rezervaciju";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 533);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvRezervacije);
            this.Name = "frmRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoznjaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradPolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradDestinacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsputniGradNaziv;
        private System.Windows.Forms.Button btnPrint;
    }
}
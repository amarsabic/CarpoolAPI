namespace Carpool.WinUI.Voznje
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
            this.cmbAutomobil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmPolazak = new System.Windows.Forms.DateTimePicker();
            this.dtmVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMjesta = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVoznje = new System.Windows.Forms.DataGridView();
            this.btnJson = new System.Windows.Forms.Button();
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
            this.cmbPolazak.SelectedIndexChanged += new System.EventHandler(this.cmbPolazak_SelectedIndexChanged);
            // 
            // cmbDestinacija
            // 
            this.cmbDestinacija.FormattingEnabled = true;
            this.cmbDestinacija.Location = new System.Drawing.Point(269, 55);
            this.cmbDestinacija.Name = "cmbDestinacija";
            this.cmbDestinacija.Size = new System.Drawing.Size(194, 21);
            this.cmbDestinacija.TabIndex = 5;
            // 
            // cmbAutomobil
            // 
            this.cmbAutomobil.FormattingEnabled = true;
            this.cmbAutomobil.Location = new System.Drawing.Point(25, 162);
            this.cmbAutomobil.Name = "cmbAutomobil";
            this.cmbAutomobil.Size = new System.Drawing.Size(194, 21);
            this.cmbAutomobil.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Automobil";
            // 
            // dtmPolazak
            // 
            this.dtmPolazak.Location = new System.Drawing.Point(25, 106);
            this.dtmPolazak.Name = "dtmPolazak";
            this.dtmPolazak.Size = new System.Drawing.Size(194, 20);
            this.dtmPolazak.TabIndex = 8;
            // 
            // dtmVrijeme
            // 
            this.dtmVrijeme.Location = new System.Drawing.Point(269, 106);
            this.dtmVrijeme.Name = "dtmVrijeme";
            this.dtmVrijeme.Size = new System.Drawing.Size(78, 20);
            this.dtmVrijeme.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum polaska";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vrijeme polaska";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Slobodna mjesta";
            // 
            // txtMjesta
            // 
            this.txtMjesta.Location = new System.Drawing.Point(269, 162);
            this.txtMjesta.Name = "txtMjesta";
            this.txtMjesta.Size = new System.Drawing.Size(78, 20);
            this.txtMjesta.TabIndex = 15;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(369, 153);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(105, 37);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(385, 109);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(78, 20);
            this.txtCijena.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cijena";
            // 
            // dgvVoznje
            // 
            this.dgvVoznje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoznje.Location = new System.Drawing.Point(12, 248);
            this.dgvVoznje.Name = "dgvVoznje";
            this.dgvVoznje.Size = new System.Drawing.Size(1190, 443);
            this.dgvVoznje.TabIndex = 19;
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(724, 126);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(75, 23);
            this.btnJson.TabIndex = 20;
            this.btnJson.Text = "button1";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // frmVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 703);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.dgvVoznje);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtMjesta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtmVrijeme);
            this.Controls.Add(this.dtmPolazak);
            this.Controls.Add(this.cmbAutomobil);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.ComboBox cmbAutomobil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmPolazak;
        private System.Windows.Forms.DateTimePicker dtmVrijeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMjesta;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvVoznje;
        private System.Windows.Forms.Button btnJson;
    }
}
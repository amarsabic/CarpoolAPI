namespace Carpool.WinUI.Izvještaji
{
    partial class frmReports
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
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.panelAktivneVoznje = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBrojAktivnihVoznji = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKorisnici = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAutomobil = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelAktivneVoznje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(32, 53);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(331, 282);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled broja vožnji po mjesecima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Statistika rezervacija po mjesecima";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(632, 53);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(331, 282);
            this.pieChart2.TabIndex = 4;
            this.pieChart2.Text = "pieChart2";
            // 
            // panelAktivneVoznje
            // 
            this.panelAktivneVoznje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAktivneVoznje.Controls.Add(this.pictureBox1);
            this.panelAktivneVoznje.Controls.Add(this.label4);
            this.panelAktivneVoznje.Controls.Add(this.labelBrojAktivnihVoznji);
            this.panelAktivneVoznje.Location = new System.Drawing.Point(12, 401);
            this.panelAktivneVoznje.Name = "panelAktivneVoznje";
            this.panelAktivneVoznje.Size = new System.Drawing.Size(280, 150);
            this.panelAktivneVoznje.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelKorisnici);
            this.panel1.Location = new System.Drawing.Point(351, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 150);
            this.panel1.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelAutomobil);
            this.panel2.Location = new System.Drawing.Point(686, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 150);
            this.panel2.TabIndex = 7;
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
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAktivneVoznje);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pieChart1);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.panelAktivneVoznje.ResumeLayout(false);
            this.panelAktivneVoznje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieChart2;
        private System.Windows.Forms.Panel panelAktivneVoznje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBrojAktivnihVoznji;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKorisnici;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelAutomobil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
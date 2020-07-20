namespace Carpool.WinUI.Korisnici
{
    partial class frmDodaj
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordStari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswordNovi = new System.Windows.Forms.TextBox();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPotvrda = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnObrisiKorisnika = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassPotvrda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtmDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(25, 55);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(195, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.ContextMenuStripChanged += new System.EventHandler(this.frmDodaj_Load);
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(258, 55);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(195, 20);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj telefona";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(25, 107);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(195, 20);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(258, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(25, 160);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(195, 20);
            this.txtKorisnickoIme.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stari password";
            // 
            // txtPasswordStari
            // 
            this.txtPasswordStari.Location = new System.Drawing.Point(25, 393);
            this.txtPasswordStari.Name = "txtPasswordStari";
            this.txtPasswordStari.PasswordChar = '*';
            this.txtPasswordStari.Size = new System.Drawing.Size(195, 20);
            this.txtPasswordStari.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Novi password";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(289, 293);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(139, 40);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Uloga";
            // 
            // txtPasswordNovi
            // 
            this.txtPasswordNovi.Location = new System.Drawing.Point(258, 393);
            this.txtPasswordNovi.Name = "txtPasswordNovi";
            this.txtPasswordNovi.PasswordChar = '*';
            this.txtPasswordNovi.Size = new System.Drawing.Size(195, 20);
            this.txtPasswordNovi.TabIndex = 12;
            // 
            // clbUloge
            // 
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(258, 160);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(195, 79);
            this.clbUloge.TabIndex = 17;
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(25, 209);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(194, 21);
            this.cmbGrad.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Grad ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Potvrda passworda";
            // 
            // txtPotvrda
            // 
            this.txtPotvrda.Location = new System.Drawing.Point(25, 436);
            this.txtPotvrda.Name = "txtPotvrda";
            this.txtPotvrda.PasswordChar = '*';
            this.txtPotvrda.Size = new System.Drawing.Size(195, 20);
            this.txtPotvrda.TabIndex = 20;
            this.txtPotvrda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(258, 436);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(132, 21);
            this.btnUpdatePassword.TabIndex = 22;
            this.btnUpdatePassword.Text = "Promijeni";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // btnObrisiKorisnika
            // 
            this.btnObrisiKorisnika.Location = new System.Drawing.Point(321, 493);
            this.btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            this.btnObrisiKorisnika.Size = new System.Drawing.Size(132, 21);
            this.btnObrisiKorisnika.TabIndex = 23;
            this.btnObrisiKorisnika.Text = "Obriši korisnika";
            this.btnObrisiKorisnika.UseVisualStyleBackColor = true;
            this.btnObrisiKorisnika.Click += new System.EventHandler(this.btnObrisiKorisnika_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Potvrda passwroda";
            // 
            // txtPassPotvrda
            // 
            this.txtPassPotvrda.Location = new System.Drawing.Point(258, 258);
            this.txtPassPotvrda.Name = "txtPassPotvrda";
            this.txtPassPotvrda.PasswordChar = '*';
            this.txtPassPotvrda.Size = new System.Drawing.Size(195, 20);
            this.txtPassPotvrda.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(25, 258);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(195, 20);
            this.txtPass.TabIndex = 24;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(25, 491);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 23);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtmDatumRodjenja
            // 
            this.dtmDatumRodjenja.Location = new System.Drawing.Point(25, 303);
            this.dtmDatumRodjenja.Name = "dtmDatumRodjenja";
            this.dtmDatumRodjenja.Size = new System.Drawing.Size(200, 20);
            this.dtmDatumRodjenja.TabIndex = 29;
            // 
            // frmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 526);
            this.Controls.Add(this.dtmDatumRodjenja);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPassPotvrda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnObrisiKorisnika);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPotvrda);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbUloge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasswordNovi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPasswordStari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "frmDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodaj";
            this.Load += new System.EventHandler(this.frmDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordStari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasswordNovi;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPotvrda;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnObrisiKorisnika;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassPotvrda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtmDatumRodjenja;
    }
}
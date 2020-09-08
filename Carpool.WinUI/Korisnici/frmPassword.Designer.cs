namespace Carpool.WinUI.Korisnici
{
    partial class frmPassword
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
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPotvrda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasswordNovi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordStari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(169)))));
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdatePassword.Location = new System.Drawing.Point(65, 204);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(132, 32);
            this.btnUpdatePassword.TabIndex = 29;
            this.btnUpdatePassword.Text = "Promijeni";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Potvrda passworda";
            // 
            // txtPotvrda
            // 
            this.txtPotvrda.Location = new System.Drawing.Point(38, 161);
            this.txtPotvrda.Name = "txtPotvrda";
            this.txtPotvrda.PasswordChar = '*';
            this.txtPotvrda.Size = new System.Drawing.Size(195, 20);
            this.txtPotvrda.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Novi password";
            // 
            // txtPasswordNovi
            // 
            this.txtPasswordNovi.Location = new System.Drawing.Point(38, 112);
            this.txtPasswordNovi.Name = "txtPasswordNovi";
            this.txtPasswordNovi.PasswordChar = '*';
            this.txtPasswordNovi.Size = new System.Drawing.Size(195, 20);
            this.txtPasswordNovi.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Stari password";
            // 
            // txtPasswordStari
            // 
            this.txtPasswordStari.Location = new System.Drawing.Point(38, 64);
            this.txtPasswordStari.Name = "txtPasswordStari";
            this.txtPasswordStari.PasswordChar = '*';
            this.txtPasswordStari.Size = new System.Drawing.Size(195, 20);
            this.txtPasswordStari.TabIndex = 23;
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 288);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPotvrda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasswordNovi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPasswordStari);
            this.Name = "frmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPotvrda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasswordNovi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordStari;
    }
}
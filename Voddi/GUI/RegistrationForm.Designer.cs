namespace GUI
{
    partial class RegistrationForm
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
            this.regiOkBtn = new System.Windows.Forms.Button();
            this.cancelRegiBtn = new System.Windows.Forms.Button();
            this.labelVorname = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.labelNachname = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtPasswordOne = new System.Windows.Forms.TextBox();
            this.labelPasswordOne = new System.Windows.Forms.Label();
            this.txtPasswordTwo = new System.Windows.Forms.TextBox();
            this.labelPasswordTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regiOkBtn
            // 
            this.regiOkBtn.Location = new System.Drawing.Point(36, 442);
            this.regiOkBtn.Name = "regiOkBtn";
            this.regiOkBtn.Size = new System.Drawing.Size(164, 48);
            this.regiOkBtn.TabIndex = 0;
            this.regiOkBtn.Text = "Registrieren";
            this.regiOkBtn.UseVisualStyleBackColor = true;
            this.regiOkBtn.Click += new System.EventHandler(this.regiOkBtn_Click);
            // 
            // cancelRegiBtn
            // 
            this.cancelRegiBtn.Location = new System.Drawing.Point(241, 442);
            this.cancelRegiBtn.Name = "cancelRegiBtn";
            this.cancelRegiBtn.Size = new System.Drawing.Size(164, 48);
            this.cancelRegiBtn.TabIndex = 1;
            this.cancelRegiBtn.Text = "Cancel";
            this.cancelRegiBtn.UseVisualStyleBackColor = true;
            this.cancelRegiBtn.Click += new System.EventHandler(this.cancelRegiBtn_Click);
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelVorname.Location = new System.Drawing.Point(29, 46);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(88, 24);
            this.labelVorname.TabIndex = 2;
            this.labelVorname.Text = "Vorname";
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtVorname.Location = new System.Drawing.Point(205, 43);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(210, 29);
            this.txtVorname.TabIndex = 3;
            // 
            // txtNachname
            // 
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNachname.Location = new System.Drawing.Point(205, 100);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(210, 29);
            this.txtNachname.TabIndex = 5;
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelNachname.Location = new System.Drawing.Point(29, 103);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(103, 24);
            this.labelNachname.TabIndex = 4;
            this.labelNachname.Text = "Nachname";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtMail.Location = new System.Drawing.Point(205, 153);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(210, 29);
            this.txtMail.TabIndex = 7;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelMail.Location = new System.Drawing.Point(29, 156);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(63, 24);
            this.labelMail.TabIndex = 6;
            this.labelMail.Text = "E-Mail";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUsername.Location = new System.Drawing.Point(205, 213);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 29);
            this.txtUsername.TabIndex = 9;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelUsername.Location = new System.Drawing.Point(29, 216);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 24);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // txtPasswordOne
            // 
            this.txtPasswordOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPasswordOne.Location = new System.Drawing.Point(205, 262);
            this.txtPasswordOne.Name = "txtPasswordOne";
            this.txtPasswordOne.PasswordChar = '*';
            this.txtPasswordOne.Size = new System.Drawing.Size(210, 29);
            this.txtPasswordOne.TabIndex = 11;
            // 
            // labelPasswordOne
            // 
            this.labelPasswordOne.AutoSize = true;
            this.labelPasswordOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelPasswordOne.Location = new System.Drawing.Point(29, 265);
            this.labelPasswordOne.Name = "labelPasswordOne";
            this.labelPasswordOne.Size = new System.Drawing.Size(85, 24);
            this.labelPasswordOne.TabIndex = 10;
            this.labelPasswordOne.Text = "Passwort";
            // 
            // txtPasswordTwo
            // 
            this.txtPasswordTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPasswordTwo.Location = new System.Drawing.Point(205, 318);
            this.txtPasswordTwo.Name = "txtPasswordTwo";
            this.txtPasswordTwo.PasswordChar = '*';
            this.txtPasswordTwo.Size = new System.Drawing.Size(210, 29);
            this.txtPasswordTwo.TabIndex = 13;
            // 
            // labelPasswordTwo
            // 
            this.labelPasswordTwo.AutoSize = true;
            this.labelPasswordTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelPasswordTwo.Location = new System.Drawing.Point(29, 321);
            this.labelPasswordTwo.Name = "labelPasswordTwo";
            this.labelPasswordTwo.Size = new System.Drawing.Size(100, 24);
            this.labelPasswordTwo.TabIndex = 12;
            this.labelPasswordTwo.Text = "Passwort 2";
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 519);
            this.Controls.Add(this.txtPasswordTwo);
            this.Controls.Add(this.labelPasswordTwo);
            this.Controls.Add(this.txtPasswordOne);
            this.Controls.Add(this.labelPasswordOne);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.labelNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.cancelRegiBtn);
            this.Controls.Add(this.regiOkBtn);
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regiOkBtn;
        private System.Windows.Forms.Button cancelRegiBtn;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtPasswordOne;
        private System.Windows.Forms.Label labelPasswordOne;
        private System.Windows.Forms.TextBox txtPasswordTwo;
        private System.Windows.Forms.Label labelPasswordTwo;
    }
}
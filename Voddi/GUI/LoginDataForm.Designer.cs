namespace GUI
{
    partial class LoginDataForm
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
            this.loginUsernameField = new System.Windows.Forms.TextBox();
            this.loginPasswordField = new System.Windows.Forms.TextBox();
            this.loginDataBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginUsernameField
            // 
            this.loginUsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.loginUsernameField.Location = new System.Drawing.Point(36, 21);
            this.loginUsernameField.Multiline = true;
            this.loginUsernameField.Name = "loginUsernameField";
            this.loginUsernameField.Size = new System.Drawing.Size(312, 39);
            this.loginUsernameField.TabIndex = 0;
            // 
            // loginPasswordField
            // 
            this.loginPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.loginPasswordField.Location = new System.Drawing.Point(36, 66);
            this.loginPasswordField.Multiline = true;
            this.loginPasswordField.Name = "loginPasswordField";
            this.loginPasswordField.PasswordChar = '*';
            this.loginPasswordField.Size = new System.Drawing.Size(312, 39);
            this.loginPasswordField.TabIndex = 1;
            // 
            // loginDataBtn
            // 
            this.loginDataBtn.Location = new System.Drawing.Point(36, 135);
            this.loginDataBtn.Name = "loginDataBtn";
            this.loginDataBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginDataBtn.Size = new System.Drawing.Size(137, 39);
            this.loginDataBtn.TabIndex = 2;
            this.loginDataBtn.Text = "Anmelden";
            this.loginDataBtn.UseVisualStyleBackColor = true;
            this.loginDataBtn.Click += new System.EventHandler(this.loginDataBtn_Click);
            this.loginDataBtn.Enter += new System.EventHandler(this.loginDataBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(211, 135);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelBtn.Size = new System.Drawing.Size(137, 39);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 186);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginDataBtn);
            this.Controls.Add(this.loginPasswordField);
            this.Controls.Add(this.loginUsernameField);
            this.Name = "loginDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginDataForm";
            this.Enter += new System.EventHandler(this.loginDataBtn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();

        }

        #endregion

        private System.Windows.Forms.TextBox loginUsernameField;
        private System.Windows.Forms.TextBox loginPasswordField;
        private System.Windows.Forms.Button loginDataBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
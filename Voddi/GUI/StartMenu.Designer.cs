namespace GUI
{
    partial class StartMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_Btn = new System.Windows.Forms.Button();
            this.reg_Btn = new System.Windows.Forms.Button();
            this.close_Btn = new System.Windows.Forms.Button();
            this.dbConnection = new System.Windows.Forms.Label();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_Btn
            // 
            this.login_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Btn.Location = new System.Drawing.Point(373, 178);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(225, 48);
            this.login_Btn.TabIndex = 0;
            this.login_Btn.Text = "Anmeldung";
            this.login_Btn.UseVisualStyleBackColor = true;
            this.login_Btn.Click += new System.EventHandler(this.Login_Btn_Click_1);
            // 
            // reg_Btn
            // 
            this.reg_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reg_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Btn.Location = new System.Drawing.Point(373, 269);
            this.reg_Btn.Name = "reg_Btn";
            this.reg_Btn.Size = new System.Drawing.Size(225, 48);
            this.reg_Btn.TabIndex = 1;
            this.reg_Btn.Text = "Registrieren";
            this.reg_Btn.UseVisualStyleBackColor = true;
            this.reg_Btn.Click += new System.EventHandler(this.reg_Btn_Click);
            // 
            // close_Btn
            // 
            this.close_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.close_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Btn.Location = new System.Drawing.Point(373, 365);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.Size = new System.Drawing.Size(225, 48);
            this.close_Btn.TabIndex = 2;
            this.close_Btn.Text = "Beenden";
            this.close_Btn.UseVisualStyleBackColor = true;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // dbConnection
            // 
            this.dbConnection.AutoSize = true;
            this.dbConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbConnection.Location = new System.Drawing.Point(13, 13);
            this.dbConnection.Name = "dbConnection";
            this.dbConnection.Size = new System.Drawing.Size(189, 37);
            this.dbConnection.TabIndex = 3;
            this.dbConnection.Text = "Connection";
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.gameTitleLabel.Location = new System.Drawing.Point(439, 100);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(185, 52);
            this.gameTitleLabel.TabIndex = 4;
            this.gameTitleLabel.Text = "GameTitle";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 539);
            this.Controls.Add(this.gameTitleLabel);
            this.Controls.Add(this.dbConnection);
            this.Controls.Add(this.close_Btn);
            this.Controls.Add(this.reg_Btn);
            this.Controls.Add(this.login_Btn);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Button reg_Btn;
        private System.Windows.Forms.Button close_Btn;
        private System.Windows.Forms.Label dbConnection;
        private System.Windows.Forms.Label gameTitleLabel;
    }
}


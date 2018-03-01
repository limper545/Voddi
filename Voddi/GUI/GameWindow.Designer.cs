namespace GUI
{
    partial class GameWindow
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
            this.CharacterDetails = new System.Windows.Forms.Button();
            this.fightBtn = new System.Windows.Forms.Button();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharacterDetails
            // 
            this.CharacterDetails.Location = new System.Drawing.Point(451, 96);
            this.CharacterDetails.Margin = new System.Windows.Forms.Padding(2);
            this.CharacterDetails.Name = "CharacterDetails";
            this.CharacterDetails.Size = new System.Drawing.Size(56, 19);
            this.CharacterDetails.TabIndex = 0;
            this.CharacterDetails.Text = "Details";
            this.CharacterDetails.UseVisualStyleBackColor = true;
            this.CharacterDetails.Click += new System.EventHandler(this.CharacterDetails_Click);
            // 
            // fightBtn
            // 
            this.fightBtn.Location = new System.Drawing.Point(118, 178);
            this.fightBtn.Name = "fightBtn";
            this.fightBtn.Size = new System.Drawing.Size(75, 23);
            this.fightBtn.TabIndex = 1;
            this.fightBtn.Text = "Kämpfen";
            this.fightBtn.UseVisualStyleBackColor = true;
            this.fightBtn.Click += new System.EventHandler(this.fightBtn_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.LogoutLabel.Location = new System.Drawing.Point(627, 19);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(0, 20);
            this.LogoutLabel.TabIndex = 2;
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.fightBtn);
            this.Controls.Add(this.CharacterDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CharacterDetails;
        private System.Windows.Forms.Button fightBtn;
        private System.Windows.Forms.Label LogoutLabel;
    }
}
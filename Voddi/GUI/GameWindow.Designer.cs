﻿namespace GUI
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
            this.SuspendLayout();
            // 
            // CharacterDetails
            // 
            this.CharacterDetails.Location = new System.Drawing.Point(601, 118);
            this.CharacterDetails.Name = "CharacterDetails";
            this.CharacterDetails.Size = new System.Drawing.Size(75, 23);
            this.CharacterDetails.TabIndex = 0;
            this.CharacterDetails.Text = "Details";
            this.CharacterDetails.UseVisualStyleBackColor = true;
            this.CharacterDetails.Click += new System.EventHandler(this.CharacterDetails_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.CharacterDetails);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CharacterDetails;
    }
}
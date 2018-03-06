namespace BaB.GUI.Game
{
    partial class GameMenu
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
            this.charOneBtn = new System.Windows.Forms.Button();
            this.charTwoBtn = new System.Windows.Forms.Button();
            this.charThreeBtn = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // charOneBtn
            // 
            this.charOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.charOneBtn.Location = new System.Drawing.Point(309, 84);
            this.charOneBtn.Name = "charOneBtn";
            this.charOneBtn.Size = new System.Drawing.Size(384, 78);
            this.charOneBtn.TabIndex = 0;
            this.charOneBtn.UseVisualStyleBackColor = true;
            this.charOneBtn.Click += new System.EventHandler(this.charOneBtn_Click);
            // 
            // charTwoBtn
            // 
            this.charTwoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.charTwoBtn.Location = new System.Drawing.Point(309, 250);
            this.charTwoBtn.Name = "charTwoBtn";
            this.charTwoBtn.Size = new System.Drawing.Size(384, 78);
            this.charTwoBtn.TabIndex = 1;
            this.charTwoBtn.UseVisualStyleBackColor = true;
            this.charTwoBtn.Click += new System.EventHandler(this.charTwoBtn_Click);
            // 
            // charThreeBtn
            // 
            this.charThreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.charThreeBtn.Location = new System.Drawing.Point(309, 419);
            this.charThreeBtn.Name = "charThreeBtn";
            this.charThreeBtn.Size = new System.Drawing.Size(384, 78);
            this.charThreeBtn.TabIndex = 2;
            this.charThreeBtn.UseVisualStyleBackColor = true;
            this.charThreeBtn.Click += new System.EventHandler(this.charThreeBtn_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.labelWelcome.Location = new System.Drawing.Point(23, 17);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 38);
            this.labelWelcome.TabIndex = 3;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::BaB.GUI.Properties.Resources.pirates_rock_castle_bird_mountain;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.charThreeBtn);
            this.Controls.Add(this.charTwoBtn);
            this.Controls.Add(this.charOneBtn);
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button charOneBtn;
        private System.Windows.Forms.Button charTwoBtn;
        private System.Windows.Forms.Button charThreeBtn;
        private System.Windows.Forms.Label labelWelcome;
    }
}
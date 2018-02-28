namespace GUI
{
    partial class checkForPatch
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
            this.patchBar = new System.Windows.Forms.ProgressBar();
            this.testBtn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checking for Updates";
            // 
            // patchBar
            // 
            this.patchBar.Location = new System.Drawing.Point(41, 63);
            this.patchBar.Name = "patchBar";
            this.patchBar.Size = new System.Drawing.Size(418, 23);
            this.patchBar.TabIndex = 1;
            // 
            // testBtn_Start
            // 
            this.testBtn_Start.Location = new System.Drawing.Point(194, 96);
            this.testBtn_Start.Name = "testBtn_Start";
            this.testBtn_Start.Size = new System.Drawing.Size(102, 38);
            this.testBtn_Start.TabIndex = 2;
            this.testBtn_Start.Text = "Ok";
            this.testBtn_Start.UseVisualStyleBackColor = true;
            this.testBtn_Start.Click += new System.EventHandler(this.testBtn_Start_Click);
            // 
            // checkForPatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 146);
            this.Controls.Add(this.testBtn_Start);
            this.Controls.Add(this.patchBar);
            this.Controls.Add(this.label1);
            this.Name = "checkForPatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkForPatch";
            this.Load += new System.EventHandler(this.checkForPatch_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar patchBar;
        private System.Windows.Forms.Button testBtn_Start;
    }
}
namespace GUI
{
    partial class DetailsCharacter
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CharacterImagePanel = new System.Windows.Forms.Panel();
            this.ExpValues = new System.Windows.Forms.Label();
            this.LabelEXPName = new System.Windows.Forms.Label();
            this.ExpBar = new System.Windows.Forms.ProgressBar();
            this.CharacterStatusInventory = new System.Windows.Forms.Panel();
            this.CharacterStatus = new System.Windows.Forms.Panel();
            this.RExpLabelValue = new System.Windows.Forms.Label();
            this.RExpLabelName = new System.Windows.Forms.Label();
            this.SPDLabelValue = new System.Windows.Forms.Label();
            this.SPDLabelName = new System.Windows.Forms.Label();
            this.DefLabelValue = new System.Windows.Forms.Label();
            this.DefLabelName = new System.Windows.Forms.Label();
            this.ManaLabelValue = new System.Windows.Forms.Label();
            this.ManaLabelName = new System.Windows.Forms.Label();
            this.ATKLabelValue = new System.Windows.Forms.Label();
            this.ATKLabelName = new System.Windows.Forms.Label();
            this.EXPLabelValue = new System.Windows.Forms.Label();
            this.EXPLabelName = new System.Windows.Forms.Label();
            this.HPLabelValue = new System.Windows.Forms.Label();
            this.LevelLabelValue = new System.Windows.Forms.Label();
            this.HPLabelName = new System.Windows.Forms.Label();
            this.LevelLabelName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CharacterStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 697);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CharacterImagePanel);
            this.tabPage1.Controls.Add(this.ExpValues);
            this.tabPage1.Controls.Add(this.LabelEXPName);
            this.tabPage1.Controls.Add(this.ExpBar);
            this.tabPage1.Controls.Add(this.CharacterStatusInventory);
            this.tabPage1.Controls.Add(this.CharacterStatus);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabPage1.Location = new System.Drawing.Point(4, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CharacterImagePanel
            // 
            this.CharacterImagePanel.Location = new System.Drawing.Point(322, 6);
            this.CharacterImagePanel.Name = "CharacterImagePanel";
            this.CharacterImagePanel.Size = new System.Drawing.Size(324, 607);
            this.CharacterImagePanel.TabIndex = 2;
            // 
            // ExpValues
            // 
            this.ExpValues.AutoSize = true;
            this.ExpValues.Location = new System.Drawing.Point(475, 621);
            this.ExpValues.Name = "ExpValues";
            this.ExpValues.Size = new System.Drawing.Size(0, 17);
            this.ExpValues.TabIndex = 4;
            // 
            // LabelEXPName
            // 
            this.LabelEXPName.AutoSize = true;
            this.LabelEXPName.Location = new System.Drawing.Point(424, 621);
            this.LabelEXPName.Name = "LabelEXPName";
            this.LabelEXPName.Size = new System.Drawing.Size(39, 17);
            this.LabelEXPName.TabIndex = 3;
            this.LabelEXPName.Text = "EXP:";
            // 
            // ExpBar
            // 
            this.ExpBar.Location = new System.Drawing.Point(-4, 620);
            this.ExpBar.Name = "ExpBar";
            this.ExpBar.Size = new System.Drawing.Size(982, 19);
            this.ExpBar.TabIndex = 2;
            // 
            // CharacterStatusInventory
            // 
            this.CharacterStatusInventory.Location = new System.Drawing.Point(6, 6);
            this.CharacterStatusInventory.Name = "CharacterStatusInventory";
            this.CharacterStatusInventory.Size = new System.Drawing.Size(310, 607);
            this.CharacterStatusInventory.TabIndex = 1;
            // 
            // CharacterStatus
            // 
            this.CharacterStatus.Controls.Add(this.RExpLabelValue);
            this.CharacterStatus.Controls.Add(this.RExpLabelName);
            this.CharacterStatus.Controls.Add(this.SPDLabelValue);
            this.CharacterStatus.Controls.Add(this.SPDLabelName);
            this.CharacterStatus.Controls.Add(this.DefLabelValue);
            this.CharacterStatus.Controls.Add(this.DefLabelName);
            this.CharacterStatus.Controls.Add(this.ManaLabelValue);
            this.CharacterStatus.Controls.Add(this.ManaLabelName);
            this.CharacterStatus.Controls.Add(this.ATKLabelValue);
            this.CharacterStatus.Controls.Add(this.ATKLabelName);
            this.CharacterStatus.Controls.Add(this.EXPLabelValue);
            this.CharacterStatus.Controls.Add(this.EXPLabelName);
            this.CharacterStatus.Controls.Add(this.HPLabelValue);
            this.CharacterStatus.Controls.Add(this.LevelLabelValue);
            this.CharacterStatus.Controls.Add(this.HPLabelName);
            this.CharacterStatus.Controls.Add(this.LevelLabelName);
            this.CharacterStatus.Location = new System.Drawing.Point(652, 6);
            this.CharacterStatus.Name = "CharacterStatus";
            this.CharacterStatus.Size = new System.Drawing.Size(319, 607);
            this.CharacterStatus.TabIndex = 0;
            this.CharacterStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.CharacterStatus_Paint);
            // 
            // RExpLabelValue
            // 
            this.RExpLabelValue.AutoSize = true;
            this.RExpLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RExpLabelValue.Location = new System.Drawing.Point(160, 211);
            this.RExpLabelValue.Name = "RExpLabelValue";
            this.RExpLabelValue.Size = new System.Drawing.Size(79, 29);
            this.RExpLabelValue.TabIndex = 15;
            this.RExpLabelValue.Text = "label2";
            // 
            // RExpLabelName
            // 
            this.RExpLabelName.AutoSize = true;
            this.RExpLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RExpLabelName.Location = new System.Drawing.Point(39, 211);
            this.RExpLabelName.Name = "RExpLabelName";
            this.RExpLabelName.Size = new System.Drawing.Size(79, 29);
            this.RExpLabelName.TabIndex = 14;
            this.RExpLabelName.Text = "label1";
            // 
            // SPDLabelValue
            // 
            this.SPDLabelValue.AutoSize = true;
            this.SPDLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SPDLabelValue.Location = new System.Drawing.Point(160, 509);
            this.SPDLabelValue.Name = "SPDLabelValue";
            this.SPDLabelValue.Size = new System.Drawing.Size(79, 29);
            this.SPDLabelValue.TabIndex = 13;
            this.SPDLabelValue.Text = "label7";
            // 
            // SPDLabelName
            // 
            this.SPDLabelName.AutoSize = true;
            this.SPDLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SPDLabelName.Location = new System.Drawing.Point(39, 509);
            this.SPDLabelName.Name = "SPDLabelName";
            this.SPDLabelName.Size = new System.Drawing.Size(79, 29);
            this.SPDLabelName.TabIndex = 12;
            this.SPDLabelName.Text = "label8";
            // 
            // DefLabelValue
            // 
            this.DefLabelValue.AutoSize = true;
            this.DefLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DefLabelValue.Location = new System.Drawing.Point(160, 452);
            this.DefLabelValue.Name = "DefLabelValue";
            this.DefLabelValue.Size = new System.Drawing.Size(79, 29);
            this.DefLabelValue.TabIndex = 11;
            this.DefLabelValue.Text = "label5";
            // 
            // DefLabelName
            // 
            this.DefLabelName.AutoSize = true;
            this.DefLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DefLabelName.Location = new System.Drawing.Point(39, 452);
            this.DefLabelName.Name = "DefLabelName";
            this.DefLabelName.Size = new System.Drawing.Size(79, 29);
            this.DefLabelName.TabIndex = 10;
            this.DefLabelName.Text = "label6";
            // 
            // ManaLabelValue
            // 
            this.ManaLabelValue.AutoSize = true;
            this.ManaLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ManaLabelValue.Location = new System.Drawing.Point(160, 390);
            this.ManaLabelValue.Name = "ManaLabelValue";
            this.ManaLabelValue.Size = new System.Drawing.Size(79, 29);
            this.ManaLabelValue.TabIndex = 9;
            this.ManaLabelValue.Text = "label3";
            // 
            // ManaLabelName
            // 
            this.ManaLabelName.AutoSize = true;
            this.ManaLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ManaLabelName.Location = new System.Drawing.Point(39, 390);
            this.ManaLabelName.Name = "ManaLabelName";
            this.ManaLabelName.Size = new System.Drawing.Size(79, 29);
            this.ManaLabelName.TabIndex = 8;
            this.ManaLabelName.Text = "label4";
            // 
            // ATKLabelValue
            // 
            this.ATKLabelValue.AutoSize = true;
            this.ATKLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ATKLabelValue.Location = new System.Drawing.Point(160, 330);
            this.ATKLabelValue.Name = "ATKLabelValue";
            this.ATKLabelValue.Size = new System.Drawing.Size(79, 29);
            this.ATKLabelValue.TabIndex = 7;
            this.ATKLabelValue.Text = "label2";
            // 
            // ATKLabelName
            // 
            this.ATKLabelName.AutoSize = true;
            this.ATKLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ATKLabelName.Location = new System.Drawing.Point(39, 330);
            this.ATKLabelName.Name = "ATKLabelName";
            this.ATKLabelName.Size = new System.Drawing.Size(79, 29);
            this.ATKLabelName.TabIndex = 6;
            this.ATKLabelName.Text = "label1";
            // 
            // EXPLabelValue
            // 
            this.EXPLabelValue.AutoSize = true;
            this.EXPLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EXPLabelValue.Location = new System.Drawing.Point(160, 152);
            this.EXPLabelValue.Name = "EXPLabelValue";
            this.EXPLabelValue.Size = new System.Drawing.Size(79, 29);
            this.EXPLabelValue.TabIndex = 5;
            this.EXPLabelValue.Text = "label2";
            // 
            // EXPLabelName
            // 
            this.EXPLabelName.AutoSize = true;
            this.EXPLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EXPLabelName.Location = new System.Drawing.Point(39, 152);
            this.EXPLabelName.Name = "EXPLabelName";
            this.EXPLabelName.Size = new System.Drawing.Size(79, 29);
            this.EXPLabelName.TabIndex = 4;
            this.EXPLabelName.Text = "label1";
            // 
            // HPLabelValue
            // 
            this.HPLabelValue.AutoSize = true;
            this.HPLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HPLabelValue.Location = new System.Drawing.Point(160, 93);
            this.HPLabelValue.Name = "HPLabelValue";
            this.HPLabelValue.Size = new System.Drawing.Size(79, 29);
            this.HPLabelValue.TabIndex = 3;
            this.HPLabelValue.Text = "label1";
            // 
            // LevelLabelValue
            // 
            this.LevelLabelValue.AutoSize = true;
            this.LevelLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LevelLabelValue.Location = new System.Drawing.Point(160, 32);
            this.LevelLabelValue.Name = "LevelLabelValue";
            this.LevelLabelValue.Size = new System.Drawing.Size(79, 29);
            this.LevelLabelValue.TabIndex = 2;
            this.LevelLabelValue.Text = "label1";
            // 
            // HPLabelName
            // 
            this.HPLabelName.AutoSize = true;
            this.HPLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HPLabelName.Location = new System.Drawing.Point(39, 93);
            this.HPLabelName.Name = "HPLabelName";
            this.HPLabelName.Size = new System.Drawing.Size(79, 29);
            this.HPLabelName.TabIndex = 1;
            this.HPLabelName.Text = "label1";
            // 
            // LevelLabelName
            // 
            this.LevelLabelName.AutoSize = true;
            this.LevelLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LevelLabelName.Location = new System.Drawing.Point(39, 32);
            this.LevelLabelName.Name = "LevelLabelName";
            this.LevelLabelName.Size = new System.Drawing.Size(79, 29);
            this.LevelLabelName.TabIndex = 0;
            this.LevelLabelName.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.tabPage2.Location = new System.Drawing.Point(4, 51);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DetailsCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tabControl1);
            this.Name = "DetailsCharacter";
            this.Text = "DetailsCharacter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CharacterStatus.ResumeLayout(false);
            this.CharacterStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar ExpBar;
        private System.Windows.Forms.Panel CharacterStatusInventory;
        private System.Windows.Forms.Panel CharacterStatus;
        private System.Windows.Forms.Label LabelEXPName;
        private System.Windows.Forms.Label ExpValues;
        private System.Windows.Forms.Label SPDLabelValue;
        private System.Windows.Forms.Label SPDLabelName;
        private System.Windows.Forms.Label DefLabelValue;
        private System.Windows.Forms.Label DefLabelName;
        private System.Windows.Forms.Label ManaLabelValue;
        private System.Windows.Forms.Label ManaLabelName;
        private System.Windows.Forms.Label ATKLabelValue;
        private System.Windows.Forms.Label ATKLabelName;
        private System.Windows.Forms.Label EXPLabelValue;
        private System.Windows.Forms.Label EXPLabelName;
        private System.Windows.Forms.Label HPLabelValue;
        private System.Windows.Forms.Label LevelLabelValue;
        private System.Windows.Forms.Label HPLabelName;
        private System.Windows.Forms.Label LevelLabelName;
        private System.Windows.Forms.Label RExpLabelValue;
        private System.Windows.Forms.Label RExpLabelName;
        private System.Windows.Forms.Panel CharacterImagePanel;
    }
}
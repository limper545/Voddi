namespace GUI
{
    partial class CreateCharacter
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
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createCharBtn = new System.Windows.Forms.Button();
            this.charNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(157, 96);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 28);
            this.classComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klasse";
            // 
            // createCharBtn
            // 
            this.createCharBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.createCharBtn.Location = new System.Drawing.Point(89, 159);
            this.createCharBtn.Name = "createCharBtn";
            this.createCharBtn.Size = new System.Drawing.Size(153, 44);
            this.createCharBtn.TabIndex = 3;
            this.createCharBtn.Text = "Create";
            this.createCharBtn.UseVisualStyleBackColor = true;
            this.createCharBtn.Click += new System.EventHandler(this.createCharBtn_Click_1);
            // 
            // charNameBox
            // 
            this.charNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.charNameBox.Location = new System.Drawing.Point(157, 41);
            this.charNameBox.Name = "charNameBox";
            this.charNameBox.Size = new System.Drawing.Size(120, 26);
            this.charNameBox.TabIndex = 4;
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 215);
            this.Controls.Add(this.charNameBox);
            this.Controls.Add(this.createCharBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classComboBox);
            this.Name = "CreateCharacter";
            this.Text = "CreateCharacter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createCharBtn;
        private System.Windows.Forms.TextBox charNameBox;
        private System.Windows.Forms.ComboBox classComboBox;
    }
}
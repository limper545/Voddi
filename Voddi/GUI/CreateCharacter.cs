using System;
using DBHandler;
using System.Windows.Forms;
using System.Collections.Generic;
using Core;

namespace GUI
{
    public partial class CreateCharacter : Form
    {
        public String username;
        public CreateCharacter(string username)
        {
            this.username = username;
            InitializeComponent();
            FillClassField();
        }

        private void FillClassField()
        {
            List<Classes> listClasses = Handler.GetAllClasses();
            foreach (var item in listClasses) {
                classComboBox.ValueMember = item.ID.ToString();
                classComboBox.Items.Add(item.Name); 
            }
                
        }

        private void CreateCharBtn_Click_1(object sender, EventArgs e)
        {
            // ValueMember
            Handler.CreateCharacterForAUser(charNameBox.Text, classComboBox.Text, username);
        }
    }
}

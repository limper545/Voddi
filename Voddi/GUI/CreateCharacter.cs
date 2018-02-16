using System;
using DBHandler;
using System.Windows.Forms;
using DBHandler;
using System.Collections.Generic;

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
            List<String> listClasses = Handler.GetAllClasses();
            foreach (var item in listClasses) { classComboBox.Items.Add(item); }
                
        }

        private void CreateCharBtn_Click_1(object sender, EventArgs e)
        {
            Handler.CreateCharacterForAUser(charNameBox.Text, classComboBox.Text, username);
        }
    }
}

using System;
using System.ComponentModel;
using System.Windows.Forms;
using DBHandler;
using System.Collections.Generic;

namespace GUI
{
    public partial class CreateCharacter : Form
    {
        public string username;
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

        private void createCharBtn_Click_1(object sender, EventArgs e)
        {
            string charName = charNameBox.Text;
            string charClass = classComboBox.Text;
        }
    }
}

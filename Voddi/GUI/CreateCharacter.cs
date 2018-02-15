using Bab_1.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateCharacter : Form
    {
        public string username;
        public CreateCharacter(string username)
        {
            this.username = username;
            InitializeComponent();
           // ArrayList charList = DBHandler.GetAllClasses();
            FillClassField(charList);
        }

        private void FillClassField(ArrayList list)
        {
            foreach (var item in list)
            {
                classComboBox.Items.Add(item);
            }
        }

        private void createCharBtn_Click_1(object sender, EventArgs e)
        {
            string charName = charNameBox.Text;
            string charClass = classComboBox.Text;
        }
    }
}

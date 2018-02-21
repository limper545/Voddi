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
        public User u;
        public CreateCharacter(User username)
        {
            this.u = username;
            InitializeComponent();
            FillClassField();
        }

        private void FillClassField()
        {
            foreach (var item in Handler.GetAllClasses()) {
                classComboBox.ValueMember = item.ID.ToString();
                classComboBox.Items.Add(item: item.Name); 
            }
                
        }

        private void CreateCharBtn_Click_1(object sender, EventArgs e)
        {
            if(!Handler.CreateCharacterForAUser(charNameBox.Text, classComboBox.ValueMember, u.ID.ToString()))
            {
                MessageBox.Show("Character " + charNameBox.Text + " erfolgreich erstellt." , "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler beim erstellen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
    }
}

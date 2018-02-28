using System;
using DBHandler;
using System.Windows.Forms;
using System.Collections.Generic;
using Core;
using System.Diagnostics.Contracts;

namespace GUI
{
    public partial class CreateCharacter : Form
    {
        string username;

        User u;

        public User U => u;

        public string Username { get => username; set => username = value; }

        public CreateCharacter(User username)
        {
            Contract.Requires(username != null);
            u = username ?? throw new ArgumentNullException(nameof(username));
            InitializeComponent();
            FillClassField();
        }

        /// <summary>
        /// Füllt das Dropdown Feld mit dem Klassen aus der DB
        /// </summary>
        void FillClassField()
        {
            classComboBox.DisplayMember = "Name";
            classComboBox.ValueMember = "Value";
            for (int i = 0, maxCount = Handler.GetAllClasses().Count; i < maxCount; i++)
            {
                var item = Handler.GetAllClasses()[i];
                classComboBox.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Startet den CreateCharacter for User im Backend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CreateCharBtn_Click_1(object sender, EventArgs e)
        {
            if(Handler.CreateCharacterForAUser(charNameBox.Text, (classComboBox.SelectedIndex + 1).ToString(), u.ID.ToString()))
            {
                MessageBox.Show($"Character {charNameBox.Text} erfolgreich erstellt.", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Fehler beim erstellen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            
    }
}

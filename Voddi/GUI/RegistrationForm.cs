using BaB_1._0.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaB_1._0.GUI
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void cancelRegiBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie wirklich die Registrierung beenden?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void regiOkBtn_Click(object sender, EventArgs e)
        {
            string vorname = txtVorname.Text;
            string nachname = txtNachname.Text;
            string email = txtMail.Text;
            string username = txtUsername.Text;
            string passwordOne = txtPasswordOne.Text;
            string passwordTwo = txtPasswordTwo.Text;

            if (passwordOne == passwordTwo)
            {
                string responseValidation = Validations.CheckRegistrationValidation(vorname, nachname, email, username, passwordOne, passwordTwo);
                if (responseValidation == "OK")
                {
                    if (Validations.CorrectEmailFormat(email))
                    {
                        if (Validations.UserNotExists(username))
                        {
                            if (Registration.CreateNewUser(vorname, nachname, email, username, passwordOne))
                            {
                                MessageBox.Show("Registrierung erfolgreich", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Fehler beim registrieren, versuchen Sie es erneut", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Benutzername bereits vorhanden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Keine gültige E-Mail Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                    MessageBox.Show(responseValidation + " darf nich leer sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Passwörter sind nicht identisch.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordOne.Invalidate();
                txtPasswordTwo.Invalidate();
            }
        }
    }
}

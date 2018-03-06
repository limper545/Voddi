
using System;
using System.Windows.Forms;
namespace BaB.GUI.Menu
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bricht die Registrierung ab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cancelRegiBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Wollen Sie wirklich die Registrierung beenden?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Startet die Registrierung und die Validierung im Backend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void regiOkBtn_Click(object sender, EventArgs e)
        {
            var vorname = txtVorname.Text;
            var nachname = txtNachname.Text;
            var email = txtMail.Text;
            var username = txtUsername.Text;
            var passwordOne = txtPasswordOne.Text;
            var passwordTwo = txtPasswordTwo.Text;

            //if (passwordOne == passwordTwo)
            //{
            //    var responseValidation = Validations.CheckRegistrationValidation(vorname, nachname, email, username, passwordOne, passwordTwo);
            //    if (responseValidation == "OK")
            //    {
            //        if (Validations.CorrectEmailFormat(email))
            //        {
            //            if (!Validations.UserNotExists(username))
            //            {
            //                if (Registration.CreateNewUser(vorname, nachname, email, username, passwordOne))
            //                {
            //                    MessageBox.Show("Registrierung erfolgreich", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    this.Close();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Fehler beim registrieren, versuchen Sie es erneut", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }

            //            }
            //            else
            //            {
            //                MessageBox.Show("Benutzername bereits vorhanden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }


            //        }
            //        else
            //        {
            //            MessageBox.Show("Keine gültige E-Mail Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            //    }
            //    else
            //    {

            //        MessageBox.Show(responseValidation + " darf nich leer sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Passwörter sind nicht identisch.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtPasswordOne.Invalidate();
            //    txtPasswordTwo.Invalidate();
            //}
        }
    }
}

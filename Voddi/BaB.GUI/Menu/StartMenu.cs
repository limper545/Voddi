using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaB.GUI.Menu
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            gameTitleLabel.Text = "BaB";
            gameTitleLabel.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Schlißet das Startmenu beim klicken auf Beenden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void close_Btn_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// Öffnet das Fenster um sich anzumelden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Login_Btn_Click_1(object sender, EventArgs e)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Öffnet das Fenster um sich zu registrieren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void reg_Btn_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException();
        }
    }
}

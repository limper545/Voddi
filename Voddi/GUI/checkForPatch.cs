using System;
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
    public partial class checkForPatch : Form
    {
        public string username;
        public checkForPatch(String username)
        {
            this.username = username;
            InitializeComponent();
        }
        private void checkForPatch_Load(object sender, EventArgs e)
        {
            patchBar.Maximum = 100;
            patchBar.Step = 10;
            patchBar.Value = 0;
            for (int i = 0; i < 10; i++)
            {
                patchBar.Value += 10;
            }
            /* if (patchBar.Value == 100)
             {
                 MessageBox.Show("Es wurden keine neuen Updates gefunden", "Patcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
             }*/
        }

        private void testBtn_Start_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

          //  LoadingScreen game = new LoadingScreen(username);
            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }

            foreach (Form f in openForms)
            {
                if (f.Name != "LoadingScreen" && f.Name != "StartMenu")
                {
                    f.Close();
                }
                else if (f.Name == "StartMenu")
                {
                    f.Hide();
                }

               // game.Show();

            }
        }
    }
}

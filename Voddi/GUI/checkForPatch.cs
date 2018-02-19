using System;
using System.Collections.Generic;
using Core;
using System.Windows.Forms;

namespace GUI
{
    public partial class checkForPatch : Form
    {
        public string username;
        public User u;
        public checkForPatch(User username)
        {
            this.u = username;
            InitializeComponent();
        }
        private void checkForPatch_Load(object sender, EventArgs e)
        {
            patchBar.Maximum = 100;
            patchBar.Step = 10;
            patchBar.Value = 0;
            for (int i = 0; i < 10; i++) { patchBar.Value += 10; }

            /* if (patchBar.Value == 100)
             {
                 MessageBox.Show("Es wurden keine neuen Updates gefunden", "Patcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
             }*/
        }

        private void testBtn_Start_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            new LoadingScreen(u).Show();
            foreach (Form f in Application.OpenForms) { openForms.Add(f); }

            openForms.ForEach(f =>
            {
                if (f.Name != "LoadingScreen" && f.Name != "StartMenu")
                {
                    f.Close();
                }
                else if (f.Name == "StartMenu")
                {
                    f.Hide();
                }
            });
        }
    }
}

using System;
using System.Collections.Generic;
using Core;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

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
        private async void checkForPatch_Load(object sender, EventArgs e)
        {
            patchBar.Maximum = 100;
            patchBar.Value = 50;
            testBtn_Start.Enabled = false;
            await CheckIfPatchIsThereAsync();

        }

        private async Task CheckIfPatchIsThereAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            patchBar.Value = 100;
            if (File.Exists(@"Patch\patch.txt"))
            {
                MessageBox.Show("Patch verfügbar", "Patch", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kein Patch verfügbar", "Patch", MessageBoxButtons.OK);
                testBtn_Start.Enabled = true;
            }
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

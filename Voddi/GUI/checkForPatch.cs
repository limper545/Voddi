using System;
using System.Collections.Generic;
using Core;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace GUI
{
    public partial class checkForPatch : Form
    {
        string username;

        User u;

        public User U => u;

        public string Username { get => username; set => username = value; }

        public checkForPatch(User username)
        {
            Contract.Requires(username != null);
            u = username ?? throw new ArgumentNullException(nameof(username));
            InitializeComponent();
        }
        async void checkForPatch_Load(object sender, EventArgs e)
        {
            patchBar.Maximum = 100;
            patchBar.Value = 50;
            testBtn_Start.Enabled = false;
            await CheckIfPatchIsThereAsync();

        }

        async Task CheckIfPatchIsThereAsync()
        {
            Contract.Ensures(Contract.Result<Task>() != null);
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
            var openForms = new List<Form>();

            new LoadingScreen(u).Show();
            foreach (Form f in Application.OpenForms) { openForms.Add(f); }

            openForms.ForEach(f =>
            {
                if (f.Name != nameof(LoadingScreen) && f.Name != nameof(StartMenu))
                {
                    f.Close();
                }
                else if (f.Name == nameof(StartMenu))
                {
                    f.Hide();
                }
            });
        }
    }
}


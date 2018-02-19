using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Core;

namespace GUI
{
    public partial class LoadingScreen : Form
    {
        private User u;
        public LoadingScreen(User username)
        {
            this.u = username;
            InitializeComponent();
        }

        private void GameMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private async Task StartgameMenuAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            this.Close();
            new GameMenu(u).Show();
        }

        private async void LoadingScreen_LoadAsync(object sender, EventArgs e)
        {
            await StartgameMenuAsync();
        }
    }
}

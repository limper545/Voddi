using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaB.GUI.Loading
{
    public partial class LoadingScreen : Form
    {
        //User u;
        //public LoadingScreen(User username)
        public LoadingScreen()
        {
            //u = username;
            InitializeComponent();
        }

        static void GameMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // throw new NotSupportedException();
        }

        /// <summary>
        /// Startet ein Timeout for den Loadingscreen
        /// </summary>
        /// <returns></returns>
        public async static Task StartgameMenuAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// Startet den Loginscreen mit Timeout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadingScreen_LoadAsync(object sender, EventArgs e)
        {
            await StartgameMenuAsync();
            //new GameMenu(u).Show();
            Close();
        }
    }
}

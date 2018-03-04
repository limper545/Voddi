using System;
using System.Windows.Forms;

namespace BaB.GUI
{
    class Start
    {
        [STAThread]
        static void Main(string []args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading.CreateDbLoading());
        }
    }
}

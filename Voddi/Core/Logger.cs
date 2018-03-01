using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Core
{
    public static class Logger
    {
        public static void Info(String function, String message)
        {
            var logMessage = "Time: " + DateTime.Now + " Function: " + function + " Message: " + message;
            var sw = File.AppendText(@"InfoLog.TxT");
            sw.WriteLine(logMessage);
            sw.Close();
        }

        public static void System(String function, String message)
        {
            var logMessage = "Function: " + function + " Message: " + message;
        }

        public static void Error(String function, String errorMessage)
        {
            var logMessage = "Function: " + function + " Message: " + errorMessage;
        }
    }
}

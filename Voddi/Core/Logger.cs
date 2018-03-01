using System;
using System.IO;

namespace Core
{
    public static class Logger
    {
        static String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        public static void Info(String function, String message)
        {
            Directory.CreateDirectory(path + "/LogsBab");
            using (StreamWriter w = File.AppendText(path + "/LogsBab/InfoLog.txt")) ;
            var logMessage = "Time: " + DateTime.Now + "=> Function: " + function + " - Message: " + message;
            var sw = File.AppendText("InfoLog.txt");
            sw.WriteLine(logMessage);
            sw.Close();
        }

        public static void System(String function, String message)
        {
            Directory.CreateDirectory(path + "/LogsBab");
            using (StreamWriter w = File.AppendText(path + "/LogsBab/SystemLog.txt")) ;
            var logMessage = "Function: " + function + " Message: " + message;
            var sw = File.AppendText("SystemLog.txt");
            sw.WriteLine(logMessage);
            sw.Close();
        }

        public static void Error(String function, String errorMessage)
        {
            Directory.CreateDirectory(path + "/LogsBab");
            using (StreamWriter w = File.AppendText(path + "/LogsBab/ErrorLog.txt")) ;
            var logMessage = "Function: " + function + " Message: " + errorMessage;
            var sw = File.AppendText("ErrorLog.txt");
            sw.WriteLine(logMessage);
            sw.Close();
        }
    }
}

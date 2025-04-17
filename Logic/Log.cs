using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Log
    {
        public void CreateFile()
        {
            if (!File.Exists("Log.txt"))
            {
                FileStream logFile = File.Create("Log.txt");
                logFile.Close();
            }
        }

        public void WriteMessage(string message)
        {
            StreamWriter logWrite = new("Log.txt", true);
            logWrite.WriteLine("[" + DateTime.Now.ToString() + "] " + message);
            logWrite.Close();
        }
    }
}

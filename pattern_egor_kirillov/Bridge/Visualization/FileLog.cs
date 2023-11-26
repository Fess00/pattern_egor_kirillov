using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using pattern_egor_kirillov.Bridge.Logger;

namespace pattern_egor_kirillov.Bridge.Visualization
{
    internal class FileLog : ALogSpec
    {
        string logPath;

        public FileLog() : base() 
        {
            logPath = @"C:\Users\MagicWheel\Downloads\LogTest.txt";
        }

        public FileLog(ILogger logger, string logPath = @"C:\Users\MagicWheel\Downloads\LogTest.txt") : base(logger)
        {
            this.logPath = logPath;
        }

        public override void Log()
        {
            using (FileStream fs = File.Create(logPath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(logger?.Log());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
    }
}

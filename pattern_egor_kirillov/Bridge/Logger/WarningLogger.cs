using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Bridge.Logger
{
    internal class WarningLogger : ALogger
    {
        public WarningLogger() : base()
        {

        }

        public WarningLogger(string logMessage) : base(logMessage)
        {

        }

        public WarningLogger(string logMessage, int codeMessage) : base(logMessage, codeMessage)
        {

        }

        public override string Log()
        {
            return $"Warning-{codeMessage}: {logMessage}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Bridge.Logger
{
    internal class ErrorLogger : ALogger
    {
        public ErrorLogger() : base()
        {

        }

        public ErrorLogger(string logMessage) : base(logMessage)
        {

        }

        public ErrorLogger(string logMessage, int codeMessage) : base(logMessage, codeMessage)
        {

        }

        public override string Log()
        {
            return $"Error-{codeMessage}: {logMessage}";
        }
    }
}

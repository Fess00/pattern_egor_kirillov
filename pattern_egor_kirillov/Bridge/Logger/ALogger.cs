using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Bridge.Logger
{
    internal abstract class ALogger : ILogger
    {
        protected string logMessage;
        protected int codeMessage;

        protected ALogger()
        {
            logMessage = string.Empty;
            codeMessage = -1;
        }

        protected ALogger(string logMessage) : this()
        {
            this.logMessage = logMessage;
        }

        protected ALogger(string logMessage, int codeMessage) : this(logMessage)
        {
            this.codeMessage = codeMessage;
        }

        public abstract string Log();
    }
}

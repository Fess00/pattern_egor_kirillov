using pattern_egor_kirillov.Bridge.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Decorator
{
    internal class UpperCaseLogger : ADecoLogger
    {
        public UpperCaseLogger() : base()
        {
        }

        public UpperCaseLogger(ILogger logger) : base(logger)
        {
        }

        public override string Log()
        {
            return this.logger?.Log().ToUpper();
        }
    }
}

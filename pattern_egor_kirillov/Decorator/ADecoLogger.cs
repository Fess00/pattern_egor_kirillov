using pattern_egor_kirillov.Bridge.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Decorator
{
    internal abstract class ADecoLogger : ILogger
    {
        protected ILogger? logger;

        protected ADecoLogger()
        {
            logger = null;
        }

        protected ADecoLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public abstract string Log();
    }
}

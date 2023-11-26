using pattern_egor_kirillov.Bridge.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Decorator
{
    internal class ReversedLogger : ADecoLogger
    {
        public ReversedLogger() : base()
        {
        }

        public ReversedLogger(ILogger logger) : base(logger) 
        {
        }

        public override string Log()
        {
            string tmpStr = "";
            IEnumerable<char> numer = logger?.Log().Reverse();
            foreach (var item in numer?.ToList())
            {
                tmpStr += item.ToString();
            }
            return tmpStr;
        }
    }
}

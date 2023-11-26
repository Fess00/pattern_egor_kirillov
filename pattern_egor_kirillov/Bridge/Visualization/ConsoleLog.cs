using pattern_egor_kirillov.Bridge.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Bridge.Visualization
{
    internal class ConsoleLog : ALogSpec
    {
        public ConsoleLog() : base()
        {
            
        }

        public ConsoleLog(ILogger logger) : base(logger)
        {
            
        }

        public override void Log()
        {
            Console.WriteLine(logger?.Log());
        }
    }
}

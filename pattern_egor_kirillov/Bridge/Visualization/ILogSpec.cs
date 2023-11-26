using pattern_egor_kirillov.Bridge.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Bridge.Visualization
{
    internal interface ILogSpec
    {
        void Log();
        void SetLogger(ILogger logger);
    }
}

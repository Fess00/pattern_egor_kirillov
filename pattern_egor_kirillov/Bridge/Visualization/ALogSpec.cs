using pattern_egor_kirillov.Bridge.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_egor_kirillov.Bridge.Visualization
{
    internal abstract class ALogSpec : ILogSpec
    {
        protected ILogger? logger;

        protected ALogSpec()
        {
            logger = null;
        }

        protected ALogSpec(ILogger logger) : this()
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public abstract void Log();

        public void SetLogger(ILogger logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}

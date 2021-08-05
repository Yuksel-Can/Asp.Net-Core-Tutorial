using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro2.Services.Logging
{
    public interface ILogger
    {
        void Log(string logMessage);
    }
}

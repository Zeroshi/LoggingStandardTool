using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Interfaces
{
    interface IApplication
    {
        void AttemptedTrace(LogLevel logLevel, string sender, string receiver, string message);
        void StackTrace(LogLevel logLevel, string message);
    }
}

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Interfaces
{
    public interface IBaseLogging
    {
        void Payload(LogLevel logLevel, string application_name, string message);
        void Information(LogLevel logLevel, string message);
        void Event(LogLevel logLevel, string message);
    }
}

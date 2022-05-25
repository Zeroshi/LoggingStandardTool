using LoggingStandards.Classes.ClassTypes;
using LoggingStandards.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Classes
{
    public class Logging : IBaseLogging
    {
        public void Event(LogLevel logLevel, string message)
        {
            var events = new Events { 
            LogLevel = logLevel,
            Message = message};

        }

        public void Information(LogLevel logLevel, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string application_name, string message)
        {
            throw new NotImplementedException();
        }
    }
}

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
            var events = new Events
            {
                LogLevel = logLevel,
                Message = message
            };

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

        public void Payload(LogLevel logLevel, string application_name, Enums.Enums.enviroment enviroment, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string application_name, Enums.Enums.enviroment enviroment, Enums.Enums.encryption encryption, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string application_name, Enums.Enums.enviroment enviroment, Enums.Enums.encryption encryption, Enums.Enums.IdentifiableInformation identifiableInformation, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string application_name, Enums.Enums.encryption encryption, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string application_name, Enums.Enums.IdentifiableInformation identifiableInformation, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string application_name, Enums.Enums.transaction_destination destination, string message)
        {
            throw new NotImplementedException();
        }

        public void Payload(LogLevel logLevel, string application_name, Enums.Enums.transaction_destination destination, Enums.Enums.transaction_destination_types destinationType, string message)
        {
            throw new NotImplementedException();
        }
    }
}

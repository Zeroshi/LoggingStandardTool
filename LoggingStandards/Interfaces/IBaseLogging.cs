using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LoggingStandards.Classes.Enums.Enums;

namespace LoggingStandards.Interfaces
{
    public interface IBaseLogging
    {

        void Payload(LogLevel logLevel, string application_name, string message);
        void Payload(LogLevel logLevel, string application_name, enviroment enviroment, string message);
        void Payload(LogLevel logLevel, string application_name, enviroment enviroment, encryption encryption, string message);
        void Payload(LogLevel logLevel, string application_name, enviroment enviroment, encryption encryption, IdentifiableInformation identifiableInformation, string message);
        //void Payload(LogLevel logLevel, string application_name, enviroment enviroment, encryption encryption, IdentifiableInformation identifiableInformation, string message);







        void Payload(LogLevel logLevel, string application_name, encryption encryption, string message);
        void Payload(LogLevel logLevel, string application_name, IdentifiableInformation identifiableInformation, string message);




        void Payload(LogLevel logLevel, string application_name, transaction_destination destination, string message);
        void Payload(LogLevel logLevel, string application_name, transaction_destination destination, transaction_destination_types destinationType, string message);
        void Information(LogLevel logLevel, string message);
        void Event(LogLevel logLevel, string message);
    }
}










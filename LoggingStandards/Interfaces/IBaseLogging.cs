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

        Task<bool> SendBaseLogInformation(LogLevel logLevel, string application_name, string log);
        Task<bool> SendBaseLogInformation(LogLevel logLevel, string application_name, Enviroment? enviroment, Encryption? encryption, string? platformlatform, bool? onlyInnerException, Exception? exception, Identifiable_Information? identifiable_information, Transaction_Destination? destination, Transaction_Destination_Types? destination_type, string? payload, string? note, string log);


        //void Information(LogLevel logLevel, string message);
        //void Information(LogLevel logLevel, string application_name, string message);
    }
}

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LoggingStandards.Classes.Enums.Enums;

namespace LoggingStandards.Interfaces.Objects
{
    public interface IEntityBase
    {
        Guid MessageId { get; set; }
        LogLevel LogLevel { get; set; }
        string Application_Name { get; set; }
        string Log { get; set; }
        string? Platform { get; set; }
        bool? OnlyInnerException { get; set; }
        string? Note { get; set; }
        Exception? Error { get; set; }
        Transaction_Destination? Transaction_Destination { get; set; }
        Transaction_Destination_Types? Transaction_Destination_Types { get; set; }
        Encryption? Encryption { get; set; }
        Enviroment? Enviroment { get; set; }
        Identifiable_Information? IdentifiableInformation { get; set; }
        string? Payload { get; set; }
    }
}

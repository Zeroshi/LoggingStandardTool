using LoggingStandards.Interfaces.Objects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LoggingStandards.Classes.Enums.Enums;

namespace LoggingStandards.Classes.ClassTypes
{

    /// <summary>
    /// Metadata concerning the message
    /// </summary>
    public class Events : IEntityBase
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
        public bool WrittenToPlatform { get; set; }
        public bool OnlyInnerException { get; set; }
        public string Note { get; set; }
        public Exception Error { get; set; }
        public transaction_destination Transaction_Destination { get; set; }
        public transaction_destination_types Transaction_Destination_Types { get; set; }
        public encryption Encryption { get; set; }
        public enviroment Enviroment { get; set; }
        public IdentifiableInformation IdentifiableInformation { get; set; }

    }
}

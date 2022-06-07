﻿using LoggingStandards.Interfaces.Objects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LoggingStandards.Classes.Enums.Enums;

namespace LoggingStandards.Classes.ClassTypes
{
    internal class ApplicationEntity : IApplicationEntity
    {
        public string ApplicationMessage { get; set; }
        public string CurrentMethod { get; set; }
        public Guid MessageId { get; set; }
        public LogLevel LogLevel { get; set; }
        public string Application_Name { get; set; }
        public string Log { get; set; }
        public string? Platform { get; set; }
        public bool? OnlyInnerException { get; set; }
        public string? Note { get; set; }
        public Exception? Error { get; set; }
        public Transaction_Destination? Transaction_Destination { get; set; }
        public Transaction_Destination_Types? Transaction_Destination_Types { get; set; }
        public Encryption? Encryption { get; set; }
        public Enviroment? Enviroment { get; set; }
        public Identifiable_Information? IdentifiableInformation { get; set; }
        public string? Payload { get; set; }
    }
}

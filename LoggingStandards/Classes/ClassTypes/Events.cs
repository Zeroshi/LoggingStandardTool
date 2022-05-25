using LoggingStandards.Interfaces.Objects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Classes.ClassTypes
{
    public class Events : IEvents
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
    }
}

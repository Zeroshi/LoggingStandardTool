using LoggingStandards.Interfaces.Objects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Classes.ClassTypes
{
    public class Events : IEntityBase
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
        public bool WrittenToPlatform { get; set; }
        public bool OnlyInnerException { get; set; }
        public string Note { get; set; }
        public Exception Error { get; set; }
    }
}

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Interfaces.Objects
{
    public interface IEvents
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
    }
}

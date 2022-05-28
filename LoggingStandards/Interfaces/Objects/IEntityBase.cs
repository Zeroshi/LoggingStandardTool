using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Interfaces.Objects
{
    public interface IEntityBase
    {
        bool WrittenToPlatform { get; set; }
        bool OnlyInnerException { get; set; }
        string Note { get; set; }
        LogLevel LogLevel { get; set; }
        Exception Error { get; set; }
    }
}

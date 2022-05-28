using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Interfaces.Objects
{
    internal interface IApplicationEntity : IEntityBase
    {
        string ApplicationMessage { get; set; }
        string CurrentMethod { get; set; }
    }
}

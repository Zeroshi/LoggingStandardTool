using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Interfaces.Objects
{
    internal interface IMessageQueueEntity : IEntityBase
    {
        string PopMessage { get; set; }
        string PushMessage { get; set; }
    }
}

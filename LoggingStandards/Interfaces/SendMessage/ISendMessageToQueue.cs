using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Interfaces.SendMessage
{
    internal interface ISendMessageToQueue
    {
        Task<bool> SendMessageAsync(string message, Guid messageId);
    }
}

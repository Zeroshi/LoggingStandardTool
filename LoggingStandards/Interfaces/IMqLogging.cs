using Microsoft.Extensions.Logging;

namespace LoggingStandards.Interfaces
{
    interface IMqLogging: IBaseLogging
    {
        void Queue(LogLevel logLevel, string queueName, string message);
        void QueueMessage(LogLevel logLevel, string message);
    }
}

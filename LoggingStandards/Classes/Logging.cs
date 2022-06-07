using LoggingStandards.Classes.ClassTypes;
using LoggingStandards.Classes.Queues;
using LoggingStandards.Interfaces;
using LoggingStandards.Queues;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LoggingStandards.Classes.Enums.Enums;

namespace LoggingStandards.Classes
{
    public class Logging : IBaseLogging
    {
        private string _queueEnvironmentVariable = "queueSection";
        const string _rabbitMQ_Queue = "rabbitmq_queue";
        const string _rabbitMQ_Topic = "rabbitmq_topic";
        const string _azure_Queue = "azure_queue";
        const string _azure_Serice_Bus = "azure_service_bus";
        private QueueSelection _queueSelection;

        private Logging()
        {
            GetEnviromentVariable();
        }

        private void GetEnviromentVariable()
        {
            string selectedQueue = Environment.GetEnvironmentVariable(_queueEnvironmentVariable).ToLower();
            SetQueueSelection(selectedQueue);
        }

        private void SetQueueSelection(string environmentVariable)
        {
            switch (environmentVariable)
            {
                case _rabbitMQ_Queue:
                    _queueSelection = QueueSelection.RabbitMQ_Queue;
                    break;
                case _rabbitMQ_Topic:
                    _queueSelection = QueueSelection.RabbitMQ_Topic;
                    break;
                case _azure_Queue:
                    _queueSelection = QueueSelection.Azure_Queue;
                    break;
                case _azure_Serice_Bus:
                    _queueSelection = QueueSelection.Azure_Service_Bus;
                    break;
                default:
                    _queueSelection = QueueSelection.None;
                    break;
            }
        }

        private async Task<bool> SendToQueueSelection(string payload)
        {
            var sendToQueue = new SendToQueue();

            switch (_queueSelection)
            {
                case QueueSelection.RabbitMQ_Queue:
                    return await Task.FromResult(sendToQueue.SendRabbitMqQueue(payload).Result);

                case QueueSelection.RabbitMQ_Topic:
                    return await Task.FromResult(sendToQueue.SendRabbitMqTopic(payload).Result);

                case QueueSelection.Azure_Queue:
                    return await Task.FromResult(sendToQueue.SendAzureQueue(payload).Result);

                case QueueSelection.Azure_Service_Bus:
                    return await Task.FromResult(sendToQueue.SendAzureServiceBus(payload).Result);

                default:
                    return false;
            }
        }


        public void Event(LogLevel logLevel, string message)
        {
            var events = new EntityBase
            {
                LogLevel = logLevel,
                Log = message
            };

            var entityBase = new EntityBase();
            var app = new ApplicationEntity();

        }

        public async Task<bool> SendBaseLogInformation(LogLevel logLevel, string application_name, string log)
        {
            return await SendBaseLogInformation(logLevel, application_name, null, null, null, null, null, null, null, null, null, null, log);
        }

        public async Task<bool> SendBaseLogInformation(LogLevel logLevel, string application_name, Enviroment? enviroment, Encryption? encryption, string? platform, bool? onlyInnerException, Exception? exception, Identifiable_Information? identifiable_information, Transaction_Destination? destination, Transaction_Destination_Types? destination_type, string? payload, string? note, string log)
        {
            var entityBase = new EntityBase
            {
                MessageId = Guid.NewGuid(),
                LogLevel = logLevel,
                Application_Name = application_name,
                Enviroment = enviroment,
                Encryption = encryption,
                Platform = platform,
                OnlyInnerException = onlyInnerException,
                Error = exception,
                IdentifiableInformation = identifiable_information,
                Transaction_Destination = destination,
                Transaction_Destination_Types = destination_type,
                Payload = payload,
                Note = note,
                Log = log
            };

            var convertToJson = new ConvertToJson();
            var jsonFile = convertToJson.ConvertMessageToJson<EntityBase>(entityBase);

            return await Task.FromResult(SendToQueueSelection(jsonFile).Result);
        }
    }
}

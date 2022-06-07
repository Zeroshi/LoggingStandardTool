using LoggingStandards.Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Classes.Queues
{
    internal class SendToQueue
    {
        internal async Task<bool> SendRabbitMqQueue(string payload)
        {
            try
            {
                var rabbitMqQueue = new RabbitMqQueue();
                var result = await rabbitMqQueue.SendMessageAsync(payload, Guid.NewGuid());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SendRabbitMqQueue with payload: {payload} : failed with the exception: {ex.InnerException}");
                return false;
            }
        }


        internal async Task<bool> SendRabbitMqTopic(string payload)
        {
            try
            {
                var rabbitMqTopic = new RabbitMqTopic();
                var result = await rabbitMqTopic.SendMessageAsync(payload, Guid.NewGuid());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SendRabbitMqTopi with payload: {payload} : failed with the exception: {ex.InnerException}");
                return false;
            }
        }

        internal async Task<bool> SendAzureServiceBus(string payload)
        {
            try
            {
                var azureServiceBus = new AzureServiceBus();
                var result = await azureServiceBus.SendMessageAsync(payload, Guid.NewGuid());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SendAzureServiceBus with payload: {payload} : failed with the exception: {ex.InnerException}");
                return false;
            }
        }

        internal async Task<bool> SendAzureQueue(string payload)
        {
            try
            {
                var azureQueue = new AzureQueue();
                var result = await azureQueue.SendMessageAsync(payload, Guid.NewGuid());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SendAzureQueue with payload: {payload} : failed with the exception: {ex.InnerException}");
                return false;
            }
        }
    }
}

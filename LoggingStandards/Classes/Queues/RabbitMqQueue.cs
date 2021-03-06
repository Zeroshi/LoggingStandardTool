using LoggingStandards.Interfaces.SendMessage;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Queues
{
    public class RabbitMqQueue : ISendMessageToQueue
    {
        public async Task<bool> SendMessageAsync(string message, Guid messageId)
        {
            try
            {
                var factory = new ConnectionFactory() { HostName = "localhost" };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "hello",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    var body = Encoding.UTF8.GetBytes(message);


                    channel.BasicPublish(exchange: "",
                                                 routingKey: "hello",
                                                 basicProperties: null,
                                                 body: body);

                    Console.WriteLine(messageId + " was sent");

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(messageId + " was not sent");
                return true;
            }
        }
    }
}

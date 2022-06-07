using System; // Namespace for Console output
using System.Configuration; // Namespace for ConfigurationManager
using System.Threading.Tasks; // Namespace for Task
//using Azure.Identity;
using Azure.Storage.Queues; // Namespace for Queue storage types
using Azure.Storage.Queues.Models; // Namespace for PeekedMessage
using LoggingStandards.Interfaces.SendMessage;

namespace LoggingStandards.Queues
{
    public class AzureQueue : ISendMessageToQueue
    {

        string _queueName = "Set up env variable";

        //-------------------------------------------------
        // Perform queue operations asynchronously
        //-------------------------------------------------
        public async Task<bool> SendMessageAsync(string message, Guid messageId)
        {
            try
            {
                // Get the connection string from app settings
                string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];

                // Instantiate a QueueClient which will be used to manipulate the queue
                QueueClient queueClient = new QueueClient(connectionString, _queueName);

                // Create the queue if it doesn't already exist
                await queueClient.CreateIfNotExistsAsync();

                if (await queueClient.ExistsAsync())
                {
                    Console.WriteLine($"Queue '{queueClient.Name}' created");
                }
                else
                {
                    Console.WriteLine($"Queue '{queueClient.Name}' exists");
                }

                // Async enqueue the message
                await queueClient.SendMessageAsync(message);

                Console.WriteLine(messageId + " was sent");

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}

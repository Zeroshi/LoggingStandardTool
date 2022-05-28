using System; // Namespace for Console output
using System.Configuration; // Namespace for ConfigurationManager
using System.Threading.Tasks; // Namespace for Task
//using Azure.Identity;
using Azure.Storage.Queues; // Namespace for Queue storage types
using Azure.Storage.Queues.Models; // Namespace for PeekedMessage
using LoggingStandards.Interfaces.SendMessage;

namespace LoggingStandards.Queues
{
    public class AzureQueues : ISendMessageToQueue
    {

        string _queueName = "Set up env variable";

        //-------------------------------------------------
        // Perform queue operations asynchronously
        //-------------------------------------------------
        public async Task<bool> SendMessageAsync(string message)
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
                await queueClient.SendMessageAsync("Hello, World");
                Console.WriteLine($"Message added");

                // Async receive the message
                QueueMessage[] retrievedMessage = await queueClient.ReceiveMessagesAsync();


                // Async delete the message
                await queueClient.DeleteMessageAsync(retrievedMessage[0].MessageId, retrievedMessage[0].PopReceipt);

                // Async delete the queue
                await queueClient.DeleteAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}

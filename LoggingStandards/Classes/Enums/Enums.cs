using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Classes.Enums
{
    public class Enums
    {
        public enum Transaction_Destination
        {
            not_available = 0,
            internal_transaction = 1,
            external_transaction = 2,
            internal_testing_transaction = 3,
            external_testing_transaction = 4
        }

        public enum Transaction_Destination_Types
        {
            not_available = 0,
            api = 1,
            message_queue = 2,
            database = 3,
            stream = 4,
            command_line = 5,
            serviceBus = 6,
            cache = 7,
            serviceMesh = 8,
            serverless = 9
        }

        public enum Encryption
        {
            not_available = 0,
            encrypted = 1,
            unecrypted = 2,
        }

        public enum Enviroment
        {
            not_available = 0,
            local = 1,
            development = 2,
            quality_assurance = 3,
            stage = 4,
            production = 5,
            blue = 6,
            green = 7,
            variation_a = 8,
            variation_b = 9,
            nonProduction_environment = 10

        }

        public enum Identifiable_Information
        {
            not_available = 0,
            personal_identifiable_information_PII = 1,
            personal_finance_information_PFI = 2,
            protected_health_information_PHI = 3
        }

        public enum QueueSelection
        {
            None = 0,
            Azure_Queue = 1,
            Azure_Service_Bus = 2,
            RabbitMQ_Queue = 3,
            RabbitMQ_Topic = 4
        }

        //define if entire payload? - what is the value in knowing? - route to other table/db?

    }
}

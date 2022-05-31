using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Classes.Enums
{
    public class Enums
    {
        public enum transaction_destination
        {
            internal_transaction = 0,
            external_transaction = 1,
            internal_testing_transaction = 2,
            external_testing_transaction = 3
        }

        public enum transaction_destination_types
        {
            api = 0,
            message_queue = 1,
            database = 2,
            stream = 3,
            command_line = 4,
            serviceBus = 5,
            cache = 6,
            serviceMesh = 7,
            serverless = 8,
        }

        public enum encryption
        {
            encrypted = 0,
            unecrypted = 1,
            not_avaiable = 3
        }

        public enum enviroment
        {
            local = 0,
            development = 1,
            quality_assurance = 2,
            stage = 3,
            production = 4,
            blue = 5,
            green = 6,
            variation_a = 7,
            variation_b = 8,
            nonProduction_environment = 9

        }

        public enum IdentifiableInformation
        {
            personal_identifiable_information_PII = 0,
            personal_finance_information_PFI = 1,
            protected_health_information_PHI = 2
        }



        //define if entire payload? - what is the value in knowing? - route to other table/db?

    }
}

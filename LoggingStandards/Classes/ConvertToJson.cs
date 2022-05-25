using LoggingStandards.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingStandards.Classes
{
    public class ConvertToJson
    {
        public string ConvertMessageToJson<T>(T log) where T : IBaseLogging
        {
            var output = JsonConvert.SerializeObject(log);
            return output;
        }
    }
}

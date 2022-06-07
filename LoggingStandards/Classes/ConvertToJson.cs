using LoggingStandards.Interfaces;
using LoggingStandards.Interfaces.Objects;
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
        public string ConvertMessageToJson<T>(T log) where T : IEntityBase
        {
            var output = JsonConvert.SerializeObject(log);
            return output;
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity;

namespace TestRatingNew.Services
{
    public class PolicyGenerator : IPolicyGenerator
    {
        private readonly string _fileName = "policy.json";
        public dynamic PolicyCreate()
        {
            string policyJson = File.ReadAllText(_fileName);

            dynamic policy = JsonConvert.DeserializeObject<dynamic>(policyJson,
                new StringEnumConverter());
            return policy;
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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


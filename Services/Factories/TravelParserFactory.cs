public class TravelParserFactory : AbstractPolicyParserFactory
{
    public TravelParserFactory(dynamic policyOriginal) : base((object)policyOriginal)
    {
    }

    public override Policy ParsePolicy()
    {
        _policy = new TravelPolicy() 
        {
            Country = _policyOriginal.Country, 
            Days = _policyOriginal.Days
        };            
        Console.WriteLine("Rating TRAVEL policy...");
        Console.WriteLine("Validating policy.");
        return _policy;

    }
}


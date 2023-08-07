
public class LifeParserFactory : AbstractPolicyParserFactory
{
    public LifeParserFactory(dynamic policyOriginal) : base((object)policyOriginal)
    {
    }

    public override Policy ParsePolicy()
    {
        _policy = new LifePolicy()
        {
            Amount = _policyOriginal.Amount,
            IsSmoker = _policyOriginal.IsSmoker
        };
        Console.WriteLine("Rating LIFE policy...");
        Console.WriteLine("Validating policy.");
        return _policy;
    }
}


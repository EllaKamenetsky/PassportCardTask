public class FactoryManager : IFactoryManager
{
    public AbstractPolicyParserFactory GetFactory(dynamic policyOriginal) {
        PolicyType policyType;
        Enum.TryParse(policyOriginal.type.Value, out policyType);
        AbstractPolicyParserFactory  parser= null;
        switch (policyType)
        {
            case PolicyType.Travel:
                parser = new TravelParserFactory(policyOriginal);
                break;
            case PolicyType.Health:
                parser = new HealthParserFactory(policyOriginal); break;
            case PolicyType.Life: 
                parser = new LifeParserFactory(policyOriginal); break;
            default : //log
                throw new ArgumentException();                   
        } 
        return parser;

    }
}


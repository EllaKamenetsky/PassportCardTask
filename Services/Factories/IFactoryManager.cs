public interface IFactoryManager
    {
        AbstractPolicyParserFactory GetFactory(dynamic policyOriginal);
    }


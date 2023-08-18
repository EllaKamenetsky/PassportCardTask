
public abstract  class AbstractPolicyParserFactory
{  
    protected Policy _policy;
    protected dynamic _policyOriginal;
    protected AbstractPolicyParserFactory(dynamic policyOriginal) { 
        _policyOriginal = policyOriginal;
    }      
        
    public abstract Policy ParsePolicy();

}


    public class RatingEngineBuilder : IRatingEngineBuilder
    {
        private dynamic _policyOriginal;
        private Policy _policy;
        private decimal _rating = 0; 

        private IPolicyGenerator _policyGenerated;
        private IFactoryManager _factoryManager;
        public RatingEngineBuilder(IPolicyGenerator policyGenerated, IFactoryManager factoryManager)
        {
            _policyGenerated = policyGenerated;
            _factoryManager = factoryManager;
        }

        public IRatingEngineBuilder Engine()
        {
            AbstractPolicyParserFactory factory = _factoryManager.GetFactory(_policyOriginal);
            _policy = factory.ParsePolicy();
            return this;
        }

    public decimal GetReting()
    {
        return _rating;
    }

    public IRatingEngineBuilder LoadingPolicy()
    {
        _policyOriginal = _policyGenerated.PolicyCreate();
        return this;
    }

        public IRatingEngineBuilder RatingCalculate()
        {
            _rating =  _policy.RatingCalculate();           
            return this;
        }

        public IRatingEngineBuilder StartingRate()
        {
            // log start rating
            Console.WriteLine("Starting rate.");
            return this;
        }

        public IRatingEngineBuilder Validation()
        {
            return _policy.ValidatePolicy() ? this : null;           
        }
    }


public class HealthParserFactory : AbstractPolicyParserFactory
    {
        public HealthParserFactory(dynamic policyOriginal) : base((object)policyOriginal)
        {
        }

        public override Policy ParsePolicy()
        {
            _policy = new HealthPolicy()
            {
                Gender = _policyOriginal.Gender,
                Deductible = _policyOriginal.Deductible
            };
            Console.WriteLine("Rating HEALTH policy...");
            Console.WriteLine("Validating policy."); 
            return _policy;
        }
    }


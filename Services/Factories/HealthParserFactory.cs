using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity;

namespace TestRatingNew.Services.Factories
{
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
}

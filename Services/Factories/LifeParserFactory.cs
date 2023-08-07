using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity;

namespace TestRatingNew.Services.Factories
{
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
}

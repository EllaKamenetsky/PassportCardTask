using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity;
using TestRatingNew.Services.Factories;

namespace TestRatingNew.Services
{
    public class RatingEngineBuilder : IRatingEngineBuilder
    {
        private dynamic _policyOriginal;
        private Policy _policy;
        private decimal _rating; 

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

        public IRatingEngineBuilder LoadingPolicy()
        {
            _policyOriginal = _policyGenerated.PolicyCreate();
            return this;
        }

        public IRatingEngineBuilder RatingCalculate()
        {
            var rating =  _policy.RatingCalculate();
            if (rating > 0)
            {
                Console.WriteLine($"Rating: {rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }
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
}

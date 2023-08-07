using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity;

namespace TestRatingNew.Services.Factories
{
    public abstract  class AbstractPolicyParserFactory
    {  
        protected Policy _policy;
        protected dynamic _policyOriginal;
        protected AbstractPolicyParserFactory(dynamic policyOriginal) { 
            _policyOriginal = policyOriginal;
        }      
        
        public abstract Policy ParsePolicy();

    }
}

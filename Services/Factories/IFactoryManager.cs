using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity;

namespace TestRatingNew.Services.Factories
{
    public interface IFactoryManager
    {
        AbstractPolicyParserFactory GetFactory(dynamic policyOriginal);
    }
}

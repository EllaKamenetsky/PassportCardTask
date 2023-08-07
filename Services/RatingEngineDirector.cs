using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRatingNew.Services
{
    public class RatingEngineDirector : IRatingEngineDirector
    {
        private readonly IRatingEngineBuilder _builder;
        public RatingEngineDirector(IRatingEngineBuilder builder) {
            _builder = builder;
        }
        public void Rate()
        {
            _builder.StartingRate()
                 .LoadingPolicy()
                 .Engine()
                 .Validation()?
                 .RatingCalculate();
        }
    }
}

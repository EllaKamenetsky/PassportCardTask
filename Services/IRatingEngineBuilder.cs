using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRatingNew.Services
{
    public interface IRatingEngineBuilder
    {
        IRatingEngineBuilder StartingRate();
        IRatingEngineBuilder LoadingPolicy();
        IRatingEngineBuilder Engine();
        IRatingEngineBuilder Validation();
        IRatingEngineBuilder RatingCalculate();
    }
}

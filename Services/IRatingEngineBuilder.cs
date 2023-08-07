public interface IRatingEngineBuilder
{
    IRatingEngineBuilder StartingRate();
    IRatingEngineBuilder LoadingPolicy();
    IRatingEngineBuilder Engine();
    IRatingEngineBuilder Validation();
    IRatingEngineBuilder RatingCalculate();
    decimal GetReting();
}


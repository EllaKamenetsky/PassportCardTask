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


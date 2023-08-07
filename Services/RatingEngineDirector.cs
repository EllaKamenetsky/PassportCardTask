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
        var rating = _builder.GetReting();
        if (rating > 0)
        {
            Console.WriteLine($"Rating: {rating}");
        }
        else
        {
            Console.WriteLine("No rating produced.");
        }

    }
}


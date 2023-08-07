using FluentValidation.Results;

public class HealthPolicy : Policy
{
    public override PolicyType Type { get => base.Type; protected set => base.Type = PolicyType.Health; }
    public string Gender { get; set; }


    public decimal Deductible { get; set; }       
       
    public override decimal RatingCalculate()
    {
        if (Gender == "Male")
        {
            if (Deductible < 500)
            {
                _rating = 1000m;
            }
            _rating = 900m;
        }
        else
        {
            if (Deductible < 800)
            {
                _rating = 1100m;
            }
            _rating = 1000m;
        };
        return _rating;
    }
       
    protected override ValidationResult Validate()
    {
        HealthValidator validator = new HealthValidator();
        return validator.Validate(this); 
    }
}


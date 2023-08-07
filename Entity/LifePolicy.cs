using FluentValidation.Results;

    public class LifePolicy : Policy
    {
        public decimal Amount { get; set; }
        public bool IsSmoker { get; set; }
        public override PolicyType Type { get => base.Type; protected set => base.Type = PolicyType.Life; }            
              
        public override decimal RatingCalculate()
        {
            int age = DateTime.Today.Year - DateOfBirth.Year;
            if (DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < DateOfBirth.Day ||
                DateTime.Today.Month < DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = Amount * age / 200;
            if (IsSmoker)
            {
                _rating = baseRate * 2;               
            }
            _rating = baseRate;
            return _rating;
        }
       

        protected override ValidationResult Validate()
        {
            LifeValidator validator = new LifeValidator();
            return validator.Validate(this); ;
        }
    }

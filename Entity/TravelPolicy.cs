using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity.Validators;

namespace TestRatingNew.Entity
{
    public class TravelPolicy : Policy
    {
        public override PolicyType Type { get => base.Type; protected set => base.Type = PolicyType.Travel; }
        public string Country { get; set; }
        public int Days { get; set; }
       
        public override decimal RatingCalculate()
        {
            _rating = Days * 2.5m;
            if (Country == "Italy")
            {
                _rating *= 3;
            };
            return _rating;
        }       

        protected override ValidationResult Validate()
        {
            TravelValidator validator = new TravelValidator();
             return validator.Validate(this); ;
        }
    }
}

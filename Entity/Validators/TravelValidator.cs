using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRatingNew.Entity.Validators
{
    public class TravelValidator : AbstractValidator<TravelPolicy>
    {
        public TravelValidator()
        {
            RuleFor(x => x.Days).LessThanOrEqualTo(180).WithMessage("Travel policy cannot be more then 180 Days").GreaterThan(0).WithMessage("Travel policy must specify Days.");
            RuleFor(x => x.Country).NotNull().NotEmpty().WithMessage("Travel policy must specify country.");
        }

    }
}

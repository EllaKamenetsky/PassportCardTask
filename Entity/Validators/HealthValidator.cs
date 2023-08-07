using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRatingNew.Entity.Validators
{
    public class HealthValidator : AbstractValidator<HealthPolicy>
    {
        public HealthValidator()
        {
            RuleFor(x => x.Gender).NotNull().NotEmpty().WithMessage("Health policy must specify Gender");
        }
    }
}

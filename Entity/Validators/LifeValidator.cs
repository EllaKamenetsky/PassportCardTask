﻿using FluentValidation;
public class LifeValidator : AbstractValidator<LifePolicy>
{
    public LifeValidator()
    {
        RuleFor(x => x.DateOfBirth).Equal(DateTime.MinValue).WithMessage("Life policy must include Date of Birth.").LessThanOrEqualTo(DateTime.Today.AddYears(-100)).WithMessage("Max eligible age for coverage is 100 years.");
        RuleFor(x => x.Amount).NotEqual(0).WithMessage("Life policy must include an Amount.");
    }

}


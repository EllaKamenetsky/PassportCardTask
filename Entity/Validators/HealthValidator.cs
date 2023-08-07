using FluentValidation;
public class HealthValidator : AbstractValidator<HealthPolicy>
{
    public HealthValidator()
    {
        RuleFor(x => x.Gender).NotNull().NotEmpty().WithMessage("Health policy must specify Gender");
    }
}

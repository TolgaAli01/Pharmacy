using FluentValidation;
using Pharmacy.Models.User;

namespace Pharmacy.Validators
{
    public class ManufacturerValidator : AbstractValidator<Manufacturer>
    {
        public ManufacturerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2);
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.Country)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);
        }
    }
}

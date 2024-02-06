using FluentValidation;
using Pharmacy.Models.User;

namespace Pharmacy.Validators
{
    public class MedicineValidator : AbstractValidator<Medicine>
    {
        public MedicineValidator()
        {
            RuleFor(x => x.ManufacturerId)
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2);
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThan(0);
        }
    }
}

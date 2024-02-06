using FluentValidation;
using Pharmacy.Models.Request;

namespace Pharmacy.Validators
{
    public class GetBooksByAuthorRequestValidator : AbstractValidator<GetMedicinesByManufacturerRequest>
    {
        public GetBooksByAuthorRequestValidator()
        {
            RuleFor(test => test.ManufacturerId)
                .NotNull()
                .GreaterThan(0)
                .LessThan(10);
            RuleFor(test => test.MinPrice)
               .InclusiveBetween(0, decimal.MaxValue)
               .When(test => test.MinPrice.HasValue);
            RuleFor(test => test.MaxPrice)
                .InclusiveBetween(0, decimal.MaxValue)
                .When(test => test.MaxPrice.HasValue);
        }
    }
}

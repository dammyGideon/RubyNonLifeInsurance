using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    public class ProductPricingAttributeValidator : AbstractValidator<ProductPricingAttributeDto>
    {
        public ProductPricingAttributeValidator()
        {
            RuleFor(x => x.AttributeId)
                .GreaterThan(0).WithMessage("Attribute ID must be greater than zero.");

            RuleFor(x => x.AttributeName)
                .NotEmpty().WithMessage("Attribute Name is required.");

            RuleFor(x => x.AffectPricing)
                .NotNull().WithMessage("Affect Pricing must be specified.");

            RuleFor(x => x.EffectType)
                .NotEmpty().WithMessage("Effect Type is required.");

            RuleFor(x => x.AffectRate)
                .GreaterThan(0).WithMessage("Affect Rate must be greater than zero.");
        }
    }


}

using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    public class ProductPricingConfigurationRequestValidator : AbstractValidator<CreateProductPricingConfigurationDto>
    {
        public ProductPricingConfigurationRequestValidator()
        {
            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("Category ID must be greater than zero.");

            RuleForEach(x => x.Attributes).SetValidator(new ProductPricingAttributeValidator());
        }
    }


}

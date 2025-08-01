using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    // Validator for ProductCostTypeRequest
    public class ProductCostTypeRequestValidator : AbstractValidator<ProductCostTypeRequest>
    {
        public ProductCostTypeRequestValidator()
        {
            RuleFor(x => x.CostTypeId)
                .GreaterThan(0).WithMessage("CostTypeId must be greater than 0.");

            RuleFor(x => x.Remark)
                .NotEmpty().WithMessage("Remark is required.")
                .MaximumLength(200).WithMessage("Remark cannot be longer than 200 characters.");
        }
    }

}

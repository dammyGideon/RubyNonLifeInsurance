using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    public class ProductPenaltyRequestValidator : AbstractValidator<ProductPenaltyRequest>
    {
        public ProductPenaltyRequestValidator() {
                RuleFor(request => request.ProductId)
                    .NotEmpty()
                    .WithMessage("Product ID is required.");

                RuleForEach(request => request.PenaltyRequests).SetValidator(new PenaltyRequestValidator());
         
        }
    }

    public class PenaltyRequestValidator : AbstractValidator<PenaltyRequest>
    {
        public PenaltyRequestValidator()
        {
            RuleFor(penalty => penalty.LowerLimit)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Lower limit must be greater than or equal to 0.");

            RuleFor(penalty => penalty.UpperLimit)
                .GreaterThan(penalty => penalty.LowerLimit)
                .WithMessage("Upper limit must be greater than the lower limit.");

            RuleFor(penalty => penalty.Penalty)
            .NotEmpty()
            .WithMessage("Penalty amount is required.");
        }
    }
}

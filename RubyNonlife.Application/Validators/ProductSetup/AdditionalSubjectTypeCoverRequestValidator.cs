using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    // Validator for AdditionalSubjectTypeCoverRequest
    public class AdditionalSubjectTypeCoverRequestValidator : AbstractValidator<AdditionalSubjectTypeCoverRequest>
    {
        public AdditionalSubjectTypeCoverRequestValidator()
        {
            //RuleFor(x => x.CoverId)
            //    .GreaterThan((short)0).WithMessage("CoverId must be greater than 0.");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("Status is required.");

            RuleFor(x => x.UseRateTable)
                .NotNull().WithMessage("UseRateTable must be provided.");

            //RuleFor(x => x.CoverLimits)
            //    .GreaterThan(0).WithMessage("CoverLimits must be greater than 0.");

            // DisplayFormula can be null or non-empty string
          

            //RuleFor(x => x.LimitType)
            //    .NotEmpty().WithMessage("LimitType is required.");

            //RuleFor(x => x.MaximumAmount)
            //    .GreaterThanOrEqualTo(0).WithMessage("MaximumAmount must be greater than or equal to 0.");
        }
    }

}

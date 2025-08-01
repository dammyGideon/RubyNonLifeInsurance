using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.Reinsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ReinsuranceSetupValidation
{
    public class ProtectionLayerRequestValidator : AbstractValidator<ProtectionLayerRequestDto>
    {
        public ProtectionLayerRequestValidator() {
            RuleFor(x => x.ProtectionType)
                 .NotEmpty().WithMessage("Protection Type is required.");

            RuleFor(x => x.ProtectionSubType)
                .NotEmpty().WithMessage("Protection SubType is required");

            RuleFor(x => x.RetentionAmount)
                 .GreaterThanOrEqualTo(0)
                .WithMessage("RetentionAmount is can not be zero");
            RuleFor(x => x.NumbersOfLines)
                .NotNull().WithMessage("number of lines can not be empty");
               
        }
    }
}

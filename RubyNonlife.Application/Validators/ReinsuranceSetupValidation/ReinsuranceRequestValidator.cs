using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Requests.Reinsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ReinsuranceSetupValidation
{
    public class ReinsuranceRequestValidator : AbstractValidator<ReinsuranceAgreementRequestDto>
    {
        public ReinsuranceRequestValidator()
        {
            RuleFor(x => x.BusinessYear)
                 .NotEmpty().WithMessage("Business year is required.");

            RuleFor(x => x.AgreementCaption)
                .NotEmpty().WithMessage("Agreement Caption is required");

            RuleFor(x => x.AgreementDescription)
               .NotEmpty().WithMessage("Agreement Description is required.");

           
        }
    }
}



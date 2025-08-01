using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    public class NonLifeProductTeamRequestValidator : AbstractValidator<ProductTeamRequest>
    {
        public NonLifeProductTeamRequestValidator()
        {

            RuleFor(x => x.ProductName)
                 .NotEmpty().WithMessage("Product Name is required.")
                 .Matches(@"^[a-zA-Z0-9\s]+$").WithMessage("Product Name should only contain letters, numbers, and spaces.");

            //RuleFor(x => x.VariantId).NotEmpty().WithMessage("Variant Type is required");
          

          

        }
    }
}

using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Product Name is required.")
                .MaximumLength(100).WithMessage("Product Name cannot exceed 100 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");

            RuleFor(x => x.Alias)
                .MaximumLength(50).WithMessage("Alias cannot exceed 50 characters.");

            RuleFor(x => x.ProductClassId)
                .GreaterThan(0).WithMessage("Product Class ID must be greater than 0.");
        }
    }
}

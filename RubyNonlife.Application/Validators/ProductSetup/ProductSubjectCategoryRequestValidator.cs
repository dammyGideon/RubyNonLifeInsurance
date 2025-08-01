using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    public class ProductSubjectCategoryRequestValidator : AbstractValidator<ProductSubjectCategoryRequest>
    {
        public ProductSubjectCategoryRequestValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("Category name is required.");

            RuleFor(x => x.ProductSubjectAttributes)
                .NotEmpty().WithMessage("Product subject attributes cannot be empty.")
                .ForEach(ps => ps.SetValidator(new ProductSubjectRequestValidator())); // Validate each ProductSubjectRequest
        }
    }

}

using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    // Validator for ProductSubjectRequest
    public class ProductSubjectRequestValidator : AbstractValidator<ProductSubjectRequest>
    {
        public ProductSubjectRequestValidator()
        {
            RuleFor(x => x.SubjectTypeId)
                .GreaterThan(0).WithMessage("SubjectTypeId must be a positive integer.");

            Include(new ProductSubjectAttributeRequestValidator()); // Include validation from base class
        }
    }

}

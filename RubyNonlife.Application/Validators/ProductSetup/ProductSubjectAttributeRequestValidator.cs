using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    // Validator for ProductSubjectAttributeRequest
    public class ProductSubjectAttributeRequestValidator : AbstractValidator<ProductSubjectAttributeRequest>
    {
        public ProductSubjectAttributeRequestValidator()
        {
            RuleFor(x => x.SubjectAttributeName)
                .NotEmpty().WithMessage("Subject attribute name is required.");

            RuleFor(x => x.FieldType)
                .NotEmpty().WithMessage("Field type is required.");

            // Make DropdownValues optional (i.e., null or non-empty list)
            RuleFor(x => x.DropdownValues)
                .Must(values => values == null || values.Count == 0 || values.All(v => !string.IsNullOrEmpty(v.Value)))
                .WithMessage("All Dropdown values must be non-empty if provided.");

            RuleFor(x => x.DataTypeId)
                .GreaterThan(0).WithMessage("DataTypeId must be a positive integer.");

            RuleFor(x => x.IsCompulsory)
                .NotNull().WithMessage("IsCompulsory is required.");

            RuleFor(x => x.IsSumAssured)
                .NotNull().WithMessage("IsSumAssured is required.");
        }
    }

}

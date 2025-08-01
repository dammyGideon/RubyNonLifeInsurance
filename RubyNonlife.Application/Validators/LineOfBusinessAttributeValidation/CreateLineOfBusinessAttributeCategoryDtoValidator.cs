using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.LineOfBusines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.LineOfBusinessAttributeValidation
{
    public class CreateLineOfBusinessAttributeCategoryDtoValidator : AbstractValidator<CreateLineOfBusinessAttributeCategoryDto>
    {
        public CreateLineOfBusinessAttributeCategoryDtoValidator()
        {
            RuleFor(x => x.BusinessLineId)
             .GreaterThan(0).WithMessage("BusinessLine must be a positive number.");


            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");

            RuleFor(x => x.Alias)
                .MaximumLength(50).WithMessage("Alias cannot exceed 50 characters.");

            RuleFor(x => x.ApplicableObjects)
                .NotNull().WithMessage("ApplicableObjects cannot be null.")
                .Must(objects => objects.Any()).WithMessage("At least one applicable object is required.");
        }
    }
}

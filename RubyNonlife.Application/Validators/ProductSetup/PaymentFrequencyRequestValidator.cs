using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Validators.ProductSetup
{
    public class PaymentFrequencyRequestValidator : AbstractValidator<PaymentFrequencyRequest>
    {
        private readonly List<string> validIntervals = new List<string>
    {
        "One Time", "Adhoc", "Monthly", "Bi-Monthly", "Quarterly", "Bi-Annually", "Annually"
    };

        public PaymentFrequencyRequestValidator()
        {
            // Validate that PaymentIntervals is not empty and is in the list of valid intervals
            RuleFor(x => x.PaymentIntervals)
                .NotEmpty().WithMessage("Payment Intervals is required.")
                .Must(BeAValidInterval).WithMessage("Payment Intervals must be one of the valid values.");
        }

        // Custom validation to check if the value is in the list of valid intervals
        private bool BeAValidInterval(string paymentInterval)
        {
            return validIntervals.Contains(paymentInterval);
        }
    }

}

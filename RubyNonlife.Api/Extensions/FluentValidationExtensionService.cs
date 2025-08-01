using FluentValidation;
using RubyNonlife.Application.Dtos.Requests.LineOfBusines;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Requests.Reinsurance;
using RubyNonlife.Application.Validators.LineOfBusinessAttributeValidation;
using RubyNonlife.Application.Validators.ProductSetup;
using RubyNonlife.Application.Validators.ReinsuranceSetupValidation;
using System.Reflection;


namespace RubyNonlife.Infrastructure.Extensions
{
    public static class FluentValidationExtensionService
    {
        public static void ConfigureValidation(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient<IValidator<ProductTeamRequest>, NonLifeProductTeamRequestValidator>();
            services.AddTransient<IValidator<ReinsuranceAgreementRequestDto>,ReinsuranceRequestValidator>();
            services.AddTransient<IValidator<CreateLineOfBusinessAttributeCategoryDto>, CreateLineOfBusinessAttributeCategoryDtoValidator>();

            //services.AddTransient<IValidator<CreateProductRequest>, CreateProductRequestValidator>();
            //services.AddTransient<IValidator<PaymentFrequencyRequest>,PaymentFrequencyRequestValidator>();
            //services.AddTransient<IValidator<ProductSubjectRequest>, ProductSubjectRequestValidator>();
            //services.AddTransient<IValidator<ProductSubjectCategoryRequest>,  ProductSubjectCategoryRequestValidator>();
            //services.AddTransient<IValidator<ProductSubjectAttributeRequest>, ProductSubjectAttributeRequestValidator>();
            //services.AddTransient<IValidator<BaseSubjectTypeCoverRequest>, BaseSubjectTypeCoverRequestValidator>();
            //services.AddTransient<IValidator<AdditionalSubjectTypeCoverRequest>,  AdditionalSubjectTypeCoverRequestValidator>();
            //services.AddTransient<IValidator<ProductSubjectCategoryRequest>, ProductSubjectCategoryRequestValidator>();
        }
    }
}

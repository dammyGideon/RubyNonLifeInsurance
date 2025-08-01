using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RubyNonlife.Infrastructure.Implementations;
using RubyNonlife.Infrastructure.Contract;
//using Microsoft.AspNetCore.Hosting;
//using RubyNonlife.Infrastructure.Middleware;
//using FluentValidation;
//using RubyNonlife.Application.Dtos.Requests.ProductSetup;
//using RubyNonlife.Application.Validators.ProductSetup;
//using RubyNonlife.Application.Helper;
using RubyNonlife.Application.Implementations;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Contract;
using RubyNonlife.Infrastructure.Persistence;
using Humanizer.Configuration;
using RubyNonlife.Application.Helper.UtitlityModel;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


namespace RubyNonlife.Api.Extensions
{
    public static class ServiceExtensionConfiguration
    {

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RubyDbContext>(options =>
                options.UseSqlServer(configuration.
                GetConnectionString("DefaultConnection")));

           services.Configure<ApiSettings>(configuration.GetSection("AppSettings"));
           services.Configure<ConfigModels>(configuration.GetSection("AppSettings:ConfigModels"));
           services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
           



        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });
            
        }

       

        public static void ConfigureServices(this IServiceCollection service)
        {
            service.AddHttpContextAccessor();
            service.AddSingleton<ILoggerManager, LoggerManager>();
            service.AddScoped<IProductServiceLookSetup, ProductSetupLookupServices>();
            service.AddScoped<IProductSetupService, ProductSetupService>();
            service.AddScoped<IQuotationService, QuotationService>();
            service.AddScoped<IPolicyBookingService, PolicyBookingService>();
            service.AddScoped<IFileService, FileService>();
            service.AddHttpClient<AdminAuthenticationHelper>();
            service.AddHttpClient<FinanceAuthenticationHelper>();
            service.AddScoped<IReinsuranceService, ReinsuranceService>();
            service.AddScoped<IProductDocumentService, ProductDocumentService>();
            service.AddScoped<IAdminServiceIntegration, AdminServiceIntegration>();
            service.AddScoped<IFinanceServiceIntegration, FinanceServiceIntegration>();
            service.AddScoped<ILineOfBusinessGenericService, LineOfBusinessGenericService>();
            service.AddScoped<INotificationService,  NotificationService>();
            service.AddTransient<IWorkflowEmailService, WorkflowEmailService>();
            service.AddScoped<IWorkflowService, WorkFlowService>();
            service.AddScoped<IFinanceService, FinanceService>();
            service.AddScoped<IAdAuthenticationService, AdAuthenticationService>();
            service.AddScoped<ILarmsService, LarmsService>();
            service.AddMemoryCache();
           
        }


    }
}

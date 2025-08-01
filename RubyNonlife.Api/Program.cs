using Asp.Versioning;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NLog;
using RubyNonlife.Api.Extensions;
using RubyNonlife.Api.Policies;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Helper;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Infrastructure.Extensions;
//using RubyNonlife.Infrastructure.Middleware;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().
    AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureServices();
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureValidation();

builder.Services.Configure<FileServerConfiguration>(builder.Configuration.GetSection("FileServerConfiguration"));



builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

builder.Services.AddSingleton<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();
builder.Services.AddSingleton<IAuthorizationHandler, ActionRequirementHandler>();


// Get JWT Settings from configuration
var jwtTokenConfig = builder.Configuration.GetSection("JwtSettings");

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = jwtTokenConfig["Issuer"], // Accessing the Issuer from configuration
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtTokenConfig["SecretKey"])), // Accessing the SecretKey from configuration
        ValidAudience = jwtTokenConfig["Audience"], // Accessing the Audience from configuration
        ValidateAudience = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.FromMinutes(1) // Optional: Adjust clock skew for token expiration tolerance
    };
});





builder.Services.AddSwaggerGen(c =>
{
    c.DescribeAllParametersInCamelCase();
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RubyP&C.Api", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });

});




builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()      
               .AllowAnyHeader()      
               .AllowAnyMethod();    
    });
});



builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
}).AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });



var app = builder.Build();

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.development.config"));



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();

var swaggerUi = builder.Configuration.GetSection("SwaggerUi").Value;
app.UseSwaggerUI(c => c.SwaggerEndpoint(swaggerUi, "RubyP&C.Api v1"));



app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
                Path.Combine(builder.Environment.ContentRootPath, 
                "Resources", "ProductClassIcons")),
    RequestPath = "/ProductClassIcons"
});


//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(
//        Path.Combine(Directory.GetCurrentDirectory(), "Uploads")),
//    RequestPath = "/Uploads"
//});




app.UseCors();

//app.UseMiddleware<GlobalExceptionHandler>();

app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();


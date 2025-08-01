using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RubyNonlife.Application.Dtos.Requests.Booking;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Booking;
using System.Net;
using System.Text.Json;
using System.Text;
using System.Security.Cryptography;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Caching.Memory;
using ReceivableLedgerResponse = RubyNonlife.Application.Dtos.Responses.Booking.ReceivableLedgerResponse;
using ExpenseLedgerResponse = RubyNonlife.Application.Dtos.Responses.Booking.ExpenseLedgerResponse;
using RubyNonlife.Application.Contract;
using RubyNonlife.Infrastructure.Contract;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Infrastructure.Persistence;
using RubyNonlife.Domain.Models.QuoteEntities;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.PolicyEntities;
using OfficeOpenXml;
using RubyNonlife.Domain.Models.ProductEntities;
using OfficeOpenXml.Style;
using RubyNonlife.Domain.Models.GenericEntities;
using RubyNonlife.Domain.Models.ApprovalWorks;
using Microsoft.Extensions.DependencyInjection;
using RubyNonlife.Application.Helper.UtitlityModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout;
using Microsoft.AspNetCore.Hosting;
using iText.Layout.Borders;
using Azure;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using RubyNonlife.Application.Utitlies;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using JsonException = System.Text.Json.JsonException;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Drawing;
using Path = System.IO.Path;
using System.Linq;
using RubyNonlife.Domain.Models.CustomerEntities;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.AspNetCore.Mvc;
using Xceed.Words.NET;
using System.IO.Compression;
using RubyNonlife.Domain.Models.Lookups;
using Org.BouncyCastle.Asn1.Cms;







namespace RubyNonlife.Application.Implementations
{
    public class PolicyBookingService : IPolicyBookingService
    {
        private readonly RubyDbContext _rubyDbContext;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IFileService _fileService;
        private readonly AdminAuthenticationHelper _authenticationHelper;
        private readonly FinanceAuthenticationHelper _financeAuthentication;
        private readonly HttpClient _httpClient;
        private readonly AdminUrlConfig _apiSettings;
        private readonly AdminAuthenticationHelper _adminHelper;
        private readonly IMemoryCache _memoryCache;
        private readonly IAdminServiceIntegration _adminService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IReinsuranceService _reinsurance;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ConfigModels _configModels;
        private readonly IFinanceServiceIntegration _serviceIntegration;
        private readonly ILarmsService _larmsService;
        public string RootDirectory { get; set; }
       
        public IConfiguration _configuration { get; set; }

        const decimal RetentionCapacity = 50000000;
        const decimal TreatyCapacity = 25000000;
        const decimal UnderWritingCapacity = 75000000;
        const decimal ExcessCapacity = 25000000;


        public PolicyBookingService(IConfiguration configuration, RubyDbContext rubyDbContext,
            IHttpContextAccessor httpContext, IFileService fileService, AdminAuthenticationHelper authenticationHelper,
            FinanceAuthenticationHelper financeAuthentication,
            HttpClient httpClient, IOptions<ApiSettings> options, IMemoryCache memoryCache, IAdminServiceIntegration adminService,
            IServiceProvider serviceProvider, IOptions<ConfigModels> configOptions,
            IReinsuranceService reinsurance, IWebHostEnvironment webHostEnvironment,
            IFinanceServiceIntegration financeService,
            ILarmsService larmsService
            )
        {
            _rubyDbContext = rubyDbContext;
            _contextAccessor = httpContext;
            _fileService = fileService;
            _configuration = configuration;
            RootDirectory = _configuration.GetSection("AppSettings:FileServerConfiguration:RootDirectory").Value.ToString();
            _adminHelper = authenticationHelper;
            _httpClient = httpClient;
            _apiSettings = options.Value.AdminUrl;
            _memoryCache = memoryCache;
            _adminService = adminService;
            _serviceProvider = serviceProvider;
            _configModels = configOptions.Value;
            _financeAuthentication = financeAuthentication;
            _reinsurance = reinsurance;
            _webHostEnvironment = webHostEnvironment;
            _serviceIntegration = financeService;
            _larmsService = larmsService;
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetBeneficiary()
        {

            var getBeneficiary = await _rubyDbContext.PolicyBookingBeneficiaries.ToListAsync();
            var beneficiary = getBeneficiary.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>
                (beneficiary, "Beneficiary retrieved Successfully");
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetBrokers()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var broker = _configModels.BrokerTypeId;


            var getBroker = await _adminService.GetExternalEntity(broker);
            var brokerData = getBroker.Data.Select(p => new GenericNameResponse()
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>
                (brokerData, "Broker retrieved Successfully");
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetOfficeLocation(){


            var response = new BaseResponse<List<GenericNameResponse>>();

            var getOffice = await _adminService.GetOfficeLocation();
            var officeData = getOffice.Data.Select(p => new GenericNameResponse()
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>
                (officeData, "Location retrieved Successfully");
        }



        public async Task<BaseResponse<List<GenericNameResponse>>> GetPolicyBusinessSource()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var businessSources = await _rubyDbContext.PolicyBusinessSources.ToListAsync();
            var sourcesData = businessSources.Select(c => new GenericNameResponse()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(sourcesData,"Business Source retrieved Successfully");
        }
        public async Task<BaseResponse<List<GetBookingAttributeResponse>>> GetBookingAttribute(int productId)
        {
            
            // Fetch the product along with its attributes and their dropdown values
            var product = await _rubyDbContext.ProductSubjectTypes
                .Include(d => d.ProductSubjectTypeAttributes)  // Include attributes
                    .ThenInclude(a => a.DropdownValues)         // Include dropdown values for attributes
                .FirstOrDefaultAsync(d => d.ProductId == productId);

            if (product == null)
                return ResponseFactory.CreateError<List<GetBookingAttributeResponse>>("Product Not Found", HttpStatusCode.NotFound);
            

            // Filter and map the attributes where AvailableAtQuotation == false
            var attributeData = product.ProductSubjectTypeAttributes
                .Where(a => a.AvailableAtQuotation == false)  // Filter attributes
                .Select(a => new GetBookingAttributeResponse
                {
                    Id = a.Id,
                    Name = a.Name,
                    Datatype = a.FieldType,
                    DropdownValues = a.DropdownValues != null
                        ? a.DropdownValues.Select(dv => new DropdownValuesSubjectAttributeResponse
                        {
                            Value = dv.Value
                        }).ToList()
                        : new List<DropdownValuesSubjectAttributeResponse>()
                }).ToList();

            

            return ResponseFactory.GetSuccessResponse<List<GetBookingAttributeResponse>>(attributeData, "Subject Attribute retrieved Successfully");
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetPolicyBusinessType()
        {
            var businessTypes = await _rubyDbContext.PolicyBusinessTypes.ToListAsync();
            var businessData = businessTypes.Select(c => new GenericNameResponse()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(businessData, "Business Type retrieved Successfully");
        }
        public async Task<BaseResponse<List<PaymentCycleResponse>>> GetPaymentCycles(int productId)
        {
            var productExist = await _rubyDbContext.ProductAllowedPaymentFrequencies
                                 .Where(d => d.ProductId == productId).ToListAsync();
            if (productExist == null)
                return ResponseFactory.CreateError<List<PaymentCycleResponse>>("Product not Found",HttpStatusCode.NotFound);
            var paymentFrequency = productExist.Select(d => new PaymentCycleResponse()
            {
                Id = d.Id,
                Name = d.PaymentFrequency
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<PaymentCycleResponse>>(paymentFrequency, "Payment Cycles retrieved successfully");
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetPolicyPaymentType()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var paymentType = await _rubyDbContext.PolicyBookingPaymentTypes.ToListAsync();
            var paymentData = paymentType.Select(c => new GenericNameResponse()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(paymentData, "Payment Type retrieved Successfully");

        }
        public async Task<BaseResponse<List<GenericNameResponse>>> PolicyAdditionalInformation()
        {
            var additionalInformation = await _rubyDbContext.PolicyAdditionalInformation.ToListAsync();
            var additionalData = additionalInformation.Select(c => new GenericNameResponse()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(additionalData, "Policy Additional Information retrieved Successfully");
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> PolicyBookingInsurers()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var insurance = _configModels.InsuranceTypeId;
            var bookingInsurers = await _adminService.GetExternalEntity(insurance);
            var bookingData = bookingInsurers.Data.Select(c => new GenericNameResponse()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(bookingData, "Policy Additional Information retrieved Successfully");
        }


       

        public async Task<BaseResponse<List<GenericNameResponse>>> GetAllLocalGovernment(int stateId)
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var getLGA = await _rubyDbContext.LocalGovernmentAreaLookups
                    .Where(s => s.StateId == stateId).ToListAsync();
            var lgaResponse = getLGA.Select(s => new GenericNameResponse()
            {
                Id = s.Id,
                Name = s.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(lgaResponse, "Local Government retrieved successfully");
        }
        public async Task<BaseResponse<BookingQuoteResponse>> GetQuotationForBook(int QuoteId) 
        {
        
            // Fetch the selected quote with related data
            var selectedQuote = await _rubyDbContext.Quotations.Include(d=>d.QuoteType)
                .Include(q => q.QuotationAttributeValues)
                    .ThenInclude(attr => attr.ProductSubjectTypeAttribute)
                .Include(q => q.Product)
                    .ThenInclude(p => p.ProductSubjectTypes)
                   
                .Where(q => q.QuoteStatus == "Accepted")
                .FirstOrDefaultAsync(q => q.Id == QuoteId);

            if (selectedQuote == null)
                return ResponseFactory.CreateError<BookingQuoteResponse>("Quote Not Found", HttpStatusCode.NotFound);
            
            // Fetch all attributes related to the product
            var productSubjectTypes = await _rubyDbContext.ProductSubjectTypes
                .Include(pst => pst.ProductSubjectTypeAttributes)
                .Where(pst => pst.ProductId == selectedQuote.ProductId)
                .ToListAsync();

            if (productSubjectTypes == null || !productSubjectTypes.Any())
                return ResponseFactory.CreateError<BookingQuoteResponse>("Product Attributes Not Found",HttpStatusCode.NotFound);

           

            var productSubjectType = await _adminService.GetSubjectType(productSubjectTypes.FirstOrDefault().SubjectTypeId);
            var productSubjectTypeName = productSubjectType.Data;

            // Determine if the quotation is a fleet (multiple unique EntityId)
            var uniqueEntityIds = selectedQuote.QuotationAttributeValues
                .Select(qav => qav.EntityId)
                .Distinct()
                .ToList();

            var isFleet = uniqueEntityIds.Count > 1;

            if (isFleet)
            {
                
                var locationResponse = await GetGenericLocation(selectedQuote.ProductId);
                List<LocationFieldResponses>? locationFieldResponses = null;
                if (locationResponse?.Success == true)
                {
                    locationFieldResponses = locationResponse.Data;
                }

                var fleetQuoteResponse = new BookingQuoteResponse()
                {
                    QuotationId = selectedQuote.Id,
                    QuoteId = selectedQuote.QuoteId,
                    ProductId = selectedQuote.ProductId,
                    Customer = selectedQuote.Customer,
                    CustomerNumber = selectedQuote.CustomerNumber,
                    RequiresGenericLocation = selectedQuote.Product.RequiresGenericLocation,
                    Subject = productSubjectTypeName,
                    LocationFieldResponses = locationFieldResponses,
                    QuotePreference = selectedQuote.QuoteType.Name,
                };

               
                return ResponseFactory.GetSuccessResponse<BookingQuoteResponse>(fleetQuoteResponse, "Fleet quotation details retrieved successfully!");
            }
            else
            {

                var bookingAttributes =new  List<BookingQuoteAttributesResponse>
                {
                     new BookingQuoteAttributesResponse{
                EntityId = null,
                Attributes = productSubjectTypes
                    .SelectMany(pst => pst.ProductSubjectTypeAttributes.Select(attr =>
                    {
                        var matchingValue = selectedQuote.QuotationAttributeValues
                            .FirstOrDefault(qav => qav.AttributeId == attr.Id);

                        return new BookingQuoteAttributeResponse
                        {
                            AttributeId = attr.Id,
                            AttributeName = attr.Name,
                            AttributeValue = matchingValue?.AttributeValue
                        };
                    }))
                    .ToList()
                     }
                };
                

                // Fetch generic location (handle failure gracefully)
                var locationResponse = await GetGenericLocation(selectedQuote.ProductId);
                List<LocationFieldResponses>? locationFieldResponses = null;
                if (locationResponse?.Success == true)
                {
                    locationFieldResponses = locationResponse.Data;
                }

                var bookingQuoteResponse = new BookingQuoteResponse
                {
                    QuotationId = selectedQuote.Id,
                    ProductId = selectedQuote.ProductId,
                    QuoteId = selectedQuote.QuoteId,
                    Customer = selectedQuote.Customer,
                    CustomerNumber = selectedQuote.CustomerNumber,
                    RequiresGenericLocation = selectedQuote.Product.RequiresGenericLocation,
                    Subject = productSubjectTypeName,
                    BookingAttributeResponse = bookingAttributes,
                    LocationFieldResponses = locationFieldResponses,
                    QuotePreference = selectedQuote.QuoteType.Name
                };

                return ResponseFactory.GetSuccessResponse<BookingQuoteResponse>(bookingQuoteResponse,"Quotations retrieved successfully!");
            }
                
        }

        //public async Task<BaseResponse<PaginatedCustomerResponse>> GetCustomerDetails(string customer, int pageNumber = 1, int pageSize = 10)
        //{
        //    var response = new BaseResponse<PaginatedCustomerResponse>();
        //    var customerLower = customer.ToLower();

        //    var query = _rubyDbContext.Customers
        //        .Include(d => d.CustomerBankAccounts)
        //            .ThenInclude(d => d.BankAccount)
        //            .ThenInclude(d => d.BankLookup)
        //        .Include(d => d.CustomerPhoneBooks)
        //        .Include(d => d.Gender)
        //        .Where(d =>
        //            d.CustomerNumber.Contains(customer) ||
        //            (d.FirstName + " " + d.LastName).ToLower().Contains(customerLower) ||
        //            d.Email.ToLower().Contains(customerLower));

        //    var totalCount = await query.CountAsync();

        //    var paginatedCustomers = await query
        //        .Skip((pageNumber - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToListAsync();

        //    var customerBookings = paginatedCustomers.Select(customer => new CustomerBookingResponse
        //    {
        //        CustomerInformationResponses = new CustomerInformationResponse
        //        {
        //            CustomerName = $"{customer.FirstName} {customer.LastName}",
        //            CustomerNumber = customer.CustomerNumber,
        //            CustomerEmail = customer.Email,
        //            CustomerPhone = customer.CustomerPhoneBooks.FirstOrDefault()?.PhoneNumber,
        //            Gender = customer.Gender?.Name,
        //            DateOfBirth = customer.DateOfBirth ?? DateTime.MinValue
        //        },
        //        BankAccountResponses = customer.CustomerBankAccounts.Select(account => new BankAccountResponse
        //        {
        //            BankName = account.BankAccount?.BankLookup?.Name,
        //            AccountName = account.BankAccount?.AccountName,
        //            AccountNumber = account.BankAccount?.AccountNumber
        //        }).ToList()
        //    }).ToList();

        //    if (customerBookings.Any())
        //    {
        //        response.Success = true;
        //        response.ResponseMessage = "Matching customers retrieved successfully";
        //        response.StatusCode = HttpStatusCode.OK;
        //        response.Data = new PaginatedCustomerResponse
        //        {
        //            Customers = customerBookings,
        //            TotalCount = totalCount,
        //            PageNumber = pageNumber,
        //            PageSize = pageSize,
        //            TotalPages = (int)Math.Ceiling((double)totalCount / pageSize)
        //        };
        //        return response;
        //    }

        //    // If no customer found, try adding a lead

        //    // No matching customer or lead found
        //    return new BaseResponse<PaginatedCustomerResponse>
        //    {
        //        Success = false,
        //        StatusCode = HttpStatusCode.NotFound,
        //        ResponseMessage = "No customer found with the provided"
        //    };
        //}

        public async Task<BaseResponse<PaginatedCustomerResponse>> GetCustomerDetails(string customer, int pageNumber = 1, int pageSize = 10)
        {
            var response = new BaseResponse<PaginatedCustomerResponse>();
            var customerLower = customer.ToLower();

            async Task<BaseResponse<PaginatedCustomerResponse>> SearchCustomers()
            {
                var query = _rubyDbContext.Customers
                    .Include(d => d.CustomerBankAccounts)
                        .ThenInclude(d => d.BankAccount)
                        .ThenInclude(d => d.BankLookup)
                    .Include(d => d.CustomerPhoneBooks)
                    .Include(d => d.Gender)
                    .Where(d =>
                        d.CustomerNumber.Contains(customer) ||
                        (d.FirstName + " " + d.LastName).ToLower().Contains(customerLower) ||
                        d.Email.ToLower().Contains(customerLower));

                var totalCount = await query.CountAsync();

                var paginatedCustomers = await query
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var customerBookings = paginatedCustomers.Select(customer => new CustomerBookingResponse
                {
                    CustomerInformationResponses = new CustomerInformationResponse
                    {
                        CustomerName = $"{customer.FirstName} {customer.LastName}",
                        CustomerNumber = customer.CustomerNumber,
                        CustomerEmail = customer.Email,
                        CustomerPhone = customer.CustomerPhoneBooks.FirstOrDefault()?.PhoneNumber,
                        Gender = customer.Gender?.Name,
                        DateOfBirth = customer.DateOfBirth ?? DateTime.MinValue
                    },
                    BankAccountResponses = customer.CustomerBankAccounts.Select(account => new BankAccountResponse
                    {
                        BankName = account.BankAccount?.BankLookup?.Name,
                        AccountName = account.BankAccount?.AccountName,
                        AccountNumber = account.BankAccount?.AccountNumber
                    }).ToList()
                }).ToList();

                if (customerBookings.Any())
                {
                    return new BaseResponse<PaginatedCustomerResponse>
                    {
                        Success = true,
                        ResponseMessage = "Matching customers retrieved successfully",
                        StatusCode = HttpStatusCode.OK,
                        Data = new PaginatedCustomerResponse
                        {
                            Customers = customerBookings,
                            TotalCount = totalCount,
                            PageNumber = pageNumber,
                            PageSize = pageSize,
                            TotalPages = (int)Math.Ceiling((double)totalCount / pageSize)
                        }
                    };
                }

                return null;
            }

            // 🔍 First try to search existing customer
            var existingResult = await SearchCustomers();
            if (existingResult != null)
                return existingResult;

            // 🆕 If not found, pull from leads and add customer
            var leadResponse = await _larmsService.SearchLaramsLeadsAsync(customer);

            if (leadResponse.Status && leadResponse.Data != null && leadResponse.Data.Any())
            {
                var lead = leadResponse.Data.First();

                var newCustomer = new Customer
                {
                    CustomerNumber = lead.LeadNumber,
                    CustomerType = lead.CustomerType,
                    Email = lead.EmailAddress,
                    LeadId = lead.Uid,
                    FullAddress = lead.FullAddress,
                    PayableLedger = lead.PayableLedger,
                    ReceivableLedger = lead.ReceivableLedger,
                    PhoneNumber = lead.PhoneNumber,
                    DateOfBirth = lead.DateOfBirth,
                    FirstName = lead.Name
                };

                _rubyDbContext.Customers.Add(newCustomer);
                var saveResult = await _rubyDbContext.SaveChangesAsync();

                if (saveResult > 0)
                {
                    // 🔄 Re-query now that the customer is added
                    var retryResult = await SearchCustomers();
                    if (retryResult != null)
                        return retryResult;
                }

                return ResponseFactory.CreateError<PaginatedCustomerResponse>("Customer created but retrieval failed", HttpStatusCode.InternalServerError);
            }

            // ❌ Nothing found
            return new BaseResponse<PaginatedCustomerResponse>
            {
                Success = false,
                StatusCode = HttpStatusCode.NotFound,
                ResponseMessage = "No customer or matching lead found with the provided information"
            };
        }

        public async Task<BaseResponse<GenericNameResponse>> GetNewCustomer(string customer)
        {
            try
            {
                var leadResponse = await _larmsService.SearchLaramsLeadsAsync(customer);

                if (leadResponse.Status && leadResponse.Data != null && leadResponse.Data.Any())
                {
                    var lead = leadResponse.Data.First();

                    var newCustomer = new Customer
                    {
                        CustomerNumber = lead.LeadNumber,
                        CustomerType = lead.CustomerType,
                        Email = lead.EmailAddress,
                        LeadId = lead.Uid,
                        FullAddress = lead.FullAddress,
                        PayableLedger = lead.PayableLedger,
                        ReceivableLedger = lead.ReceivableLedger,
                        PhoneNumber = lead.PhoneNumber,
                        DateOfBirth = lead.DateOfBirth,
                        FirstName = lead.Name
                    };

                    _rubyDbContext.Customers.Add(newCustomer);
                    var saveResult = await _rubyDbContext.SaveChangesAsync();

                    return saveResult > 0
                        ? ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Customer saved successfully", HttpStatusCode.Created)
                        : ResponseFactory.CreateError<GenericNameResponse>("Failed to save customer", HttpStatusCode.InternalServerError);
                }

                return ResponseFactory.CreateError<GenericNameResponse>("No lead data found", HttpStatusCode.NotFound);


                return ResponseFactory.CreateError<GenericNameResponse>("No lead data found", HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                // Optionally log ex here
                return ResponseFactory.CreateError<GenericNameResponse>($"Error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }


        public async Task<BaseResponse<PolicyCodeBookingResponses>> BookingCustomerInformation(CustomerInformationRequest request)
        {
            var response = new BaseResponse<PolicyCodeBookingResponses>();

            // Fetch customer details
            var customerDetails = await _rubyDbContext.Customers
                .FirstOrDefaultAsync(d => d.CustomerNumber == request.CustomerNumber ||
                                          (d.FirstName + " " + d.LastName).ToLower() == request.CustomerNumber ||
                                          d.Email.ToLower() == request.CustomerNumber);

            if (customerDetails == null)
            {
                response.Success = false;
                response.ResponseMessage = "Customer not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Fetch the quotation
            var quotation = await _rubyDbContext.Quotations
                .FirstOrDefaultAsync(d => d.Id == request.QuoteId);

            if (quotation == null)
            {
                response.Success = false;
                response.ResponseMessage = "Quotation not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Generate the booking code if creating a new booking
            var bookingCode = GetNextPolicyCode(_rubyDbContext).ToString();

            DateTime queStartTime = DateTime.UtcNow.AddMinutes(-30);
            DateTime slaDeadline = DateTime.UtcNow.AddHours(4);



            // Check if booking exists, else create a new one
            var booking = await _rubyDbContext.PolicyBookings
                .Include(d => d.Quotation)
                .FirstOrDefaultAsync(b => b.Customer == request.CustomerNumber && b.QuotationId == request.QuoteId);


           

            if (booking == null)
            {

                //string requireUnderWirte;

                //var productRequiresUnderWriting = booking.Quotation.Product.RequireUnderWritingAtBooking;
                //if(productRequiresUnderWriting == true)
                //{
                //    requireUnderWirte = QuotationStatus.RequireUnderWriting.ToString();
                //}
                //else
                //{
                //    requireUnderWirte = QuotationStatus.Approved.ToString();
                //}


                booking = new PolicyBooking
                {
                    Customer = request.CustomerNumber,
                    CustomerName = $"{customerDetails.FirstName} {customerDetails.LastName}",
                    PolicyId = bookingCode,
                    QuotationId = request.QuoteId,
                    ProductId = quotation.ProductId,
                    SumInsured = quotation.SumInsured,
                    IsActive = false,
                    CreatedBy = UserClaims(),
                    SaveState = PolicyBookingStatus.CustomerInformation.GetDescription(),
                    Status = "Pending",
                    BookingDate = DateTime.UtcNow,
                    TimeInQue = TimeOnly.FromTimeSpan(DateTime.UtcNow - queStartTime),
                    SlaPerformance = slaDeadline
                };

                _rubyDbContext.PolicyBookings.Add(booking);
            }
            else
            {
                // Update existing booking details
                booking.CustomerName = $"{customerDetails.FirstName} {customerDetails.LastName}";
                booking.ProductId = quotation.ProductId;
                booking.SumInsured = quotation.SumInsured;
                booking.Status = QuotationStatus.RequireUnderWriting.ToString();
                booking.TimeInQue = TimeOnly.FromTimeSpan(DateTime.UtcNow - queStartTime);
                booking.SlaPerformance = slaDeadline;
                booking.SaveState = PolicyBookingStatus.CustomerInformation.GetDescription();
                booking.BookingDate = DateTime.UtcNow;

                _rubyDbContext.PolicyBookings.Update(booking);
            }

            await _rubyDbContext.SaveChangesAsync();

            // Add or update BookingSubjectAttributes
            await AddBookingSubjectAttributes(request.BookingSubjectAttributeRequests, booking.Id);

            // Add or update GenericLocationAttributes
            await AddGenericLocationAttributes(request.GenericLocationAttributeDtos, booking.Id);

            // Commit the transaction
            await _rubyDbContext.SaveChangesAsync();

            var codeResponse = new PolicyCodeBookingResponses
            {
                BookingCode = booking.PolicyId,
                BookingId = booking.Id
            };

            response.Success = true;
            response.ResponseMessage = "Booking created/updated successfully.";
            response.Data = codeResponse;
            response.StatusCode = HttpStatusCode.Created;

            return response;
        }
        private async Task AddBookingSubjectAttributes(List<BookingSubjectAttributeRequest> bookingSubjectRequests, int bookingId)
        {
            foreach (var bookingSubjectRequest in bookingSubjectRequests)
            {
                foreach (var attr in bookingSubjectRequest.BookingSubjectAttributeRequests)
                {
                    var attribute = await _rubyDbContext.ProductSubjectTypeAttributes
                        .Where(d => d.Name == attr.AttributeName)
                        .FirstOrDefaultAsync();

                    var bookingSubject = new BookingSubjectAttribute
                    {
                        BookingId = bookingId,
                        AttributeName = attr.AttributeName,
                        AttributeValue = attr.AttributeValue?.ToString(),
                        AttributeId = attribute.Id,
                        EntityId = attr.EntityId != Guid.Empty ? attr.EntityId : Guid.NewGuid()
                    };

                    // Check if the attribute already exists, update if it does, or add if not
                    var existingBookingSubject = await _rubyDbContext.BookingSubjectAttributes
                        .FirstOrDefaultAsync(b => b.BookingId == bookingId && b.AttributeName == attr.AttributeName);

                    if (existingBookingSubject != null)
                    {
                        existingBookingSubject.AttributeValue = bookingSubject.AttributeValue;
                        existingBookingSubject.EntityId = bookingSubject.EntityId;
                        _rubyDbContext.BookingSubjectAttributes.Update(existingBookingSubject);
                    }
                    else
                    {
                        _rubyDbContext.BookingSubjectAttributes.Add(bookingSubject);
                    }
                }
            }

            await _rubyDbContext.SaveChangesAsync();
        }
        private async Task AddGenericLocationAttributes(List<GenericLocationAttributeDto> locationAttributeDtos, int bookingId)
        {
            var attributesToAdd = new List<PolicyBookingGenericLocation>();

            foreach (var locationAttributeDto in locationAttributeDtos)
            {
                var productGenericLocation = await _rubyDbContext.ProductGenericLocations
                    .FirstOrDefaultAsync(p => p.Id == locationAttributeDto.ProductGenericLocationId);
                var entityId = Guid.NewGuid();
                if (productGenericLocation != null)
                {
                    var locationAttributeResponse = new PolicyBookingGenericLocation
                    {
                        PolicyBookingId = bookingId,
                        FieldName = locationAttributeDto.AttributeName,
                        FieldValue = locationAttributeDto.AttributeValue,
                        EntityId = entityId,
                        GenericLocationId = locationAttributeDto.ProductGenericLocationId
                    };

                    // Check if the location attribute already exists, update if it does, or add if not
                    var existingLocationAttribute = await _rubyDbContext.PolicyBookingGenericLocations
                        .FirstOrDefaultAsync(l => l.PolicyBookingId == bookingId && l.GenericLocationId == locationAttributeDto.ProductGenericLocationId);

                    if (existingLocationAttribute != null)
                    {
                        existingLocationAttribute.FieldValue = locationAttributeResponse.FieldValue;
                        existingLocationAttribute.EntityId = locationAttributeResponse.EntityId;
                        _rubyDbContext.PolicyBookingGenericLocations.Update(existingLocationAttribute);
                    }
                    else
                    {
                        attributesToAdd.Add(locationAttributeResponse);
                    }
                }
            }

            if (attributesToAdd.Any())
            {
                _rubyDbContext.PolicyBookingGenericLocations.AddRange(attributesToAdd);
                await _rubyDbContext.SaveChangesAsync();
            }
        }

        public async Task<BaseResponse<PolicyCodeBookingResponses>> BookingBusinessInformation(BookingBusinessInformationRequest request)
        {
            var response = new BaseResponse<PolicyCodeBookingResponses>();

            // Check if PolicyBooking exists
            var policy = await _rubyDbContext.PolicyBookings.Include(d => d.Quotation)
                .FirstOrDefaultAsync(d => d.Id == request.BookingId);
            if (policy == null)
            {
                response.Success = false;
                response.ResponseMessage = "Invalid BookingId.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Check if BookingBusinessInformation exists
            var booking = await _rubyDbContext.BookingBusinessInformation
                .FirstOrDefaultAsync(b => b.BookingId == request.BookingId);

            if (booking == null)
            {
                // Create a new BookingBusinessInformation
                booking = new BookingBusinessInformation
                {
                    BookingId = request.BookingId,
                    AdditionalInformation = request.AdditionalInformation,
                    BusinessSource = request.BusinessSource,
                    BusinessType = request.BusinessType,
                };
                _rubyDbContext.Add(booking);
                await _rubyDbContext.SaveChangesAsync();
            }
            else
            {
                // Update existing BookingBusinessInformation
                booking.AdditionalInformation = request.AdditionalInformation;
                booking.BusinessSource = request.BusinessSource;
                booking.BusinessType = request.BusinessType;

                _rubyDbContext.Update(booking);
            }

            // Handle Business Source - Brokered
            if (request.BusinessSource == BusinessSource.BusinessIsBrokered.GetDescription())
            {
                var existingBrokerDetail = await _rubyDbContext.BusinessBrokeredDetails
                    .FirstOrDefaultAsync(d => d.BusinessInfoId == booking.Id);

                if (existingBrokerDetail != null)
                {
                    existingBrokerDetail.BrokerId = request.BrokeredId; // Update BrokerId if needed
                    _rubyDbContext.Update(existingBrokerDetail);
                }
                else
                {
                    // Create new BrokeredDetail if it doesn't exist
                    BusinessBrokeredDetail newDetail = new()
                    {
                        BusinessInfoId = booking.Id,
                        BrokerId = request.BrokeredId
                    };
                    _rubyDbContext.Add(newDetail);
                }
            }

            // Handle Business Type - Insurance
            if (request.BusinessType == BusinessTypeValue.CoInsurance.GetDescription())
            {
                if (request.BusinessTypeRequest == null || !request.BusinessTypeRequest.Any())
                {
                    response.Success = false;
                    response.ResponseMessage = "BusinessTypeRequest is required for Insurance.";
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                }

                // Remove existing CoInsuranceDetails if business type is Insurance
                var existingCoInsuranceDetails = await _rubyDbContext.CoInsuranceDetails
                    .Where(d => d.BusinessInfoId == booking.Id)
                    .ToListAsync();
                _rubyDbContext.RemoveRange(existingCoInsuranceDetails);

                foreach (var attr in request.BusinessTypeRequest)
                {
                    // Add new CoInsuranceDetails for Insurance
                    CoInsuranceDetail newDetail = new()
                    {
                        BusinessInfoId = booking.Id,
                        InsurerId = attr.InsurerId,
                        Portion = attr.Portion,
                        IsLead = attr.IsLead
                    };
                    _rubyDbContext.Add(newDetail);
                }
                if (string.IsNullOrEmpty(request.AdditionalInformation))
                    return ResponseFactory.CreateError<PolicyCodeBookingResponses>("Please select Additional Information",HttpStatusCode.BadRequest);
            }

            // Handle Business Type - Facultative Inward
            if (request.BusinessType == "Facultative Inward")
            {
                // Remove existing CoInsuranceDetails if switching to Facultative Inward
                var existingCoInsuranceDetails = await _rubyDbContext.CoInsuranceDetails
                    .Where(d => d.BusinessInfoId == booking.Id)
                    .ToListAsync();
                _rubyDbContext.RemoveRange(existingCoInsuranceDetails);

                // Check if the FacultativeInsurer already exists for this BusinessInfoId and InsurerId
                var existingFacultative = await _rubyDbContext.FacultativeInsurers
                    .FirstOrDefaultAsync(f => f.BusinessInfoId == booking.Id && f.InsurerId == request.Insurer);

                if (existingFacultative != null)
                {

                    existingFacultative.InsurerId = request.Insurer; // Update other fields if needed
                    _rubyDbContext.Update(existingFacultative);
                }
                else
                {
                    // If it doesn't exist, create a new FacultativeInsurer
                    FacultativeInsurer facultative = new()
                    {
                        BusinessInfoId = booking.Id,
                        InsurerId = request.Insurer,
                    };
                    _rubyDbContext.Add(facultative);
                }
            }

            policy.SaveState = DisplayPolicyStatusDescription(PolicyBookingStatus.BookingInformation);

            await _rubyDbContext.SaveChangesAsync();

            // Prepare the response data
            PolicyCodeBookingResponses code = new()
            {
                BookingId = request.BookingId,
                CustomerNumber = policy.Customer,
                Premium = policy.Quotation.Premium
            };

            // Return Response
            response.Success = true;
            response.ResponseMessage = booking.Id == 0
                ? "Business information created successfully."
                : "Business information updated successfully.";
            response.StatusCode = HttpStatusCode.Created;
            response.Data = code;
            return response;
        }
        public async Task<BaseResponse<PolicyCodeBookingResponses>> BookingDetails(BookingDetailsFormData formData)
        {
            var response = new BaseResponse<PolicyCodeBookingResponses>();
            var request = JsonConvert.DeserializeObject<BookingDetailsRequest>(formData.RequestJson);


            var policyBooking = await _rubyDbContext.PolicyBookings
                   .FirstOrDefaultAsync(d => d.Id == request.PolicyId);

            if (policyBooking == null)
            {
                response.Success = false;
                response.ResponseMessage = "Policy not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            using var transaction = await _rubyDbContext.Database.BeginTransactionAsync();



            var bookingDetail = await _rubyDbContext.BookingDetail
                .FirstOrDefaultAsync(d => d.BookingId == policyBooking.Id);

            var paymentTypeDetails = await _rubyDbContext.PolicyBookingPaymentTypes
                .FirstOrDefaultAsync(d => d.Id == request.PaymentType);



            if (bookingDetail == null)
            {

                // Insert new BookingDetail
                bookingDetail = new BookingDetail
                {
                    BookingId = policyBooking.Id,
                    PaymentType = paymentTypeDetails.Name,
                    PolicyActiveStateDate = request.PolicyStartDate,
                    PolicyActiveEndDate = request.PolicyEndDate,
                    Duration = request.Duration,
                    PaymentCycle = request.PaymentCycle,
                    InitiatedWithCreditNote = paymentTypeDetails.Name == "Credit Note" ? true : false,
                };

                _rubyDbContext.BookingDetail.Add(bookingDetail);
                await _rubyDbContext.SaveChangesAsync();

                // Delete any previous EligibilityPeriods for this booking
                var existingEligibilityPeriods = await _rubyDbContext.EligibilityPeriods
                    .Where(e => e.BookingId == bookingDetail.BookingId)
                    .ToListAsync();
                _rubyDbContext.EligibilityPeriods.RemoveRange(existingEligibilityPeriods);
            }
            else
            {
                // Update existing BookingDetail
                bookingDetail.PaymentType = paymentTypeDetails.Name;
                bookingDetail.PolicyActiveStateDate = request.PolicyStartDate;
                bookingDetail.PolicyActiveEndDate = request.PolicyEndDate;
                bookingDetail.Duration = request.Duration;
                bookingDetail.PaymentCycle = request.PaymentCycle;
                bookingDetail.InitiatedWithCreditNote = paymentTypeDetails.Name == "Credit Note" ? true : false;
                _rubyDbContext.BookingDetail.Update(bookingDetail);
            }

           
            // Handle PaymentType logic (Cash Payment or Credit Note)
            if (paymentTypeDetails.Name == "Cash Payment")
            {
                // Remove existing Credit Note Payment if it exists
                var existingCreditNotePayment = await _rubyDbContext.CreditNotePayments
                    .FirstOrDefaultAsync(p => p.BookingDetailId == bookingDetail.Id);

                if (existingCreditNotePayment != null)
                {
                    _rubyDbContext.CreditNotePayments.Remove(existingCreditNotePayment);
                }

                // Add Cash Payment if not exists
                var existingCashPayment = await _rubyDbContext.PaymentTypeBookingDetails
                    .FirstOrDefaultAsync(p => p.BookingDetailId == bookingDetail.Id);

                if (existingCashPayment == null)
                {
                    var payment = new PaymentTypeBookingDetail
                    {
                        BookingDetailId = bookingDetail.Id,
                        VoucherType = paymentTypeDetails.Name
                    };
                    _rubyDbContext.PaymentTypeBookingDetails.Add(payment);
                }

                var existingEligibility = await _rubyDbContext.EligibilityPeriods
                        .Where(e => e.BookingId == bookingDetail.BookingId)
                        .ToListAsync();

                if (existingEligibility.Any())
                {
                    _rubyDbContext.EligibilityPeriods.RemoveRange(existingEligibility);
                }
                // Handle Eligibility Periods for Cash Payment
                foreach (var eligibility in request.Eligibility)
                {
                    // Check if the EligibilityPeriod exists with the same ReceiptReference
                   
                        // Add new EligibilityPeriod if it doesn't exist
                        var newEligibility = new EligibilityPeriod
                        {
                            BookingId = bookingDetail.BookingId,
                            EligibilityStartDate = eligibility.PolicyStartDate,
                            EligibilityEndDate = eligibility.PolicyEndDate,
                            DurationInMonths = eligibility.Duration,
                            Remarks = "Initial payment",
                            VoucherAmount = eligibility.Amount,
                            ReceiptReference = eligibility.ReceiptReference ?? "FIN031160",

                        };
                        await _rubyDbContext.EligibilityPeriods.AddAsync(newEligibility);
                        
                    
                }
            }
            else if (paymentTypeDetails.Name == "Credit Note")
            {
                // Remove existing Cash Payment if it exists
                var existingCashPayment = await _rubyDbContext.PaymentTypeBookingDetails
                    .FirstOrDefaultAsync(p => p.BookingDetailId == bookingDetail.Id);

                if (existingCashPayment != null)
                {
                    _rubyDbContext.PaymentTypeBookingDetails.Remove(existingCashPayment);
                }

                // Handle file upload for Credit Note Payment
                string documentName = null;

                var creditNote = await _fileService.UploadFile(formData.UploadCreditNote);

                if (creditNote.Status == FileUploadStatus.Successful)
                {
                    documentName = creditNote.Document.DocumentName;
                }
                else
                {
                    response.Success = false;
                    response.ResponseMessage = "Credit note upload failed.";
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                }

                // Add or update Credit Note Payment
                var existingCreditNotePayment = await _rubyDbContext.CreditNotePayments
                    .FirstOrDefaultAsync(p => p.BookingDetailId == bookingDetail.Id);

                if (existingCreditNotePayment != null)
                {
                    // Update existing Credit Note Payment if exists
                    existingCreditNotePayment.CreditNote = documentName;
                    _rubyDbContext.CreditNotePayments.Update(existingCreditNotePayment);
                }
                else
                {
                    // Add new Credit Note Payment if none exists
                    var creditNotePayment = new CreditNotePayment
                    {
                        BookingDetailId = bookingDetail.Id,
                        CreditNote = documentName
                    };

                    _rubyDbContext.CreditNotePayments.Add(creditNotePayment);
                }

                var existingEligibility = await _rubyDbContext.EligibilityPeriods
                        .Where(e => e.BookingId == bookingDetail.BookingId)
                        .ToListAsync();

                if (existingEligibility.Any())
                {
                    _rubyDbContext.EligibilityPeriods.RemoveRange(existingEligibility);
                }
                // Handle Eligibility Periods for Credit Note
                foreach (var eligibility in request.Eligibility)
                {
                    // Check if the EligibilityPeriod exists with the same ReceiptReference
                    
                        // Add new EligibilityPeriod if it doesn't exist
                        var newEligibility = new EligibilityPeriod
                        {
                            BookingId = bookingDetail.BookingId,
                            EligibilityStartDate = eligibility.PolicyStartDate,
                            EligibilityEndDate = eligibility.PolicyEndDate,
                            DurationInMonths = eligibility.Duration,
                            VoucherAmount = eligibility.Amount,
                            ReceiptReference = eligibility.ReceiptReference ?? "FIN031160",
                        };
                        await _rubyDbContext.EligibilityPeriods.AddAsync(newEligibility);
                    
                }
            }

            // Save changes and update policy status
            policyBooking.SaveState = PolicyBookingStatus.BookingDetails.GetDescription();
            _rubyDbContext.PolicyBookings.Update(policyBooking);
            await _rubyDbContext.SaveChangesAsync();

            await transaction.CommitAsync();

            var code = new PolicyCodeBookingResponses
            {
                BookingId = request.PolicyId
            };

            response.Success = true;
            response.ResponseMessage = "Booking Details and Eligibility Periods Saved Successfully";
            response.Data = code;
            response.StatusCode = HttpStatusCode.Created;
            return response;
        }

        public async Task<BaseResponse<CustomerIdResponse>> CompleteSBUDetails(SbuSharingRequest request)
        {
            var response = new BaseResponse<CustomerIdResponse>();

            // Validate input
            if (request.Sbus == null || !request.Sbus.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No SBU details provided.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var policy = await _rubyDbContext.PolicyBookings.FirstOrDefaultAsync(x => x.Id == request.PolicyId);
            if (policy == null)
            {
                response.Success = false;
                response.ResponseMessage = "Policy not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            var customer = await _rubyDbContext.Customers.FirstOrDefaultAsync(d => d.CustomerNumber == policy.Customer);
            if (customer == null)
            {
                response.Success = false;
                response.ResponseMessage = "Customer not found for the policy.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            using var transaction = await _rubyDbContext.Database.BeginTransactionAsync();
            try
            {
                // Step 1: Delete existing SBUs, agents, and sub-agents for the policy
                var existingSbus = await _rubyDbContext.BookingSbus.Where(x => x.BookingId == request.PolicyId).ToListAsync();
                foreach (var sbu in existingSbus)
                {
                    var existingAgents = await _rubyDbContext.BookingSbuAgents.Where(a => a.BookingSbuId == sbu.Id).ToListAsync();
                    foreach (var agent in existingAgents)
                    {
                        var existingSubAgents = await _rubyDbContext.BookingSubSbuAgents.Where(sa => sa.BookingSbuAgentId == agent.Id).ToListAsync();
                        _rubyDbContext.BookingSubSbuAgents.RemoveRange(existingSubAgents); // Remove sub-agents
                    }
                    _rubyDbContext.BookingSbuAgents.RemoveRange(existingAgents); // Remove agents
                }
                _rubyDbContext.BookingSbus.RemoveRange(existingSbus); // Remove SBUs

                // Save changes after deletion
                await _rubyDbContext.SaveChangesAsync();

                // Step 2: Add new SBUs, agents, and sub-agents from the request
                foreach (var sbuRequest in request.Sbus)
                {
                    ValidateSharingPercentage(sbuRequest.SharingPercentage, "SBU");

                    var newSbu = new BookingSbu
                    {
                        BookingId = request.PolicyId,
                        ExternalId = sbuRequest.SubId,
                        Name = sbuRequest.Name,
                        ProportionPercentage = sbuRequest.SharingPercentage,
                        Comments = request.Comments,
                        Location = request.Location
                    };
                    await _rubyDbContext.BookingSbus.AddAsync(newSbu);
                    await _rubyDbContext.SaveChangesAsync();

                    foreach (var participant in sbuRequest.Participants)
                    {
                        ValidateSharingPercentage(participant.SharingPercentage, "Participant");

                        var newAgent = new BookingSbuAgent
                        {
                            BookingSbuId = newSbu.Id,
                            ExternalId = participant.ParticipantsId,
                            Name = participant.Name,
                            ProportionPercentage = participant.SharingPercentage
                        };
                        await _rubyDbContext.BookingSbuAgents.AddAsync(newAgent);
                        await _rubyDbContext.SaveChangesAsync();

                        if (participant.SBUSubAgents != null && participant.SBUSubAgents.Any())
                        {
                            foreach (var subAgent in participant.SBUSubAgents)
                            {
                                ValidateSharingPercentage(subAgent.SharingPercentage, "SubAgent");

                                var newSubAgent = new BookingSubSbuAgent
                                {
                                    BookingSbuAgentId = newAgent.Id,
                                    ExternalId = subAgent.SubAgentId,
                                    FullName = subAgent.Name,
                                    Email= subAgent.Email,
                                    PhoneNumber = subAgent.PhoneNumber,
                                    ProportionPercentage = subAgent.SharingPercentage
                                };
                                await _rubyDbContext.BookingSubSbuAgents.AddAsync(newSubAgent);
                            }
                        }
                    }
                }

                // Update the policy
                policy.SaveState = PolicyBookingStatus.SBUInformation.GetDescription();
                _rubyDbContext.PolicyBookings.Update(policy);

                await _rubyDbContext.SaveChangesAsync();
                await transaction.CommitAsync();

                response.Success = true;
                response.ResponseMessage = "SBU details processed successfully.";
                response.Data = new CustomerIdResponse
                {
                    CustomerId = customer.Id,
                    BookingId = policy.Id
                };
                response.StatusCode = HttpStatusCode.OK;

                return response;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                response.Success = false;
                response.ResponseMessage = $"An error occurred while processing SBU details. {ex.Message}";
                response.StatusCode = HttpStatusCode.InternalServerError;
                return response;
            }
        }
        public async Task<BaseResponse<GenericNameResponse>> Documentation(DocumentationRequest request)
        {
            var response = new BaseResponse<GenericNameResponse>();         

            var policy = await _rubyDbContext.PolicyBookings.Include(d => d.Quotation)
                .FirstOrDefaultAsync(d => d.Id == request.policyId);

            if (policy == null)
            {
                response.Success = false;
                response.ResponseMessage = "Policy not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            
            

            policy.DocumentationComment = request.comment;
            policy.SaveState = PolicyBookingStatus.Documentation.GetDescription();
            _rubyDbContext.PolicyBookings.Update(policy);


            await _rubyDbContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = "Documents uploaded successfully.";
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<PaginatedBookingResponse>> GetAllBooking(FilterBookingRequestDto request)
        {
            var response = new BaseResponse<PaginatedBookingResponse>();
            var query = _rubyDbContext.PolicyBookings.
                Include(d => d.Quotation).ThenInclude(p => p.Product)
               .AsNoTracking()
               .OrderByDescending(p => p.DateCreated)


            .Select(qt => new PolicyBookingResponse
            {
                Id = qt.Id,
                BookingCode = qt.PolicyId,
                PolicyKey = qt.PolicyKey,
                BookedBy = qt.CustomerName,
                BookingDate = qt.BookingDate,
                QuoteId = qt.Quotation.Id,
                QuotationId = qt.Quotation.QuoteId,
                TimeInQue = qt.TimeInQue,
                SlA = qt.SlaPerformance,
                Status = qt.Status,
                QuoteType = qt.Quotation.QuoteType.Name
            });


            if (request.CreateDateFrom.HasValue)
            {
                query = query.Where(qt => qt.DateCreated >= request.CreateDateFrom.Value);
            }

            if (request.CreateDateTo.HasValue)
            {
                query = query.Where(qt => qt.DateCreated <= request.CreateDateTo.Value);
            }

            if (!string.IsNullOrEmpty(request.BookingCode))
            {
                query = query.Where(qt => qt.BookingCode == request.BookingCode);
            }

            var pagedBooking = await PagedList<PolicyBookingResponse>
                 .ToPagedList(query, request.PageNumber, request.PageSize);

            // Build the response with pagination details
            var paginatedBookingResponse = new PaginatedBookingResponse
            {
                PageNumber = pagedBooking.PageNumber,
                PageSize = pagedBooking.PageSize,
                TotalCount = pagedBooking.TotalCount,
                TotalPages = pagedBooking.TotalPages,
                HasPreviousPage = pagedBooking.HasPreviousPage,
                HasNextPage = pagedBooking.HasNextPage,
                PolicyBookingResponse = pagedBooking.ToList()
            };

            // Set response properties
            response.Success = true;
            response.ResponseMessage = "Quotations fetched successfully";
            response.Data = paginatedBookingResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;


        }
        public async Task<BaseResponse<SinglePolicyBookingResponse>> GetSingleBooking(int? bookingId, int? quoteId)
        {
            var response = new BaseResponse<SinglePolicyBookingResponse>();

            // Load the booking with all its related entities (optimized)
            var booking = await _rubyDbContext.PolicyBookings
                .Include(d => d.Quotation)
                    .ThenInclude(d => d.QuoteType)
                .Include(d => d.Quotation)
                    .ThenInclude(p => p.Product)
                    .ThenInclude(p => p.ProductSubjectTypes)
                .Include(d=>d.BookingBusinessInformation)
                .Include(d => d.BookingSubjectAttributes)
                .Include(d => d.BookingDetails)
                    .ThenInclude(d => d.PaymentTypeBookings)
                .Include(d => d.BookingDetails)
                    .ThenInclude(d => d.CreditNotePayments)
                .Include(d => d.PolicyBookingGenericLocation)
                .Where(d => d.Id == bookingId || d.QuotationId == quoteId)
                .FirstOrDefaultAsync();

            if (booking == null)
            {
                response.Success = false;
                response.ResponseMessage = "Booking not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Process booking attributes
            var bookingAttributes = booking.BookingSubjectAttributes?
                .GroupBy(attr => attr.EntityId)
                .Select(group => new BookingAttributeResponse
                {
                    EntityId = group.Key,
                    QuoteAttributes = group.Select(attr => new QuoteAttributeResponse
                    {
                        Id = attr.Id,
                        AttributeId = attr.AttributeId,
                        AttributeName = attr.AttributeName,
                        AttributeValue = attr.AttributeValue
                    }).ToList()
                }).ToList();




            // Retrieve customer details
            var customerDetails = await _rubyDbContext.Customers
                .Include(d => d.CustomerBankAccounts)
                    .ThenInclude(d => d.BankAccount)
                    .ThenInclude(d => d.BankLookup)
                .Include(d => d.CustomerPhoneBooks)
                .Include(d => d.Gender)
                .FirstOrDefaultAsync(d => d.CustomerNumber == booking.Customer);

            if (customerDetails == null)
            {
                response.Success = false;
                response.ResponseMessage = "Customer not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Map customer information
            var customerInformation = new CustomerInformationResponse
            {
                CustomerName = $"{customerDetails.FirstName} {customerDetails.LastName}",
                CustomerNumber = customerDetails.CustomerNumber,
                CustomerId = customerDetails.Id,
                CustomerEmail = customerDetails.Email,
                CustomerPhone = customerDetails.CustomerPhoneBooks.FirstOrDefault()?.PhoneNumber,
                Gender = customerDetails?.Gender?.Name,
                DateOfBirth = customerDetails.DateOfBirth ?? DateTime.MinValue
            };

            // Map bank account details
            var bankAccounts = customerDetails.CustomerBankAccounts.Select(account => new BankAccountResponse
            {
                BankName = account.BankAccount?.BankLookup?.Name,
                AccountName = account.BankAccount?.AccountName,
                AccountNumber = account.BankAccount?.AccountNumber
            }).ToList();

            // Create the customer booking response
            var customerBooking = new CustomerBookingResponse
            {
                CustomerInformationResponses = customerInformation,
                BankAccountResponses = bankAccounts
            };

            // Map quotation details
            var quotationDetails = new BookingQuoteDetail
            {
                QuoteId = booking.Quotation?.QuoteId,
                QuoteType = booking.Quotation?.QuoteType?.Name,
                Customer = $"{customerDetails?.FirstName} {customerDetails?.LastName}",
                Product = booking.Quotation?.Product?.Name,
                FinalQuoteReviewedBy = booking.Quotation?.CreateBy,
                CreatedDate = booking.Quotation?.DateCreated.Date,
                Time = booking.Quotation != null
                        ? TimeOnly.FromDateTime(booking.Quotation.DateCreated)
                        : null
            };

            // Ensure BookingDetails exists before accessing its first element
            var bookingDetail = booking.BookingDetails?.FirstOrDefault();

            var creditNoteDocument = bookingDetail?.CreditNotePayments?.FirstOrDefault()?.CreditNote;

            string fileImage = null;

            var fileResponse = await _fileService.GetFile(creditNoteDocument);
            if (fileResponse.Success == true && fileResponse.Data != null)
            {
                fileImage = fileResponse.Data.FileContentBase64;
            }
            else
            {
                fileImage = null;
            }



            // Map the booking detail response
            var bookingDetailResponse = new BookingDetailResponse
            {
                Id = bookingDetail?.Id,
                PaymentType = bookingDetail?.PaymentType,
                PolicyActiveStateDate = bookingDetail?.PolicyActiveStateDate,
                PolicyActiveEndDate = bookingDetail?.PolicyActiveEndDate,
                Duration = bookingDetail?.Duration,
                PaymentCycle = bookingDetail?.PaymentCycle,
                PaymentVoucherResponse = bookingDetail?.PaymentTypeBookings?.FirstOrDefault() != null
                    ? new PaymentVoucherResponse
                    {
                        VoucherType = bookingDetail?.PaymentTypeBookings?.FirstOrDefault()?.VoucherType
                    }
                    : null,

                CreditNoteResponse = new CreditNoteResponse
                {
                    Document = fileImage
                },
                EligibilityResponses = (await GetEligibilityResponses(booking.Id))?.Data


            };


            var bookingBusinessInfo = booking.BookingBusinessInformation?.FirstOrDefault();
            var bookingBusinessInformationResponse = bookingBusinessInfo != null
                ? await GetSingleBookingBusinessInformation(bookingBusinessInfo.Id)
                : null;




            var sbuDetailsResponse = await GetSbuDetails(booking.Id);
            SbuDetailResponse sbuDetails = null;

            if (sbuDetailsResponse.Success && sbuDetailsResponse.Data != null)
            {
                sbuDetails = sbuDetailsResponse.Data;
            }



            var locationResponse = await GetLocationAttributes(booking.Id);
            List<GenericLocationAttributeResponse> locationFieldResponses = null;
            if (locationResponse?.Success == true)
            {
                locationFieldResponses = locationResponse.Data;
            }



            var quoteSubjectType = await _adminService.GetSubjectType(booking.Quotation.Product.ProductSubjectTypes.FirstOrDefault()?.Id ?? 0);

            var quoteSubjectTypeName = quoteSubjectType.Data;


            // Map the single policy booking response
            var bookingResponse = new SinglePolicyBookingResponse
            {
                BookingId = booking.Id,
                QuotationId = booking.QuotationId,
                ProductId = booking.Quotation.ProductId,
                CustomerBooking = customerBooking,
                Subject = quoteSubjectTypeName,
                PolicyId = booking.PolicyId,
                SumInsured = booking.SumInsured,
                IsActive = booking.IsActive ? 1 : 0,
                CreatedBy = booking.CreatedBy,
                SaveState = booking.SaveState,
                BookingAttributeResponse = bookingAttributes,
                BookingQuoteDetail = quotationDetails,
                BookingBusinessInformationResponse = bookingBusinessInformationResponse,
                BookingDetailResponse = bookingDetailResponse,
                SbuDetailResponse = sbuDetails,
                DocumentationComment = booking?.DocumentationComment,
                Premium = booking.Quotation.Premium,
                GenericLocationAttributeResponse = locationFieldResponses
            };

            response.Success = true;
            response.ResponseMessage = "Booking retrieved successfully.";
            response.Data = bookingResponse;
            response.StatusCode = HttpStatusCode.OK;

            return response;
        }
        public async Task<BaseResponse<GenericNameResponse>> UploadDocument(DocumentUploadsRequest request)
        {
            var response = new BaseResponse<GenericNameResponse>();

            // Retrieve the policy with its related quotation and product
            var policy = await _rubyDbContext.PolicyBookings
                .Include(d => d.Quotation)
                .ThenInclude(d => d.Product)
                .FirstOrDefaultAsync(d => d.Id == request.policyId);

            if (policy == null || policy.Quotation == null || policy.Quotation.Product == null)
            {
                response.Success = false;
                response.ResponseMessage = "Policy, quotation, or product not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Retrieve the product document category based on the ProductId
            var productDoc = await _rubyDbContext.ProductDocumentCategories
                .FirstOrDefaultAsync(d => d.ProductId == policy.Quotation.Product.Id);

            if (productDoc == null)
            {
                response.Success = false;
                response.ResponseMessage = "Product document category not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Retrieve product document IDs associated with the category
            var productDocumentIds = await _rubyDbContext.ProductDocuments
                .Where(d => d.ProductDocumentCategoryId == productDoc.Id)
                .Select(d => d.Id)
                .ToListAsync();

            //if (!productDocumentIds.Any() || !productDocumentIds.Contains(request.ProductDocumentId))
            //{
            //    response.Success = false;
            //    response.ResponseMessage = "Product document not found.";
            //    response.StatusCode = HttpStatusCode.NotFound;
            //    return response;
            //}

            // Retrieve the product document object
            var productDocument = await _rubyDbContext.ProductDocuments
                .FirstOrDefaultAsync(d => d.Id == request.ProductDocumentId);

            if (productDocument == null)
            {
                response.Success = false;
                response.ResponseMessage = "Product document not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // If no document is uploaded, clear the document name
            if (request.Document == null)
            {
                if (string.IsNullOrEmpty(productDocument.DocumentName))
                {
                    response.Success = false;
                    response.ResponseMessage = "No document uploads found.";
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                }

                productDocument.DocumentName = null;  // Or use "" if you prefer an empty string
                await _rubyDbContext.SaveChangesAsync();

                response.Success = true;
                response.ResponseMessage = "Document name cleared successfully.";
                response.StatusCode = HttpStatusCode.Accepted;
                return response;
            }
            else
            {
                // Handle file upload
                var fileUploadResult = await _fileService.UploadFile(request.Document);

                if (fileUploadResult.Status == FileUploadStatus.Failed)
                {
                    response.Success = false;
                    response.ResponseMessage = fileUploadResult.Message;
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                }

                // Save uploaded document details
                var policyUploadedDocument = new BookingUploadedDocument
                {
                    PolicyDocumentId = request.policyId,
                    ProductDocumentId = request.ProductDocumentId,
                    DocumentName = fileUploadResult.Document.DocumentName,
                };

                _rubyDbContext.BookingUploadedDocuments.Add(policyUploadedDocument);
                await _rubyDbContext.SaveChangesAsync();

                response.Success = true;
                response.ResponseMessage = "Document uploaded successfully.";
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }
        }
        public async Task<BaseResponse<List<VoucherDataResponse>>> GetCustomerVoucher(string customerNumber) {

            var response = new BaseResponse<List<VoucherDataResponse>>();

            var token = await _financeAuthentication.GetAccessToken();

            var apiBaseUrl = _configuration["Finance:VoucherBaseUrl"];
            if (string.IsNullOrEmpty(apiBaseUrl))
            {
                response.Success = false;
                response.ResponseMessage = "VoucherBaseUrl is not configured.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

           
            var apiUrl = apiBaseUrl.Replace("{customerNumber}", customerNumber);

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var httpResponse = await httpClient.GetAsync(apiUrl);

            if (!httpResponse.IsSuccessStatusCode)
            {
                response.Success = false;
                response.ResponseMessage = $"API returned error: {httpResponse.StatusCode} - {httpResponse.ReasonPhrase}";
                response.StatusCode = httpResponse.StatusCode;
                return response;
            }


            //Deserialize Api response 
            var content = await httpResponse.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponse<VoucherDataResponse>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (apiResponse?.Data == null || apiResponse.Data.Count == 0)
            {
                response.Success=false;
                response.ResponseMessage = "No vouchers found";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            //extract the required field 

            var vouchers = apiResponse.Data
                    .Where(d => d.Status == "Not Used" || d.Status == "Partially Used")
                    .Select(d => new VoucherDataResponse
                    {
                        ReceiptNumber = d.ReceiptNumber,
                        Status = d.Status,
                        AmountLeftOnReceipt = d.AmountLeftOnReceipt,
                        TransactionDate = d.TransactionDate
                    })
                    .ToList();


            response.Success = true;
            response.ResponseMessage = "Vouchers retrieved successfully.";
            response.Data = vouchers;
            response.StatusCode = HttpStatusCode.OK;
            return response;


        }
        public async Task<BaseResponse<List<EligibilityResponse>>> CalculateEligibility(EligibilityRequests request)
        {
             var response = new BaseResponse<List<EligibilityResponse>>();
            
                var eligibilityPeriods = new List<EligibilityResponse>();

                // Monthly premium
                decimal monthlyPremium = request.Premium / 12;

                // Start eligibility calculation
                DateTime currentEligibilityStartDate = request.PolicyStartDate;

                foreach (var receipt in request.AmountLeftOnReceipt)
                {
                    decimal amount = receipt.Amount;
                    string receiptReference = receipt.ReceiptReference;

                    // Calculate months covered by the amount
                    int monthsCovered = (int)Math.Floor(amount / monthlyPremium);

                    if (monthsCovered <= 0)
                    {
                        response.Success = false;
                        response.ResponseMessage = $"Amount {amount} (Receipt Reference: {receiptReference}) does not cover any months based on the monthly premium.";
                        response.StatusCode = HttpStatusCode.BadRequest;
                        return response;
                    }

                    // Calculate end date based on the number of months
                    DateTime eligibilityEndDate = currentEligibilityStartDate.AddMonths(monthsCovered).AddDays(-1);

                    // Ensure the eligibility end date does not exceed the policy end date
                    if (eligibilityEndDate > request.PolicyEndDate)
                    {
                        eligibilityEndDate = request.PolicyEndDate;
                    }

                    // Calculate total days covered
                    int totalDays = (eligibilityEndDate - currentEligibilityStartDate).Days + 1;

                    // Determine the sequence
                    string sequence = GetSequence(totalDays);

                    // Add eligibility period to the list
                    eligibilityPeriods.Add(new EligibilityResponse
                    {
                        EligibilityStartDate = currentEligibilityStartDate,
                        EligibilityEndDate = eligibilityEndDate,
                        Duration = totalDays,
                        Sequence = sequence,
                        ReceiptReference = receiptReference ?? "FIN031160",
                        Amount = amount
                        
                    });

                    // Update the next eligibility start date
                    currentEligibilityStartDate = eligibilityEndDate.AddDays(1);

                    // Break if the next start date exceeds the policy end date
                    if (currentEligibilityStartDate > request.PolicyEndDate)
                        break;
                }

                response.Success = true;
                response.ResponseMessage = "Eligibility periods calculated successfully.";
                response.Data = eligibilityPeriods;
                response.StatusCode = HttpStatusCode.OK;
            
       
                return response;
        }
        public async Task<BaseResponse<List<PolicyBookingDocumentResponse>>> PolicyDocumentLookups(int policyId)
        {
            var response = new BaseResponse<List<PolicyBookingDocumentResponse>>();

            
            var policy = await _rubyDbContext.PolicyBookings
                .Include(d => d.Quotation)
                .ThenInclude(d => d.Product)
                .FirstOrDefaultAsync(d => d.Id == policyId);


            var policyDocuments = await _rubyDbContext.ProductDocumentCategories.Include(d=>d.ProductDocuments)
                .Where(d => d.ProductId == policy.Quotation.Product.Id)
                .ToListAsync();

            if (!policyDocuments.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No documents found for the specified policy.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            var bookingDocument = await _rubyDbContext
                    .BookingUploadedDocuments.Where(d => d.PolicyDocumentId == policyId).ToListAsync();
            if (bookingDocument.Any())
            {
                var documentImages = new List<string>();


                foreach (var document in bookingDocument)
                {
                    var fileResponse = await _fileService.GetFile(document.DocumentName);
                    string fileImage = null;

                    if (fileResponse.Success && fileResponse.Data != null)
                    {
                        fileImage = fileResponse.Data.FileContentBase64;
                    }

                    documentImages.Add(fileImage);
                }

                var policyResponses = policyDocuments.SelectMany((category, index) => category.ProductDocuments.Select(doc => new PolicyBookingDocumentResponse
                {
                    ProductDocumentId = doc.Id,
                    DocumentName = doc.Name,
                    IsRequired = doc.IsRequired,
                    FilePath = documentImages.ElementAtOrDefault(index) ?? null
                })).ToList();

                response.Success = true;
                response.ResponseMessage = "Policy documents retrieved successfully.";
                response.Data = policyResponses;
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }
            else
            {
                var policyResponses = policyDocuments.SelectMany((category, index) => category.ProductDocuments.Select(doc => new PolicyBookingDocumentResponse
                {
                    ProductDocumentId = doc.Id,
                    DocumentName = doc.Name,
                    IsRequired = doc.IsRequired,
                })).ToList();

                response.Success = true;
                response.ResponseMessage = "Policy documents retrieved successfully.";
                response.Data = policyResponses;
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }




           

           
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetAllSbu()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
           
            var token = await _adminHelper.GetAccessToken();

            try
            {
                // Get the access token
             
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Configure case-insensitive deserialization
                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var baseUrl = _apiSettings.BaseUrl;
                var divisionResponse = await _httpClient.GetFromJsonAsync<SubAdminApiResponse<Division>>
                    ($"{baseUrl}/Division/Search?Filters.EntityId=1", jsonOptions);
                if (divisionResponse == null || divisionResponse.Payload == null || !divisionResponse.Payload.Any())
                {
                    response.Success = false;
                    response.ResponseMessage = "No divisions found.";
                    response.StatusCode = HttpStatusCode.NotFound;
                    return response;
                }

                var divisionId = divisionResponse.Payload.FirstOrDefault()?.Id ?? 0;

                
                var sbuResponse = await _httpClient.GetFromJsonAsync<SubAdminApiResponse<SbuPayload>>($"{baseUrl}/StructuralBusinessUnit/Search?Filters.DivisionId={divisionId}", jsonOptions);
                if (sbuResponse == null || sbuResponse.Payload == null || !sbuResponse.Payload.Any())
                {
                    response.Success = false;
                    response.ResponseMessage = "No structural business units found.";
                    response.StatusCode = HttpStatusCode.NotFound;
                    return response;
                }

              
                response.Success = true;
                response.ResponseMessage = "Structural Business Units retrieved successfully.";
                response.StatusCode = HttpStatusCode.OK;

                response.Data = sbuResponse.Payload.Select(sbu => new GenericNameResponse
                {
                    Id = sbu.Id,      
                    Name = sbu.Name   
                }).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseMessage = $"An error occurred: {ex.Message}";
                response.StatusCode = HttpStatusCode.InternalServerError;

               
            }

            return response;
        }
        public async Task<BaseResponse<List<SubAgentResponses>>> GetSbuAgent(int structuralBusinessUnitId)
        {
          
                 var token = await _adminHelper.GetAccessToken();
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var baseUrl = _apiSettings.BaseUrl;

                var url = $"{baseUrl}/User/SearchUsers?Filters.StructuralBusinessUnitId={structuralBusinessUnitId}";

                // Configure case-insensitive deserialization
                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Make the request
                var userResponse = await _httpClient.GetFromJsonAsync<SubAdminApiResponse<UserPayload>>(url, jsonOptions);

                if (userResponse == null || userResponse.Payload == null || !userResponse.Payload.Any())
                    return ResponseFactory.CreateError<List<SubAgentResponses>>
                        ("No users found for the specified Structural Business Unit.",HttpStatusCode.NotFound);
             
                // Map the response
              
                var data = userResponse.Payload.Select(user => new SubAgentResponses
                {
                    Id = user.Id, // Convert string to int safely
                    FullName = user.FullName
                }).ToList();

                return ResponseFactory.CreateSuccess<List<SubAgentResponses>>
                    (data, "Users retrieved successfully.");
            }
        public async Task<BaseResponse<List<AgentResponse>>> GetAgentOfSbuAgent(Guid subAgentId)
        {

            var httpClient = new HttpClient();
            var token = await _adminHelper.GetAccessToken(); 

            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var baseUrl = _apiSettings.BaseUrl;
                // Endpoint to get all sub-agents
                var url = $"{baseUrl}/SubAgent/GetAll";

                // Set up JSON options for case-insensitive deserialization
                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Fetch and deserialize the response
                var apiResponse = await httpClient.GetFromJsonAsync<SubAgentAdminApiResponse<List<SubAgentPayload>>>(url, jsonOptions);

                // Check if the response is valid
                if (apiResponse == null || apiResponse.Payload == null || !apiResponse.Payload.Any())
                    return ResponseFactory.CreateError<List<AgentResponse>>("No sub-agents found.", HttpStatusCode.NotFound);
               

                // Filter sub-agents by `userId` matching the provided `subAgentId`
                var filteredAgents = apiResponse.Payload
                    .Where(agent => Guid.TryParse(agent.UserId, out var userGuid) && userGuid == subAgentId)
                    .ToList();

                // Check if there are matches
                if (!filteredAgents.Any())
                    return ResponseFactory.CreateError<List<AgentResponse>>("No sub-agents found for the specified user ID.", HttpStatusCode.NotFound);
                
                // Map the payload to AgentResponse
                 var data = filteredAgents.Select(agent => new AgentResponse
                {
                    Id = agent.Id,
                    Firstname = agent.Firstname,
                    Lastname = agent.Lastname,
                    Mobile = agent.Mobile,
                    Email = agent.Email,
                    UserId = agent.UserId
                }).ToList();

                return ResponseFactory.GetSuccessResponse<List<AgentResponse>>(data,"Sub-agents retrieved successfully");
                
            }
            catch (JsonException ex)
            {
                return ResponseFactory.CreateError<List<AgentResponse>>($"An error occurred while deserializing the response: " +
                    $"{ex.Message}",HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {  
                return ResponseFactory.CreateError<List<AgentResponse>>($"An error occurred: {ex.Message}",HttpStatusCode.InternalServerError);
            }

         
        }
        public async Task<BaseResponse<List<CustomerDocs>>> CustomerDocumentLookUps(int customerId)
        {
        
            var apiBaseUrl = _configuration["Customers:CustomerDocuments"];

            // Validate API Base URL
            if (string.IsNullOrEmpty(apiBaseUrl))
                return ResponseFactory.CreateError<List<CustomerDocs>>("CustomerDocuments API base URL is not configured", HttpStatusCode.BadRequest);


            var apiUrl = $"{apiBaseUrl}/{customerId}/documents";

            // Call External API
            using var httpClient = new HttpClient();
            var httpResponse = await httpClient.GetAsync(apiUrl);

            if (!httpResponse.IsSuccessStatusCode)
                return ResponseFactory.CreateError<List<CustomerDocs>>
                    ($"Failed to retrieve customer documents: {httpResponse.StatusCode}.", httpResponse.StatusCode);


            // Deserialize API Response
            var content = await httpResponse.Content.ReadAsStringAsync();
            var customerData = JsonSerializer.Deserialize<CustomerDocApiResponses<CustomerDocs>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (customerData == null || customerData.Data == null || !customerData.Data.Any())
                return ResponseFactory.CreateError<List<CustomerDocs>>("No customer documents found.", HttpStatusCode.NotFound);
           
            // Extract the required fields
            var extractedData = customerData.Data.Select(d => new CustomerDocs
            {
                DocumentName = d.DocumentName,
                DocumentType = d.DocumentType,
                CustomerDocumentId = d.CustomerDocumentId
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<CustomerDocs>>(extractedData, customerData.ResponseMessage);
        }
        public async Task<BaseResponse<CustomerDocsDownload>> DownloadCustomerDocument(int customerDocumentId, int customerId)
        {
            var response = new BaseResponse<CustomerDocsDownload>();
            var apiBaseUrl = _configuration["Customers:DownloadDocument"];

            if (string.IsNullOrEmpty(apiBaseUrl))
            {
                response.Success = false;
                response.ResponseMessage = "Base URL not found";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var apiUrl = $"{apiBaseUrl}/{customerId}/{customerDocumentId}";
            using var httpClient = new HttpClient();
            var httpResponse = await httpClient.GetAsync(apiUrl);

            if (!httpResponse.IsSuccessStatusCode)
            {
                response.Success = false;
                response.ResponseMessage = "Failed to download document";
                response.StatusCode = httpResponse.StatusCode;
                return response;
            }

            var content = await httpResponse.Content.ReadAsStringAsync();

            // Deserialize the response as CustomerApiResponses
            var documentDetails = JsonSerializer.Deserialize<CustomerApiResponses>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (documentDetails == null)
            {
                response.Success = false;
                response.ResponseMessage = "Document not found or empty data";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }
            response.Success = true;
            response.ResponseMessage = "Downloaded file successfully";
            response.Data = new CustomerDocsDownload
            {
                FilePath = documentDetails.Data // Assign the base64 string here
            };
            response.StatusCode = HttpStatusCode.OK;

            return response;
        }

        public async Task<BaseResponse<string>> DownloadSchedule(int quoteId)
        {
            var response = new BaseResponse<string>();

            // Get product details
            var quote = await _rubyDbContext.Quotations.Include(x => x.Product)
                .ThenInclude(p => p.ProductSubjectTypes)
                .ThenInclude(ps => ps.ProductSubjectTypeAttributes)
                .Include(q => q.QuotationAttributeValues)
                .Where(q => q.QuoteStatus == "Accepted")
                .SingleOrDefaultAsync(x => x.Id == quoteId);

            if (quote == null)
            {
                response.Success = false;
                response.ResponseMessage = "Quote does not exist";
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }

            var productSubjectTypes = await _rubyDbContext.ProductSubjectTypes
            .Include(pst => pst.ProductSubjectTypeAttributes)
            .Where(pst => pst.ProductId == quote.ProductId)
            .ToListAsync();

            if (productSubjectTypes == null || !productSubjectTypes.Any())
            {
                response.Success = false;
                response.ResponseMessage = "Product Attributes Not Found";
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }


            var categorySelections = await _rubyDbContext.ProductCategorySelections
               .Where(d => d.ProductId == quote.ProductId)
               .ToListAsync();

            List<LineOfBusinessAttributeItem> genericCategory = new List<LineOfBusinessAttributeItem>();

            if (categorySelections.Any())
            {
                var categoryIds = categorySelections.Select(c => c.CategoryId).Distinct().ToList();

                genericCategory = await _rubyDbContext.LineOfBusinessAttributeItems
                    .Include(d => d.BusinessAttributeItemDropdownValues)
                    .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting == false)
                    .ToListAsync();
            }


            // Setup Excel package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage())
            {
                try
                {


                    foreach (var productSubjectType in productSubjectTypes)
                    {
                        // Check if quotationPreference is not "Simulation", add CustomerId to the header
                        AddWorksheetWithAttributes(excel, productSubjectType, quote.Id, quote.QuotationAttributeValues.ToList(),genericCategory);
                    }


                    using (var memoryStream = new MemoryStream())
                    {
                        excel.SaveAs(memoryStream);
                        memoryStream.Position = 0;
                        response.Success = true;
                        response.ResponseMessage = Convert.ToBase64String(memoryStream.ToArray());
                        response.StatusCode = System.Net.HttpStatusCode.OK;
                    }
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.ResponseMessage = $"Error generating file: {ex.Message}";
                    response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                }
            }

            return response;
        }

        private void AddWorksheetWithAttributes(ExcelPackage excel, ProductSubjectType productSubjectTypes, int quoteId, List<QuotationAttributeValue> quoteAttributes, List<LineOfBusinessAttributeItem> genericCategory)
        {
            var sheetName = "bookingFleetDetails";
            var workSheet = excel.Workbook.Worksheets.Add(sheetName);

            var attributeRow = 1;
            var valueStartRow = 2;
            var fixedColumnWidth = 20;

            // Unlock all cells by default
            workSheet.Cells.Style.Locked = false;

            // Enable worksheet protection (ensure it allows unlocked cells to be edited)
            workSheet.Protection.IsProtected = true;
            workSheet.Protection.SetPassword("YourPassword");
            workSheet.Protection.AllowSelectUnlockedCells = true;

            // Separate sheet for dropdown values
            var dropdownSheet = excel.Workbook.Worksheets.Add("DropdownValues");
            int dropdownSheetRow = 1;

            // Set headers for ProductSubjectTypeAttributes
            var column = 1;
            foreach (var productSubjectTypeAttribute in productSubjectTypes.ProductSubjectTypeAttributes)
            {
                workSheet.Cells[attributeRow, column].Value = productSubjectTypeAttribute.Name;
                FormatHeader(workSheet.Cells[attributeRow, column]);
                workSheet.Column(column).Width = fixedColumnWidth;

                // Handle dropdowns for ProductSubjectTypeAttributes
                if (productSubjectTypeAttribute.FieldType.Equals("Dropdown", StringComparison.OrdinalIgnoreCase) &&
                    productSubjectTypeAttribute.DropdownValues != null && productSubjectTypeAttribute.DropdownValues.Any())
                {
                    // Handle dropdown values for ProductSubjectTypeAttribute
                    HandleDropdowns(dropdownSheet, ref dropdownSheetRow, column, productSubjectTypeAttribute.DropdownValues);
                    ApplyDropdownValidation(workSheet, column, valueStartRow, dropdownSheetRow);
                }

                column++;
            }

            // Set headers for LineOfBusinessAttributeItems (genericCategory)
            foreach (var lineOfBusinessAttributeItem in genericCategory)
            {
                workSheet.Cells[attributeRow, column].Value = lineOfBusinessAttributeItem.Name;
                FormatHeader(workSheet.Cells[attributeRow, column]);
                workSheet.Column(column).Width = fixedColumnWidth;

                // Handle dropdowns for LineOfBusinessAttributeItem
                if (lineOfBusinessAttributeItem.BusinessAttributeItemDropdownValues != null && lineOfBusinessAttributeItem.BusinessAttributeItemDropdownValues.Any())
                {
                    // Handle dropdown values for LineOfBusinessAttributeItem
                    HandleDropdowns(dropdownSheet, ref dropdownSheetRow, column, lineOfBusinessAttributeItem.BusinessAttributeItemDropdownValues);
                    ApplyDropdownValidation(workSheet, column, valueStartRow, dropdownSheetRow);
                }

                column++;
            }

            // Group values by EntityId
            var groupedAttributes = quoteAttributes
                .Where(q => q.QuotationId == quoteId)
                .GroupBy(q => q.EntityId)
                .ToList();

            var currentRow = valueStartRow;

            foreach (var entityGroup in groupedAttributes)
            {
                column = 1; // Reset column for each row

                foreach (var productSubjectTypeAttribute in productSubjectTypes.ProductSubjectTypeAttributes)
                {
                    var matchingQuoteAttribute = entityGroup.FirstOrDefault(q => q.AttributeName == productSubjectTypeAttribute.Name);

                    if (matchingQuoteAttribute != null)
                    {
                        workSheet.Cells[currentRow, column].Value = matchingQuoteAttribute.AttributeValue;
                        workSheet.Cells[currentRow, column].Style.Locked = true; // Lock filled cells
                    }
                    else
                    {
                        workSheet.Cells[currentRow, column].Value = string.Empty;
                        workSheet.Cells[currentRow, column].Style.Locked = false; // Leave empty cells editable
                    }

                    column++;
                }

                // Add LineOfBusinessAttributeItem values
                foreach (var lineOfBusinessAttributeItem in genericCategory)
                {
                    var matchingQuoteAttribute = entityGroup.FirstOrDefault(q => q.AttributeName == lineOfBusinessAttributeItem.Name);

                    if (matchingQuoteAttribute != null)
                    {
                        workSheet.Cells[currentRow, column].Value = matchingQuoteAttribute.AttributeValue;
                        workSheet.Cells[currentRow, column].Style.Locked = true;
                    }
                    else
                    {
                        workSheet.Cells[currentRow, column].Value = string.Empty;
                        workSheet.Cells[currentRow, column].Style.Locked = false;
                    }

                    column++;
                }

                currentRow++; // Move to the next row for the next entity
            }

            // Freeze the header row
            workSheet.View.FreezePanes(2, 1);
        }

        private void HandleDropdowns(ExcelWorksheet dropdownSheet, ref int dropdownSheetRow, int column, List<BusinessAttributeItemDropdownValues> dropdownValues)
        {
            // Store Dropdown Values from BusinessAttributeItemDropdownValues in the Separate Sheet
            foreach (var value in dropdownValues.Select(d => d.Value).Distinct())
            {
                dropdownSheet.Cells[dropdownSheetRow, column].Value = value;
                dropdownSheetRow++;
            }
        }

        private void HandleDropdowns(ExcelWorksheet dropdownSheet, ref int dropdownSheetRow, int column, List<DropdownValues> dropdownValues)
        {
            // Store Dropdown Values from DropdownValues in the Separate Sheet
            foreach (var value in dropdownValues.Select(d => d.Value).Distinct())
            {
                dropdownSheet.Cells[dropdownSheetRow, column].Value = value;
                dropdownSheetRow++;
            }
        }

        private void ApplyDropdownValidation(ExcelWorksheet workSheet, int column, int valueStartRow, int dropdownSheetRow)
        {
            // Create Named Range for Dropdown
            string dropdownRange = $"DropdownValues!${ExcelCellAddress.GetColumnLetter(column)}$1:${ExcelCellAddress.GetColumnLetter(column)}${dropdownSheetRow - 1}";

            // Apply Data Validation (Dropdown)
            var validation = workSheet.DataValidations.AddListValidation(workSheet.Cells[valueStartRow, column, 100, column].Address);
            validation.Formula.ExcelFormula = dropdownRange;
            validation.ShowErrorMessage = true;
            validation.ErrorTitle = "Invalid Selection";
            validation.Error = $"Please select a value from the dropdown list.";
        }

        public async Task<BaseResponse<Dictionary<string, List<Dictionary<string, object>>>>> ExtractExcelDataFromStream(IFormFile file, int quoteId)
        {
            var response = new BaseResponse<Dictionary<string, List<Dictionary<string, object>>>>();

            if (file == null || file.Length == 0)
            {
                response.Success = false;
                response.ResponseMessage = "No File Uploaded";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var result = new Dictionary<string, List<Dictionary<string, object>>>();

            var quote = await _rubyDbContext.Quotations.FirstOrDefaultAsync(d => d.Id == quoteId);

            var product = await _rubyDbContext.ProductSubjectTypes.
                FirstOrDefaultAsync(d => d.ProductId == quote.ProductId);
            // Fetch subject types and create a lookup dictionary
            var subjectTypeDictionary = await _rubyDbContext.ProductSubjectTypeAttributes
                .Distinct().Where(d => d.ProductSubjectTypeId == product.Id)
                .ToDictionaryAsync(d => d.Name, d => d.Id);


            // Set the license context for EPPlus (for non-commercial use)
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Dictionary to store generated GUIDs for each unique row hash
            var rowHashEntityIdMap = new Dictionary<string, Guid>();

            // Use EPPlus to load the Excel file
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var excelPackage = new ExcelPackage(stream))
                {
                    // Loop through each worksheet (each sheet represents a SubjectType.Name)
                    foreach (var worksheet in excelPackage.Workbook.Worksheets)
                    {
                        // Store the worksheet name as the key
                        var subjectTypeName = worksheet.Name;

                        // List to hold the data rows for this worksheet
                        var dataRows = new List<Dictionary<string, object>>();

                        // Read the headers from the first row (1-based indexing in Excel)
                        var headers = new List<string>();
                        for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                        {
                            headers.Add(worksheet.Cells[1, col].Text);  // Reading header names
                        }

                        // Read the data for each row (starting from row 2)
                        for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                        {
                            var rowDataList = new List<Dictionary<string, object>>();
                            var rowStringBuilder = new StringBuilder(); // String builder to concatenate row values

                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var attributeName = headers[col - 1]; // Match the header with the value
                                var attributeValue = worksheet.Cells[row, col].Text;

                                rowStringBuilder.Append(attributeValue ?? string.Empty); // Handle null values

                                // Check if attributeName exists in the dictionary
                                subjectTypeDictionary.TryGetValue(attributeName, out var attributeId);

                                // Structure the data correctly
                                var attributeData = new Dictionary<string, object>
                                {
                                    { "attributeId", attributeId },
                                    { "attributeName", attributeName },
                                    { "attributeValue", attributeValue }
                                };
                                rowDataList.Add(attributeData);
                            }

                            // Generate a hash for the current row
                            var rowHash = ComputeHash(rowStringBuilder.ToString());

                            // Check if this row's hash has already been encountered
                            if (!rowHashEntityIdMap.ContainsKey(rowHash))
                            {
                                // If not, generate a new GUID and store it
                                rowHashEntityIdMap[rowHash] = Guid.NewGuid();
                            }

                            // Add EntityId to the row data
                            var entityData = new Dictionary<string, object>
                        {
                            { "entityId", rowHashEntityIdMap[rowHash] },
                            { "attributes", rowDataList } // Store the attributes as a list
                        };

                            // Add the row data to the list
                            dataRows.Add(entityData);
                        }

                        // Add the key (worksheet name) and the data rows to the result dictionary
                        result[subjectTypeName] = dataRows;
                    }
                }
            }

            // Set success response with the extracted key-value pairs
            response.Success = true;
            response.StatusCode = HttpStatusCode.OK;
            response.Data = result;
            response.ResponseMessage = "Data extracted successfully";
            return response;
        }
        public async Task<BaseResponse<PolicyPostingResponse>> PolicyPosting(int policyId)
        {
         
            // Fetch the policy with required related data
            var policy = await _rubyDbContext.PolicyBookings
                .Include(p => p.Quotation)
                .ThenInclude(q => q.Product)
                .FirstOrDefaultAsync(p => p.Id == policyId);

            if (policy == null) return ResponseFactory.
                    CreateError<PolicyPostingResponse>("Policy not found.", HttpStatusCode.NotFound);

            // Fetch customer accounts
            var customer = await _rubyDbContext.Customers
                .Include(c => c.CustomerBankAccounts)
                .ThenInclude(cba => cba.BankAccount)
                .FirstOrDefaultAsync(c => c.CustomerNumber == policy.Customer);

            if (customer == null)
                return ResponseFactory.CreateError<PolicyPostingResponse>("Customer account details not found.", HttpStatusCode.NotFound);
            

            // Fetch product account
            var productAccount = await _rubyDbContext.Products
                .Include(p => p.IncomeLedger)
                .Include(p => p.ExpenseLedgers)
                .Include(p => p.ReceivableLedgers)
                .Include(p => p.ProductCostOfInsurances)
                .FirstOrDefaultAsync(p => p.Id == policy.Quotation.ProductId);

            if (productAccount == null)
                return ResponseFactory.CreateError<PolicyPostingResponse>("Product account details not found.", HttpStatusCode.NotFound);
           
            // Prepare the PolicyPostingResponse
            var posting = new PolicyPostingResponse
            {
                Customer = new CustomerPolicyResponse
                {
                    Name = policy.CustomerName,
                    CustomerNumber = policy.Customer,
                    AccountNumber = customer.CustomerBankAccounts
                        .Select(cba => new AccountNumberResponse
                        {
                            AccountNumber = cba.BankAccount?.AccountNumber
                        }).ToList()
                },
                Policy = new PolicyResponse
                {
                    Name = policy.Quotation.Product.Name,
                    AmountPayable = policy.Quotation.Premium
                },
                Postings = new PostingResponse
                {
                    IncomeLedgerResponse = productAccount.IncomeLedger?
                        .Select(ledger => new IncomeLedgerResponse
                        {
                            AccountNumber = ledger.AccountNumber,
                            Description = ledger.Description
                        }).ToList() ?? new List<IncomeLedgerResponse>(),
                    ExpenseLedgerResponse = productAccount.ExpenseLedgers?
                        .Select(ledger => new ExpenseLedgerResponse
                        {
                            AccountNumber = ledger.AccountNumber,
                            Description = ledger.Description
                        }).ToList() ?? new List<ExpenseLedgerResponse>(),
                    ReceivableLedgerResponse = productAccount.ReceivableLedgers?
                        .Select(ledger => new ReceivableLedgerResponse
                        {
                            AccountNumber = ledger.AccountNumber,
                            Description = ledger.Description
                        }).ToList() ?? new List<ReceivableLedgerResponse>(),
                    CostOfInsurance = productAccount.ProductCostOfInsurances?.FirstOrDefault() != null
                        ? new CostOfInsurancePostingAccounts
                        {
                            DebitAccount = productAccount.ProductCostOfInsurances.First().DebitAccount,
                            CreditAccount = productAccount.ProductCostOfInsurances.First().CreditAccount
                        }
                        : null
                }
            };

            return ResponseFactory.GetSuccessResponse<PolicyPostingResponse>(posting, "Policy validation successful.");
        }

        private async Task<PolicyBooking> GetPolicyById(int policyId)
        {
            return await _rubyDbContext.PolicyBookings
                .Include(d => d.Quotation)
                .ThenInclude(d => d.Product)
                .Include(d => d.EligibilityPeriods)
                .FirstOrDefaultAsync(d => d.Id == policyId);
        }

        private async Task<BookingBusinessInformation> GetBusinessInformation(int policyId)
        {
            return await _rubyDbContext.BookingBusinessInformation
                .FirstOrDefaultAsync(d => d.BookingId == policyId);
        }

        private async Task<List<CoInsuranceDetail>> GetCoInsuranceDetails(int businessInfoId)
        {
            return await _rubyDbContext.CoInsuranceDetails
                .Where(d => d.BusinessInfoId == businessInfoId)
                .OrderByDescending(d => d.Portion)
                .ToListAsync();
        }


        //Financial Simulation
        public async Task<BaseResponse<FinancialSimulationResponse>> GetFinancialSimulationByPolicy(int policyId)
        {
            var policy = await GetPolicyById(policyId);
            if (policy == null)
                return ResponseFactory.CreateError<FinancialSimulationResponse>("Policy not found", HttpStatusCode.NotFound);

            var businessInformation = await GetBusinessInformation(policyId);
            if (businessInformation == null)
                return ResponseFactory.CreateError<FinancialSimulationResponse>("Business Information Does not Exist", HttpStatusCode.NotFound);

            var originalPremium = policy.Quotation.Premium ?? 0m;
            var originalSumInsure = policy.SumInsured;
            var totalSumAssured = originalPremium;

            var coInsuranceDetails = await GetCoInsuranceDetails(businessInformation.Id);

            var (axaPremium, axaSumInsured) = await GetLeadShareWithManagementFee(
                                                                    coInsuranceDetails,
                                                                    originalPremium,
                                                                    originalSumInsure,
                                                                    policy.Quotation.ProductId);


            var (incomeRecognitionResponse, managementFeeResponse, bookingBroker, agentFee, costOfInsurance, reinsuranceResponse) =
                await ProcessFinancialSimulation(policy, businessInformation, originalPremium, coInsuranceDetails);



            decimal retention = 50000m;
            decimal treaty = 50000m;
            decimal underwritingCapacity = treaty + retention;
            // Step 1: Calculate covered capacity (Retention + Treaty)
           

            // Step 2: Calculate excess capacity (Total Sum Assured - Covered)
            decimal totalSumInsured = originalSumInsure ?? 0;
            decimal excess = axaSumInsured - underwritingCapacity;

            // Step 3: Calculate ratio of each layer to total sum insured
            decimal retentionRatio = axaSumInsured == 0 ? 0 : retention / totalSumInsured;
            decimal treatyRatio = axaSumInsured == 0 ? 0 : treaty / totalSumInsured;
            decimal excessRatio = axaSumInsured == 0 ? 0 : excess / totalSumInsured;

            // Step 4: Calculate premiums proportionally based on the ratios
            decimal retentionPremium = Math.Round(retentionRatio * originalPremium, 2);
            decimal treatyPremium = Math.Round(treatyRatio * originalPremium, 2);
           

            // Step 5: Underwriting capacity should equal total sum insured (not more!)
            
            string underwritingPremium = (retentionPremium + treatyPremium).ToString("N2");
            decimal underwritingPremiumDecimal = decimal.Parse(underwritingPremium);
            string excessPremium = (axaPremium - underwritingPremiumDecimal).ToString("N2");

            var master = await _rubyDbContext.BookingOperationalTransactionsMasters.FirstOrDefaultAsync(d => d.BookingId == policyId);



            return ResponseFactory.CreateSuccess<FinancialSimulationResponse>(
                new FinancialSimulationResponse
                {
                    TotalPremium = new TotalPremiumResponse
                    {
                        TotalPremium = originalPremium,
                        SumInsured =originalSumInsure ?? 0,
                    },
                    AxaTotalPremium = new AxaTotalPremiumResponse
                    {
                        axaPremium = axaPremium,
                        axaSumInsured = axaSumInsured
                    },

                    // Correct premiums for each capacity layer
                    TreatyCapacity = new TreatyCapacityResponse
                    {
                        TreatyCapacity = treaty, // This is the sum insured for treaty
                        AssociatedPremium = treatyPremium.ToString("N2") // This is the calculated premium for treaty
                    },

                    RetentionCapacity = new RetentionCapacityResponse
                    {
                        RetentionCapacity = retention, // This is the sum insured for retention
                        AssociatedPremium = retentionPremium.ToString("N2") // This is the calculated premium for retention
                    },

                    ExcessCapacity = new ExcessCapacityResponse
                    {
                        ExcessCapacity = excess, // This is the sum insured for excess
                        AssociatedPremium = excessPremium // This is the calculated premium for excess
                    },

                    UnderWritingCapacity = new UnderWritingCapacityResponse
                    {
                        UnderWritingCapacity = underwritingCapacity, // This is the total sum insured
                        AssociatedPremium = underwritingPremium // This is the total premium for all layers combined
                    },

                    TransactionId = master?.VoucherNo ?? "",
                    IncomeRecognitionResponse = incomeRecognitionResponse,
                    ManagementFeeResponse = managementFeeResponse,
                    BookingBrokerCommissionsResponse = bookingBroker,
                    BookingCommissionAgentResponse = agentFee,
                    BookingCostOfInsuranceFeeResponse = costOfInsurance,
                    ReinsuranceResponse = reinsuranceResponse // Include reinsurance response

                },
                "Financial Simulation Retrieved"
            );

        }

        // Helper Methods

        private async Task<(IncomeRecognitionResponse, ManagementFeeResponse, BookingBrokerCommissionsResponse, BookingCommissionAgentResponse, BookingCostOfInsuranceFeeResponse, ReinsuranceResponse)>
 ProcessFinancialSimulation(
     PolicyBooking policy,
     BookingBusinessInformation businessInfo,
     decimal originalPremium,
     List<CoInsuranceDetail> coInsuranceDetails)
        {
            ManagementFeeResponse managementFeeResponse = null;
            BookingBrokerCommissionsResponse bookingBroker = null;
            BookingCommissionAgentResponse agentFee = null;
            BookingCostOfInsuranceFeeResponse costOfInsurance = null;
            IncomeRecognitionResponse incomeRecognition = null;
            ReinsuranceResponse reinsuranceResponse = null;

            decimal adjustedPremium = originalPremium;

            try
            {
                incomeRecognition = await IncomeRecognition(policy.Id, originalPremium);
                adjustedPremium = incomeRecognition?.Total ?? adjustedPremium;
            }
            catch (Exception ex)
            {
                // Log exception or handle it if needed
            }

            if (businessInfo.BusinessType == BusinessTypeValue.CoInsurance.GetDescription())
            {
                try
                {
                    managementFeeResponse = await ManagementFee(adjustedPremium, policy.Id, policy.Quotation.ProductId, businessInfo.Id);
                    adjustedPremium = managementFeeResponse?.NewPremium ?? adjustedPremium;
                }
                catch (Exception ex) { }

                try
                {
                    costOfInsurance = await CalculateCostOfInsuranceFee(adjustedPremium, policy.ProductId, policy.Id);
                    adjustedPremium = costOfInsurance?.NewPremium ?? adjustedPremium;
                }
                catch (Exception ex) { }

                try
                {
                    bookingBroker = await CalculateBrokerCommission(adjustedPremium, policy.Id, policy.ProductId);
                    adjustedPremium = bookingBroker?.NewPremium ?? adjustedPremium;
                }
                catch (Exception ex) { }

                try
                {
                    agentFee = await CalculateAgentCommission(adjustedPremium, policy.Id, policy.ProductId);
                    adjustedPremium = agentFee?.NewPremium ?? adjustedPremium; // Ensure adjustedPremium is updated
                }
                catch (Exception ex) { }

                try
                {
                    reinsuranceResponse = await CalculateReinsurance(adjustedPremium, policy.SumInsured ?? 0, policy.Id, policy.ProductId, coInsuranceDetails);
                }
                catch (Exception ex) { }
            }
            else if (businessInfo.BusinessType == BusinessTypeValue.SoleInsurance.GetDescription())
            {
                try
                {
                    if (businessInfo.BusinessSource == BusinessSource.BusinessIsBrokered.GetDescription())
                    {
                        bookingBroker = await CalculateBrokerCommission(adjustedPremium, policy.Id, policy.ProductId);
                        adjustedPremium = bookingBroker?.NewPremium ?? adjustedPremium;
                    }
                }
                catch (Exception ex) { }

                try
                {
                    agentFee = await CalculateAgentCommission(adjustedPremium, policy.Id, policy.ProductId);
                    adjustedPremium = agentFee?.NewPremium ?? adjustedPremium; // Ensure adjustedPremium is updated
                }
                catch (Exception ex) { }

                try
                {
                    costOfInsurance = await CalculateCostOfInsuranceFee(adjustedPremium, policy.Quotation.ProductId, policy.Id);
                    adjustedPremium = costOfInsurance?.NewPremium ?? adjustedPremium; // Ensure adjustedPremium is updated
                }
                catch (Exception ex) { }
            }

            return (incomeRecognition, managementFeeResponse, bookingBroker, agentFee, costOfInsurance, reinsuranceResponse);
        }




        private async Task<(decimal axaPremium, decimal axaSumInsured)> GetLeadShareWithManagementFee(
                            List<CoInsuranceDetail> coInsuranceDetails,
                            decimal originalPremium,
                            decimal? originalSumInsure,int productId){
            if (coInsuranceDetails == null || !coInsuranceDetails.Any())
                return (originalPremium, originalSumInsure ?? 0);

            var leadInsurer = coInsuranceDetails.OrderByDescending(d => d.Portion).First();
            var nonLeadInsurers = coInsuranceDetails.Skip(1).ToList();

            var managementFeeSetup = await _rubyDbContext.ProductFeeSetups
                .Where(d => (d.FeeName == "Management Fee" || d.FeeName == "Management Fees") && d.ProductId == productId)
                .FirstOrDefaultAsync();

            decimal managementFeePercentage = managementFeeSetup?.PercentageValue ?? 0m;
            decimal managementFeeValue = (managementFeePercentage / 100m) * originalPremium;

            decimal totalFeeDeductedFromNonLeads = 0m;
            foreach (var insurer in nonLeadInsurers)
            {
                var insurerShareOfFee = (insurer.Portion / 100m) * managementFeeValue;
                totalFeeDeductedFromNonLeads += insurerShareOfFee;
            }
           

            decimal axaPremium = Math.Round((leadInsurer.Portion / 100m) * originalPremium, 2);
            decimal axaSumInsured = ((leadInsurer.Portion / 100m) * (originalSumInsure ?? 0));

            return (axaPremium, axaSumInsured);
        }









        public async Task<IncomeRecognitionResponse> IncomeRecognition(int policyId, decimal premium)
        {
            var booking = await _rubyDbContext.PolicyBookings
                .FirstOrDefaultAsync(d => d.Id == policyId);

            if (booking == null)
                throw new Exception("Policy booking not found.");

            var product = await _rubyDbContext.Products
                .FirstOrDefaultAsync(d => d.Id == booking.ProductId);

            if (product == null)
                throw new Exception("Product not found for the booking.");

            var customer = await _rubyDbContext.Customers
                .FirstOrDefaultAsync(d => d.CustomerNumber == booking.Customer);

            if (customer == null)
                throw new Exception("Customer not found for the booking.");

            var master = await _rubyDbContext.BookingOperationalTransactionsMasters
            .FirstOrDefaultAsync(d => d.BookingId == policyId);

            BookingOperationalSettlementDetails transactions = null;
            if (master != null)
            {
                transactions = await _rubyDbContext.BookingOperationalSettlementDetails
                    .FirstOrDefaultAsync(d => d.TransactionId == master.Id && d.PostingType == "Total Premium Payment");
            }

            // Rounding premium to two decimal places
            premium = Math.Round(premium, 2);

            return new IncomeRecognitionResponse
            {
                Debits = new List<IncomeRecognitionDebitResponse>
                {
                    new IncomeRecognitionDebitResponse
                    {
                        AccountName = booking.CustomerName,
                        Description = $"{booking.CustomerName} ({customer.ReceivableLedger} - Receivable)",
                        Amount = premium,
                        AccountNumber = customer.PayableLedger,
                        PostType = "Total Premium Payment",
                        IsCustomerAccountNumber = true

                    }
                },

                Credits = new List<IncomeRecognitionCreditResponse>
                {
                    new IncomeRecognitionCreditResponse
                    {
                        AccountName = product.Name,
                        Description = $"{product.Name} ({product.IncomeAccount} - Income)",
                        Amount = premium,
                        AccountNumber = product.IncomeAccount,
                        PostType = "Total Premium Payment",
                        IsCustomerAccountNumber = false
                    }
                },

                Total = premium,
                VoucherNo = transactions?.TransactionVoucher ?? "",
                VocherType = "Premium Voucher",
                Description = $"Being premium recognition From {booking.CustomerName}"
            };
        }
        public async Task<ManagementFeeResponse> ManagementFee(decimal premium, int policyId, int productId, int businessId)
        {
            var disbursementType = await _rubyDbContext.BookingBusinessInformation
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            var product = await _rubyDbContext.Products.FirstOrDefaultAsync(d => d.Id == productId);

            if (disbursementType == null || disbursementType.AdditionalInformation != "Premium on quote represents 100% of transaction whole")
            {
                return new ManagementFeeResponse
                {
                    Debits = new List<ManagementFeeDebitResponse>(),
                    Credits = new List<ManagementFeeCreditResponse>(),
                    VoucherNo = "",
                    VocherType = "Coinsurance Premium Voucher",
                    Description = "Being income earned for administering co-insurance policy",
                    NewPremium = premium
                };
            }

            var managementFeeSetup = await _rubyDbContext.ProductFeeSetups
                .FirstOrDefaultAsync(d => (d.FeeName == "Management Fee" || d.FeeName == "Management Fees") && d.ProductId == productId);

            if (managementFeeSetup == null)
                return null;

            decimal managementFeePercentage = managementFeeSetup.PercentageValue / 100m;

            var coInsuranceDetails = await _rubyDbContext.CoInsuranceDetails
                .Where(d => d.BusinessInfoId == businessId)
                .OrderByDescending(d => d.Portion)
                .ToListAsync();

            if (!coInsuranceDetails.Any())
                return null;

            var leadInsurer = coInsuranceDetails.First();
            var nonLeadInsurers = coInsuranceDetails.Skip(1).ToList();



            var insurerIds = nonLeadInsurers.Select(x => x.InsurerId).Distinct().ToArray();
            var coInsuranceAccounts = await _adminService.GetExternalEntitiesByIds(insurerIds);
            var accountLookup = coInsuranceAccounts?.Data?.ToDictionary(x => x.Id, x => x)
                                 ?? new Dictionary<int, CoInsuranceAccountDetailsResponse>();

            var receivableLedger = await _rubyDbContext.ReceivableLedgers
                .FirstOrDefaultAsync(d => d.ProductId == productId && d.AccountName == "Coinsurance Receivable Ledger");

            var coinsuranceIncomeLedger = await _rubyDbContext.IncomeLedgers
                .FirstOrDefaultAsync(d => d.ProductId == productId && d.AccountName == "Coinsurance Management Fees");

            var premiumOutwardLedger = await _rubyDbContext.ExpenseLedgers
                .FirstOrDefaultAsync(d => d.ProductId == productId && d.AccountName == AccountNameSearch.CoinsurancePremiumOutward.GetDescription());

            var booking = await _rubyDbContext.PolicyBookings.FirstOrDefaultAsync(d => d.Id == policyId);
            var customer = await _rubyDbContext.Customers.FirstOrDefaultAsync(d => d.CustomerNumber == booking.Customer);

            var master = await _rubyDbContext.BookingOperationalTransactionsMasters
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            BookingOperationalSettlementDetails transactions = null;
            if (master != null)
            {
                transactions = await _rubyDbContext.BookingOperationalSettlementDetails
                    .FirstOrDefaultAsync(d => d.TransactionId == master.Id && d.PostingType == "Management Fee");
            }

            var response = new ManagementFeeResponse
            {
                Debits = new List<ManagementFeeDebitResponse>(),
                Credits = new List<ManagementFeeCreditResponse>(),
                VoucherNo = transactions?.TransactionVoucher ?? "",
                VocherType = "Coinsurance Management Fee Voucher",
                Description = $"Being Coinsurance From: {product.Name} Expense Ledger."
            };

            decimal totalPayablePremium = 0;

            foreach (var insurer in nonLeadInsurers)
            {
                decimal sharePremium = Math.Round((insurer.Portion / 100m) * premium, 2);
                decimal shareFee = Math.Round(sharePremium * managementFeePercentage, 2);
                decimal netPayable = Math.Round(sharePremium - shareFee, 2);

                totalPayablePremium += netPayable;

                var matchingAccount = accountLookup.GetValueOrDefault(insurer.InsurerId);
                string accountName = matchingAccount?.Name ?? "Unknown Co-insurer";
                string payableAccountNumber = matchingAccount?.payableAccountNumber ?? "0000000000";


                // --- First Pair: Debit Receivable / Credit Management Fee ---
                response.Debits.Add(new ManagementFeeDebitResponse
                {
                    AccountName = receivableLedger.AccountName,
                    Description = $"Coinsurance Receivable ({receivableLedger.AccountNumber} - Asset)",
                    Amount = shareFee,
                    AccountNumber = receivableLedger.AccountNumber,
                    PostType = "Management Fee",
                    IsCustomerAccountNumber = false,
                    InsurerId = insurer.InsurerId
                });

                response.Credits.Add(new ManagementFeeCreditResponse
                {
                    AccountName = coinsuranceIncomeLedger.AccountName,
                    Description = $"Management fees ({coinsuranceIncomeLedger.AccountNumber} - Income)",
                    Amount = shareFee,
                    AccountNumber = coinsuranceIncomeLedger.AccountNumber,
                    PostType = "Management Fee",
                    IsCustomerAccountNumber = false,
                    InsurerId = insurer.InsurerId
                });

                // --- Second Pair: Debit Premium Outward / Credit Payable ---
                response.Debits.Add(new ManagementFeeDebitResponse
                {
                    AccountName = premiumOutwardLedger.AccountName,
                    Description = $"Premium Outward ({premiumOutwardLedger.AccountNumber}) - Expense",
                    Amount = netPayable,
                    AccountNumber = premiumOutwardLedger.AccountNumber,
                    PostType = "Coinsurance",
                    IsCustomerAccountNumber = false,
                    InsurerId = insurer.InsurerId
                });

                response.Credits.Add(new ManagementFeeCreditResponse
                {
                    AccountName = accountName,
                    Description = $"{accountName} ({payableAccountNumber}) - Payable",
                    Amount = netPayable,
                    AccountNumber = payableAccountNumber,
                    PostType = "Coinsurance",
                    IsCustomerAccountNumber = false,
                    InsurerId = insurer.InsurerId
                });
            }

            decimal leadSharePremium = Math.Round((leadInsurer.Portion / 100m) * premium, 2);
            response.NewPremium = leadSharePremium;

            //response.NewPremium = Math.Round(totalPayablePremium, 2);
            return response;
        }
        public async Task<BookingCostOfInsuranceFeeResponse> CalculateCostOfInsuranceFee(decimal premium, int productId, int policyId)
        {
            var master = await _rubyDbContext.BookingOperationalTransactionsMasters
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            BookingOperationalSettlementDetails transactions = null;
            if (master != null)
            {
                transactions = await _rubyDbContext.BookingOperationalSettlementDetails
                    .FirstOrDefaultAsync(d => d.TransactionId == master.Id && (d.PostingType == "Investible" || d.PostingType == "Gross Risk Premium"));
            }

            var response = new BookingCostOfInsuranceFeeResponse
            {
                Debits = new List<CostOfInsuranceDebitResponse>(),
                Credits = new List<CostOfInsuranceCreditResponse>(),
                Voucher = transactions?.TransactionVoucher ?? "",
                VocherType = "Cost of Insurance Expense Voucher",
                Description = "" // Will populate below based on logic
            };

            // Fetch all cost of insurance fees for the product
            var costOfInsuranceFees = await _rubyDbContext.ProductCostOfInsurances
                .Where(d => d.ProductId == productId)
                .ToListAsync();

            if (!costOfInsuranceFees.Any())
                throw new Exception("Cost of insurance configuration not found for the product.");

            // Fetch booking and customer details
            var booking = await _rubyDbContext.PolicyBookings
                .FirstOrDefaultAsync(d => d.Id == policyId);

            if (booking == null)
                throw new Exception("Booking not found for the provided policy ID.");

            var customer = await _rubyDbContext.Customers
                .FirstOrDefaultAsync(d => d.CustomerNumber == booking.Customer);

            if (customer == null)
                throw new Exception("Customer not found for the booking.");

            decimal totalDeducted = 0;
            decimal totalCustomerCost = 0;

            // Process each cost of insurance fee
            foreach (var costOfInsuranceFee in costOfInsuranceFees)
            {
                decimal feeAmount = premium * ((costOfInsuranceFee.TermValue ?? 0) / 100m);
                feeAmount = Math.Round(feeAmount, 2); // Round at the final step

                if (costOfInsuranceFee.CostBearer == "Customer")
                {
                    // Debit Customer account, Credit Payable
                    response.Debits.Add(new CostOfInsuranceDebitResponse
                    {
                        AccountName = booking.CustomerName,
                        Description = $"{booking.CustomerName} ({customer.ReceivableLedger} - Receivable)",
                        Amount = feeAmount,
                        AccountNumber = customer.PayableLedger,
                        PostType = "Investible",
                        IsCustomerAccountNumber = true
                    });

                    response.Credits.Add(new CostOfInsuranceCreditResponse
                    {
                        AccountName = "Naicom Payable account",
                        Description = $"Naicom ({costOfInsuranceFee.CreditAccount} - Payable)",
                        Amount = feeAmount,
                        AccountNumber = costOfInsuranceFee.CreditAccount,
                        PostType = "Gross Risk Premium",
                        IsCustomerAccountNumber = false
                    });

                    // Description for customer-borne cost
                    response.Description = $"Being Cost of Insurance From: {booking.CustomerName}";

                    // If the cost is customer-borne, it should not affect the premium directly
                    totalCustomerCost += feeAmount;
                    response.NewPremium = premium;  // Premium remains unchanged for customer-borne costs
                }
                else
                {
                    // Debit Expense, Credit Payable
                    response.Debits.Add(new CostOfInsuranceDebitResponse
                    {
                        AccountName = "Naicom Expense",
                        Description = $"Naicom Expense ({costOfInsuranceFee.DebitAccount} - Expense)",
                        Amount = feeAmount,
                        AccountNumber = costOfInsuranceFee.DebitAccount,
                        PostType = "Gross Risk Premium",
                        IsCustomerAccountNumber = false,
                    });

                    response.Credits.Add(new CostOfInsuranceCreditResponse
                    {
                        AccountName = costOfInsuranceFee.PayableAccountName ?? "Naicom Fee",
                        Description = $"Naicom Fee ({costOfInsuranceFee.CreditAccount} - Payable)",
                        Amount = feeAmount,
                        AccountNumber = costOfInsuranceFee.CreditAccount,
                        PostType = "Gross Risk Premium",
                        IsCustomerAccountNumber = false
                    });

                    // Description for company-borne cost
                    response.Description = $"Being Cost of Insurance From: {booking.CustomerName}";

                    // Deduct from premium for company-borne costs
                    totalDeducted += feeAmount;
                }
            }

            // Final calculation of new premium
            response.NewPremium = Math.Round(premium - totalDeducted, 2);

            // If customer cost is included, ensure the premium remains correct after customer-borne costs
            // After loop ends
            if (totalDeducted > 0)
                response.NewPremium = Math.Round(premium - totalDeducted, 2);
            else
                response.NewPremium = premium; // Nothing deducted


            return response;
        }
        public async Task<BookingBrokerCommissionsResponse> CalculateBrokerCommission(decimal premium, int policyId, int productId)
        {
            var master = await _rubyDbContext.BookingOperationalTransactionsMasters
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            BookingOperationalSettlementDetails transactions = null;
            if (master != null)
            {
                transactions = await _rubyDbContext.BookingOperationalSettlementDetails
                    .FirstOrDefaultAsync(d => d.TransactionId == master.Id && d.PostingType == "Broker Commission");
            }

            var product = await _rubyDbContext.Products.FirstOrDefaultAsync(d => d.Id == productId);
            var policy = await _rubyDbContext.BookingBusinessInformation.FirstOrDefaultAsync(d => d.BookingId == policyId);

            if (policy == null || policy.BusinessSource != "Business is Brokered")
            {
                return new BookingBrokerCommissionsResponse
                {
                    Credits = new List<CommissionsBrokerCreditResponse>(),
                    Debits = new List<CommissionsBrokerDebitResponse>(),
                    NewPremium = premium,
                    VoucherNo = transactions?.TransactionVoucher ?? "",
                    VocherType = "Broker Commission Voucher",
                    Description = $"Being Broker Commission Payment From : {product?.Name}"
                };
            }

            var brokerFeeSetup = await _rubyDbContext.ProductFeeSetups
                .Where(d => (d.FeeName == "Broker fees" || d.FeeName == "Broker fee") && d.ProductId == productId)
                .FirstOrDefaultAsync();

            if (brokerFeeSetup == null)
            {
                return new BookingBrokerCommissionsResponse
                {
                    Credits = new List<CommissionsBrokerCreditResponse>(),
                    Debits = new List<CommissionsBrokerDebitResponse>(),
                    NewPremium = premium,
                    VoucherNo = "",
                    VocherType = "Broker Commission Voucher",
                    Description = $"Being Broker Commission Payment From : {product?.Name}"
                };
            }

            // === Calculate using full precision ===
            decimal rawBrokerFee = (brokerFeeSetup.PercentageValue / 100) * premium;
            decimal rawVat = 0.075m * rawBrokerFee;
            decimal rawWht = 0.05m * rawBrokerFee;

            decimal brokerFee = Math.Round(rawBrokerFee, 2);
            decimal vat = Math.Round(rawVat, 2);
            decimal wht = Math.Round(rawWht, 2);

            decimal totalDebit = brokerFee + vat;
            decimal totalCredit = totalDebit - wht;
            decimal finalAdjustedPremium = premium - totalCredit;

            var expenseLedger = await _rubyDbContext.ExpenseLedgers
                .Where(d => d.ProductId == productId)
                .ToListAsync();

            var brokerExpense = expenseLedger
                .FirstOrDefault(d => d.AccountName == "Broker Commissions Expense");

            var brokerAccount = await _rubyDbContext.BusinessBrokeredDetails
                .FirstOrDefaultAsync(d => d.BusinessInfoId == policy.Id);

            var Payable = await _adminService.GetExternalEntityById(brokerAccount.BrokerId);

            var withholdingLedger = await _rubyDbContext.PayableLedgers
                .FirstOrDefaultAsync(d => d.ProductId == productId && d.AccountName == "Witholding Tax Ledger");

            return new BookingBrokerCommissionsResponse
            {
                Credits = new List<CommissionsBrokerCreditResponse>
        {
            new CommissionsBrokerCreditResponse
            {
                AccountName = Payable.Data?.Name ?? "",
                Description = $"{Payable.Data?.Name} ({Payable.Data?.payableAccountNumber} - Payable)",
                BrokerCommission = Math.Round(totalCredit, 2),
                AccountNumber = Payable.Data?.payableAccountNumber,
                PostType = "Broker Commission",
                IsCustomerAccountNumber = false
            },
            new CommissionsBrokerCreditResponse
            {
                AccountName = "WHT Payable Ledger",
                Description = $"WHT Payable ({withholdingLedger?.AccountNumber} - Payable)",
                BrokerCommission = wht,
                AccountNumber = withholdingLedger?.AccountNumber,
                PostType = "WithHolding Tax",
                IsCustomerAccountNumber = false
            }
        },
                Debits = new List<CommissionsBrokerDebitResponse>
        {
            new CommissionsBrokerDebitResponse
            {
                AccountName = brokerExpense?.AccountName,
                Description = $"Broker Commission ({brokerExpense?.AccountNumber} - Expense)",
                Amount = brokerFee,
                AccountNumber = brokerExpense?.AccountNumber,
                PostType = "Broker Commission",
                IsCustomerAccountNumber = false
            },
            new CommissionsBrokerDebitResponse
            {
                AccountName = "VAT Expense Ledger",
                Description = $"VAT Expense Ledger (7411000012 - Expense)",
                Amount = vat,
                AccountNumber = "7411000012",
                PostType = "Value Added Tax",
                IsCustomerAccountNumber = false
            }
        },
                NewPremium = Math.Round(finalAdjustedPremium, 2),
                VoucherNo = transactions?.TransactionVoucher ?? "",
                VocherType = "Broker Commission Voucher",
                Description = $"Being Broker Commission Payment From : {product?.Name}"
            };
        }
        public async Task<BookingCommissionAgentResponse> CalculateAgentCommission(decimal premium, int policyId, int productId)
        {
            var sbus = await _rubyDbContext.BookingSbus
                .Where(s => s.BookingId == policyId)
                .ToListAsync();

            if (!sbus.Any())
                return new BookingCommissionAgentResponse
                {
                    NewPremium = premium,
                    Credits = new(),
                    Debits = new(),
                    VoucherNo = "",
                    VocherType = "Agent Commission Voucher",
                    Description = "No SBU found for this policy"
                };

            var agentFeeSetup = await _rubyDbContext.ProductFeeSetups
                .FirstOrDefaultAsync(x => x.ProductId == productId && (x.FeeName == "Agent fees" || x.FeeName == "Agent fee"));

            if (agentFeeSetup == null)
                return new BookingCommissionAgentResponse
                {
                    NewPremium = premium,
                    Credits = new(),
                    Debits = new(),
                    VoucherNo = "",
                    VocherType = "Agent Commission Voucher",
                    Description = "Agent fee setup not configured"
                };

            var expenseLedgers = await _rubyDbContext.ExpenseLedgers
                .Where(x => x.ProductId == productId)
                .ToListAsync();

            var vatLedger = expenseLedgers.FirstOrDefault(x => x.Description == "VAT Expense");
            var whtLedger = expenseLedgers.FirstOrDefault(x => x.Description == "WHT Payable");

            var agentLedger = await _rubyDbContext.ExpenseLedgers
                .FirstOrDefaultAsync(x => x.ProductId == productId && x.Description == "Agent Commissions Expense");

            var withoutTask = await _rubyDbContext.PayableLedgers.FirstOrDefaultAsync(d => d.ProductId == productId && d.AccountName == "Witholding Tax Ledger");

            List<CommissionAgentCreditResponse> credits = new();
            List<CommissionAgentDebitResponse> debits = new();
            decimal totalPayable = 0m;

            foreach (var sbu in sbus)
            {
                var sbuPremium = (sbu.ProportionPercentage / 100m) * premium;
                var agentCommissionBase = (agentFeeSetup.PercentageValue / 100m) * sbuPremium;

                var agents = await _rubyDbContext.BookingSbuAgents
                    .Where(a => a.BookingSbuId == sbu.Id)
                    .ToListAsync();

                foreach (var agent in agents)
                {
                    // 1. Calculate and Round the Agent Share First
                    var agentShare = Math.Round((agent.ProportionPercentage / 100m) * agentCommissionBase, 2);

                    // 2. Calculate VAT and WHT based on Rounded Agent Share
                    var vat = Math.Round(agentShare * 0.025m, 2);
                    var wht = Math.Round(agentShare * 0.05m, 2);

                    // 3. Calculate Gross Payable
                    var grossPayable = Math.Round(agentShare + vat - wht, 2);

                    totalPayable += grossPayable;

                    // CREDIT: Agent Commission Payable
                    credits.Add(new CommissionAgentCreditResponse
                    {
                        AccountName = "Agent Commission Payable",
                        Description = $"Commission payable to agent: {agent.Name}",
                        Amount = grossPayable,
                        AccountNumber = "6144000013",
                        PostType = "Agent Commission",
                        IsCustomerAccountNumber = false
                    });

                    // CREDIT: WHT
                    credits.Add(new CommissionAgentCreditResponse
                    {
                        AccountName = "WHT Payable Ledger",
                        Description = $"WHT Payable ({withoutTask?.AccountNumber ?? "Unknown"} - Payable)",
                        Amount = wht,
                        AccountNumber = withoutTask?.AccountNumber ?? "DefaultWHTLedger",
                        PostType = "WithHolding Tax",
                        IsCustomerAccountNumber = false
                    });

                    // DEBIT: Agent Commission Expense
                    debits.Add(new CommissionAgentDebitResponse
                    {
                        AccountName = "Agent commision expense",
                        Description = $"Commission expense: ({agentLedger?.AccountNumber ?? "6113800005"} -expense)",
                        Amount = agentShare,
                        AccountNumber = agentLedger?.AccountNumber ?? "6113800005",
                        PostType = "Agent Commission",
                        IsCustomerAccountNumber = false
                    });

                    // DEBIT: VAT
                    debits.Add(new CommissionAgentDebitResponse
                    {
                        AccountName = vatLedger?.AccountName ?? "VAT Expense",
                        Description = $"VAT on agent: {agent.Name}",
                        Amount = vat,
                        AccountNumber = vatLedger?.AccountNumber ?? "7411000012",
                        PostType = "Value Added Tax",
                        IsCustomerAccountNumber = false
                    });
                }
            }

            // After building all entries: Final Adjustment for rounding difference
            var totalCredit = credits.Sum(c => Math.Round(c.Amount, 2));
            var totalDebit = debits.Sum(d => Math.Round(d.Amount, 2));

            var roundingDifference = Math.Round(totalCredit - totalDebit, 2);

            if (roundingDifference != 0 && Math.Abs(roundingDifference) < 1)
            {
                // Adjust last debit entry
                var lastDebit = debits.LastOrDefault();
                if (lastDebit != null)
                {
                    lastDebit.Amount += roundingDifference;
                }
            }

            var product = await _rubyDbContext.Products.FirstOrDefaultAsync(d => d.Id == productId);
            var master = await _rubyDbContext.BookingOperationalTransactionsMasters
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            BookingOperationalSettlementDetails transactions = null;
            if (master != null)
            {
                transactions = await _rubyDbContext.BookingOperationalSettlementDetails
                    .FirstOrDefaultAsync(d => d.TransactionId == master.Id && d.PostingType == "Agent Commission");
            }

            return new BookingCommissionAgentResponse
            {
                NewPremium = Math.Round(premium - totalPayable, 2),
                Credits = credits,
                Debits = debits,
                VoucherNo = transactions?.TransactionVoucher ?? "",
                VocherType = "Agent Commission Voucher",
                Description = $"Being Agent Commission Payment From : {product?.Name}"
            };
        }
        public async Task<ReinsuranceResponse> CalculateReinsurance(
                         decimal originalPremium,
                         decimal originalSumInsure,
                         int policyId,
                         int productId,
                         List<CoInsuranceDetail> coInsuranceDetails)
        {

            var booking = await _rubyDbContext.PolicyBookings.Include(d => d.Quotation)
                .FirstOrDefaultAsync(d => d.Id == policyId);

            var product = await _rubyDbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);

            var (axaPremium, axaSumInsured) = await GetLeadShareWithManagementFee(
                coInsuranceDetails, originalPremium, originalSumInsure, productId);

            decimal retention = 50000m;
            decimal treaty = 350000m;
            decimal excess = axaSumInsured - (retention + treaty);

            decimal retentionRatio = axaSumInsured == 0 ? 0 : retention / axaSumInsured;
            decimal treatyRatio = axaSumInsured == 0 ? 0 : treaty / axaSumInsured;

            decimal retentionPremium = retentionRatio * originalPremium;
            decimal treatyPremium = treatyRatio * originalPremium;
            decimal totalUnderwritingPremium = retentionPremium + treatyPremium;
            decimal excessPremium = axaPremium - totalUnderwritingPremium;

            decimal totalReinsurancePremium = 0;
            decimal totalCommissionInward = 0;

            var reinsurers = coInsuranceDetails.Where(c => c.Portion >= 50).ToList();

            var master = await _rubyDbContext.BookingOperationalTransactionsMasters
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            BookingOperationalSettlementDetails transactions = null;
            if (master != null)
            {
                transactions = await _rubyDbContext.BookingOperationalSettlementDetails
                    .FirstOrDefaultAsync(d => d.TransactionId == master.Id && d.PostingType == "Reinsurance");
            }

            var reinsuranceResponse = new ReinsuranceResponse
            {
                Debits = new(),
                Credits = new(),
                VoucherNo = transactions?.TransactionVoucher ?? "",
                VocherType = "Reinsurance Premium Voucher",
                Description = $"Being Reinsurance Premium From {product?.Name ?? "Unknown Product"}"
            };

            foreach (var reinsurer in reinsurers)
            {
                // Calculate share and commission
                var share = (reinsurer.Portion / 100m) * treatyPremium;
                var commission = share * 0.10m;

                // Round share and commission before adding to totals
                share = Math.Round(share, 2);
                commission = Math.Round(commission, 2);

                // Add to total premiums and commissions
                totalReinsurancePremium += share;
                totalCommissionInward += commission;

                var incomeLedger = await _rubyDbContext.IncomeLedgers
                    .FirstOrDefaultAsync(x => x.ProductId == productId && x.AccountName == "Reinsurance Commissions");

                var expenseLedger = await _rubyDbContext.ExpenseLedgers
                    .FirstOrDefaultAsync(x => x.ProductId == productId && x.AccountName == "Reinsurance Premium Expense");

                reinsuranceResponse.Debits.Add(new ReinsuranceDebitResponse
                {
                    AccountName = expenseLedger?.AccountName ?? "Reinsurance Premium Expense",
                    Description = $"Premium expense for reinsurer",
                    Amount = share,
                    AccountNumber = expenseLedger?.AccountNumber ?? "7400000001",
                    PostType = "Reinsurance",
                    IsCustomerAccountNumber = false
                });

                reinsuranceResponse.Credits.Add(new ReinsuranceCreditResponse
                {
                    AccountName = "Reinsurer Payable",
                    Description = $"Payable to reinsurer (net of commission)",
                    Amount = share - commission,
                    AccountNumber = "6144000011",
                    PostType = "Reinsurance",
                    IsCustomerAccountNumber = false
                });

                reinsuranceResponse.Credits.Add(new ReinsuranceCreditResponse
                {
                    AccountName = incomeLedger?.AccountName ?? "Reinsurance Commission Income",
                    Description = $"Commission inward from reinsurer",
                    Amount = commission,
                    AccountNumber = incomeLedger?.AccountNumber ?? "6144000024",
                    PostType = "Reinsurance",
                    IsCustomerAccountNumber = false
                });
            }

            // Apply rounding only at the final step for total premiums and commissions
            reinsuranceResponse.TotalReinsurancePremium = Math.Round(totalReinsurancePremium, 2);
            reinsuranceResponse.TotalCommissionInward = Math.Round(totalCommissionInward, 2);

            return reinsuranceResponse;
        }



       












        #region Financial Simulation
        public async Task<BaseResponse<bool>> CreateFinancialSimulation(int policyId)
        {
            var policy = await _rubyDbContext.PolicyBookings.FirstOrDefaultAsync(d => d.Id == policyId);
            if (policy == null)
                return ResponseFactory.CreateError<bool>("policy not found", HttpStatusCode.NotFound);

            var products = await _rubyDbContext.Products.FirstOrDefaultAsync(d => d.Id == policy.ProductId);

            var businessInformation = await GetBusinessInformation(policyId);
            if (businessInformation == null)
                return ResponseFactory.CreateError<bool>("Business Information Does not Exist", HttpStatusCode.NotFound);

            bool statusMessage;  // Initialize a variable for the status message


            if (products.RequireUnderWritingAtBooking)
            {
                policy.SaveState = PolicyBookingStatus.Complete.GetDescription();
                policy.Status = "RequireUnderWriting";
                await _rubyDbContext.SaveChangesAsync();

                await CreateWorkflowApproval(policyId, policy.CustomerName);

                statusMessage = true;
            }
            else
            {
                policy.SaveState = PolicyBookingStatus.Complete.GetDescription();
                policy.PolicyKey = await GeneratePolicyKeyAsync(policyId);
                policy.Status = "Approved";
                await _rubyDbContext.SaveChangesAsync();
                statusMessage = false;
                await FinancialSimulationLoad(policyId);

            }

            return ResponseFactory.CreateSuccess<bool>(statusMessage, "Financial simulation has been created successfully");
            
        }

        private async Task<BaseResponse<GenericNameResponse>> FinancialSimulation(int policyId)
        {
            var policy = await _rubyDbContext.PolicyBookings
                .Include(d => d.Quotation)
                .FirstOrDefaultAsync(d => d.Id == policyId);
            if (policy == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Policy not found", HttpStatusCode.NotFound);

            var product = await _rubyDbContext.Products.FirstOrDefaultAsync(d => d.Id == policy.ProductId);
            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found", HttpStatusCode.NotFound);

            decimal originalPremium = policy.Quotation.Premium ?? 0;
            decimal adjustedPremium = originalPremium;
            int productId = policy.ProductId;

            var businessInformation = await GetBusinessInformation(policyId);
            if (businessInformation == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Business Information Does not Exist", HttpStatusCode.NotFound);
            var bookDetails = await _rubyDbContext.BookingDetail.FirstOrDefaultAsync(d => d.BookingId == policy.Id);

            List<string> receiptNumbers = new();

            if (bookDetails.PaymentType == "Cash Payment")
            {


                var eligibility = await _rubyDbContext.EligibilityPeriods
                      .Where(d => d.BookingId == policy.Id)
                      .ToListAsync();

                var distinctEligibility = eligibility
                    .Where(e => !string.IsNullOrWhiteSpace(e.ReceiptReference))
                    .DistinctBy(e => e.ReceiptReference)
                    .ToList();

                receiptNumbers = distinctEligibility
                    .Select(e => e.ReceiptReference)
                    .ToList();


            }


            var master = new BookingOperationalTransactionsMaster
            {
                BookingId = policyId,
                TransactionDate = DateTime.UtcNow,
                Premium = adjustedPremium,
                Description = "Financial simulation for policy",
                VoucherType = "Comprehensive Financial Voucher",
                VoucherNo = ""
            };

            var settlementDetails = new List<BookingOperationalSettlementDetails>();

            var IncomeKey = Guid.NewGuid().ToString("N")[..15];
            var managementKey = Guid.NewGuid().ToString("N")[..15];
            var brokerkey = Guid.NewGuid().ToString("N")[..15];
            var costKey = Guid.NewGuid().ToString("N")[..15];
            var agentKey = Guid.NewGuid().ToString("N")[..15];
            var reinsuranKey = Guid.NewGuid().ToString("N")[..15];


            // 1️⃣ Income Recognition
            var incomeRecognition = await IncomeRecognition(policyId, adjustedPremium);
            foreach (var debit in incomeRecognition.Debits)
            {

                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = IncomeKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }
            foreach (var credit in incomeRecognition.Credits)
            {

                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = IncomeKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            // 2️⃣ Management Fee
            var managementFee = await ManagementFee(adjustedPremium, policyId, productId, businessInformation.Id);
            if (managementFee != null)
            {
                foreach (var debit in managementFee.Debits)
                {

                    settlementDetails.Add(new BookingOperationalSettlementDetails
                    {
                        AccountName = debit.AccountName,
                        Description = debit.Description,
                        Amount = debit.Amount,
                        OperationType = OperationType.Debit.GetDescription(),
                        AccountNumber = debit.AccountNumber,
                        LedgerGroupKey = managementKey,
                        PostingType = debit.PostType,
                        isCustomerAccountNumber = debit.IsCustomerAccountNumber
                    });
                }
                foreach (var credit in managementFee.Credits)
                {
                    settlementDetails.Add(new BookingOperationalSettlementDetails
                    {
                        AccountName = credit.AccountName,
                        Description = credit.Description,
                        Amount = credit.Amount,
                        OperationType = OperationType.Credit.GetDescription(),
                        AccountNumber = credit.AccountNumber,
                        LedgerGroupKey = managementKey,
                        PostingType = credit.PostType,
                        isCustomerAccountNumber = credit.IsCustomerAccountNumber
                    });
                }

                adjustedPremium = managementFee.NewPremium;
            }

            // 3️⃣ Broker Commission
            var brokerCommission = await CalculateBrokerCommission(adjustedPremium, policyId, productId);


            foreach (var debit in brokerCommission.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount ?? 0,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = brokerkey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }
            foreach (var credit in brokerCommission.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.BrokerCommission ?? 0,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = brokerkey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            adjustedPremium = brokerCommission.NewPremium;

            // 4️⃣ Cost of Insurance
            var costOfInsurance = await CalculateCostOfInsuranceFee(adjustedPremium, productId, policyId);

            foreach (var debit in costOfInsurance.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = costKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }
            foreach (var credit in costOfInsurance.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = costKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            adjustedPremium = costOfInsurance.NewPremium;

            // 5️⃣ Agent Commission
            var agentCommissionResponse = await CalculateAgentCommission(adjustedPremium, policyId, productId);

            foreach (var credit in agentCommissionResponse.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = agentKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            foreach (var debit in agentCommissionResponse.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = agentKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }

            adjustedPremium = agentCommissionResponse.NewPremium;

            //// 6️⃣ Reinsurance
            var reinsuranceResponse = await CalculateReinsurance(originalPremium, policy.Quotation.SumInsured ?? 0, policyId, productId, businessInformation.CoInsuranceDetails);

            foreach (var credit in reinsuranceResponse.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = reinsuranKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            foreach (var debit in reinsuranceResponse.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = reinsuranKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }

            // Save Master and Details

            await _rubyDbContext.BookingOperationalTransactionsMasters.AddAsync(master);
            await _rubyDbContext.SaveChangesAsync();

            foreach (var detail in settlementDetails)
            {
                detail.TransactionId = master.Id;
            }

            await _rubyDbContext.BookingOperationalSettlementDetails.AddRangeAsync(settlementDetails);
            await _rubyDbContext.SaveChangesAsync();

          

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("FinancialSimulation Created", HttpStatusCode.Created);
          



            //await _serviceIntegration.PostToFinanceSystemAsync(financePayload);

           
        }

        public async Task<BaseResponse<GenericNameResponse>> ApprovePolicy(int policyId)
        {
            var policy = await _rubyDbContext.PolicyBookings.FirstOrDefaultAsync(d => d.Id == policyId);
            if (policy == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Policy Not Found", HttpStatusCode.NotFound);

            policy.Status = "Approved";
            policy.PolicyKey = await GeneratePolicyKeyAsync(policy.Id);

            await _rubyDbContext.SaveChangesAsync();

            await FinancialSimulationLoad(policyId);


            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Financial simulation failed", HttpStatusCode.OK);
        }


        public async Task<BaseResponse<object>> FinancialSimulationLoad(int policyId)
        {
            var policy = await _rubyDbContext.PolicyBookings
                .Include(d => d.Quotation)
                .FirstOrDefaultAsync(d => d.Id == policyId);
            if (policy == null)
                return ResponseFactory.CreateError<object>("Policy not found", HttpStatusCode.NotFound);

            var product = await _rubyDbContext.Products.FirstOrDefaultAsync(d => d.Id == policy.ProductId);
            if (product == null)
                return ResponseFactory.CreateError<object>("Product not found", HttpStatusCode.NotFound);

            decimal originalPremium = policy.Quotation.Premium ?? 0;
            decimal adjustedPremium = originalPremium;
            int productId = policy.ProductId;

            var businessInformation = await GetBusinessInformation(policyId);
            if (businessInformation == null)
                return ResponseFactory.CreateError<object>("Business Information Does not Exist", HttpStatusCode.NotFound);
            var bookDetails = await _rubyDbContext.BookingDetail.FirstOrDefaultAsync(d => d.BookingId == policy.Id);

            List<string> receiptNumbers = new();

            if (bookDetails.PaymentType == "Cash Payment")
            {


                var eligibility = await _rubyDbContext.EligibilityPeriods
                      .Where(d => d.BookingId == policy.Id)
                      .ToListAsync();

                var distinctEligibility = eligibility
                    .Where(e => !string.IsNullOrWhiteSpace(e.ReceiptReference))
                    .DistinctBy(e => e.ReceiptReference)
                    .ToList();

                receiptNumbers = distinctEligibility
                    .Select(e => e.ReceiptReference)
                    .ToList();


            }


            var master = new BookingOperationalTransactionsMaster
            {
                BookingId = policyId,
                TransactionDate = DateTime.UtcNow,
                Premium = adjustedPremium,
                Description = "Financial simulation for policy",
                VoucherType = "Comprehensive Financial Voucher",
                VoucherNo = ""
            };

            var settlementDetails = new List<BookingOperationalSettlementDetails>();

            var IncomeKey = Guid.NewGuid().ToString("N")[..15];
            var managementKey = Guid.NewGuid().ToString("N")[..15];
            var brokerkey = Guid.NewGuid().ToString("N")[..15];
            var costKey = Guid.NewGuid().ToString("N")[..15];
            var agentKey = Guid.NewGuid().ToString("N")[..15];
            var reinsuranKey = Guid.NewGuid().ToString("N")[..15];


            // 1️⃣ Income Recognition
            var incomeRecognition = await IncomeRecognition(policyId, adjustedPremium);
            foreach (var debit in incomeRecognition.Debits)
            {

                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = IncomeKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }
            foreach (var credit in incomeRecognition.Credits)
            {

                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = IncomeKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            // 2️⃣ Management Fee
            var managementFee = await ManagementFee(adjustedPremium, policyId, productId, businessInformation.Id);
            if (managementFee != null)
            {
                foreach (var debit in managementFee.Debits)
                {

                    settlementDetails.Add(new BookingOperationalSettlementDetails
                    {
                        AccountName = debit.AccountName,
                        Description = debit.Description,
                        Amount = debit.Amount,
                        OperationType = OperationType.Debit.GetDescription(),
                        AccountNumber = debit.AccountNumber,
                        LedgerGroupKey = managementKey,
                        PostingType = debit.PostType,
                        isCustomerAccountNumber = debit.IsCustomerAccountNumber
                    });
                }
                foreach (var credit in managementFee.Credits)
                {
                    settlementDetails.Add(new BookingOperationalSettlementDetails
                    {
                        AccountName = credit.AccountName,
                        Description = credit.Description,
                        Amount = credit.Amount,
                        OperationType = OperationType.Credit.GetDescription(),
                        AccountNumber = credit.AccountNumber,
                        LedgerGroupKey = managementKey,
                        PostingType = credit.PostType,
                        isCustomerAccountNumber = credit.IsCustomerAccountNumber
                    });
                }

                adjustedPremium = managementFee.NewPremium;
            }


            var costOfInsurance = await CalculateCostOfInsuranceFee(adjustedPremium, productId, policyId);

            foreach (var debit in costOfInsurance.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = costKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }
            foreach (var credit in costOfInsurance.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = costKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            adjustedPremium = costOfInsurance.NewPremium;

            //3️⃣ Broker Commission
            var brokerCommission = await CalculateBrokerCommission(adjustedPremium, policyId, productId);


            foreach (var debit in brokerCommission.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount ?? 0,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = brokerkey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }
            foreach (var credit in brokerCommission.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.BrokerCommission ?? 0,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = brokerkey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            adjustedPremium = brokerCommission.NewPremium;




            ////// 5️⃣ Agent Commission
            var agentCommissionResponse = await CalculateAgentCommission(adjustedPremium, policyId, productId);

            foreach (var credit in agentCommissionResponse.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = agentKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            foreach (var debit in agentCommissionResponse.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = agentKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }

            adjustedPremium = agentCommissionResponse.NewPremium;

            ////// 6️⃣ Reinsurance
            var reinsuranceResponse = await CalculateReinsurance(originalPremium, policy.Quotation.SumInsured ?? 0, policyId, productId, businessInformation.CoInsuranceDetails);

            foreach (var credit in reinsuranceResponse.Credits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = credit.AccountName,
                    Description = credit.Description,
                    Amount = credit.Amount,
                    OperationType = OperationType.Credit.GetDescription(),
                    AccountNumber = credit.AccountNumber,
                    LedgerGroupKey = reinsuranKey,
                    PostingType = credit.PostType,
                    isCustomerAccountNumber = credit.IsCustomerAccountNumber
                });
            }

            foreach (var debit in reinsuranceResponse.Debits)
            {
                settlementDetails.Add(new BookingOperationalSettlementDetails
                {
                    AccountName = debit.AccountName,
                    Description = debit.Description,
                    Amount = debit.Amount,
                    OperationType = OperationType.Debit.GetDescription(),
                    AccountNumber = debit.AccountNumber,
                    LedgerGroupKey = reinsuranKey,
                    PostingType = debit.PostType,
                    isCustomerAccountNumber = debit.IsCustomerAccountNumber
                });
            }

            // Save Master and Details

            await _rubyDbContext.BookingOperationalTransactionsMasters.AddAsync(master);
            await _rubyDbContext.SaveChangesAsync();

            foreach (var detail in settlementDetails)
            {
                detail.TransactionId = master.Id;
            }

            await _rubyDbContext.BookingOperationalSettlementDetails.AddRangeAsync(settlementDetails);
            await _rubyDbContext.SaveChangesAsync();

            if (bookDetails?.PaymentType == "Cash Payment")
            {
                var eligibility = await _rubyDbContext.EligibilityPeriods
                    .Where(d => d.BookingId == master.BookingId)
                    .ToListAsync();

                receiptNumbers = eligibility
                    .Where(e => !string.IsNullOrWhiteSpace(e.ReceiptReference))
                    .DistinctBy(e => e.ReceiptReference)
                    .Select(e => e.ReceiptReference)
                    .ToList();

                var settlementMe = await _rubyDbContext.BookingOperationalSettlementDetails
              .Where(d => d.TransactionId == master.Id)
              .ToListAsync();

                var groupedDetails = settlementDetails
                    .GroupBy(d => d.LedgerGroupKey)
                    .ToList();

                var policyBooking = await _rubyDbContext.PolicyBookings.FirstOrDefaultAsync(d => d.Id == master.BookingId);
                var postingPayload = new FinancePostingPayload
                {
                    EntityId = 1,
                    OfficeId = 1,
                    TransactionSource = "PolicySettlement",
                    TransactionSourceUniqueNumber = policyBooking.PolicyId,
                    CurrencyCode = "NGN",
                    TransactionDate = DateTime.UtcNow,
                    TotalAmount = settlementDetails.Where(d => d.OperationType == "Debit").Sum(d => d.Amount),
                    Narration = $"Voucher posting for policy {policyBooking.PolicyId}",
                    ReceiptNumbers = receiptNumbers,
                    PostingDetails = new List<FinancePostingDetail>()
                };

                foreach (var group in groupedDetails)
                {
                    foreach (var entry in group)
                    {
                        var amount = entry.Amount;
                        var description = entry.Description;
                        var postingType = entry.PostingType;
                        var batchRef = group.Key;
                        var accountNumber = entry.AccountNumber;
                        var isCustomerAccount = entry.isCustomerAccountNumber;

                        postingPayload.PostingDetails.Add(new FinancePostingDetail
                        {
                            BatchReference = batchRef,
                            PostingType = postingType,
                            TransactionDate = DateTime.UtcNow,
                            IsCustomerAccountNumber = isCustomerAccount,
                            AccountNumber = accountNumber,
                            Amount = amount,
                            Description = description,
                            DoubleLedgerEntry = entry.OperationType == "Debit" ? "Dr" : "Cr"
                        });
                    }
                }

                try
                {
                    var apiResponse = await _serviceIntegration.PostToFinanceSystemAsync(postingPayload);

                //Optional: you may need to deserialize the Data if it's not already a dictionary-like structure
                    var financeData = JsonConvert.DeserializeObject<FinanceData>(JsonConvert.SerializeObject(apiResponse.Data));

                    var voucherData = financeData.Transactions;

                    if (voucherData != null)
                    {
                        foreach (var item in voucherData)
                        {
                            string batchRef = item.BatchReference;
                            string voucherNumber = item.VoucherNumber;

                            var matchedEntries = settlementDetails
                                .Where(s => s.LedgerGroupKey == batchRef)
                                .ToList();

                            foreach (var detail in matchedEntries)
                            {
                                detail.TransactionVoucher = voucherNumber;
                            }
                        }

                        master.VoucherNo = financeData.TransactionReference;

                        await _rubyDbContext.SaveChangesAsync();
                    }

                    return ResponseFactory.CreateSuccess<object>(apiResponse.Message, "");
                }
                catch (Exception ex)
                {
                    return ResponseFactory.CreateError<object>($"Failed to post to finance system: {ex.Message}", HttpStatusCode.InternalServerError);
                }

               
            }
            else
            {
                return ResponseFactory.CreateSuccessWithOutData<object>("", HttpStatusCode.OK);
            }


           
        }


        public async Task<BaseResponse<object>> SendToFinanceSystemAsync(int policyId)
        {

            var master = await _rubyDbContext.BookingOperationalTransactionsMasters
                .FirstOrDefaultAsync(d => d.BookingId == policyId);
            if (master == null)
                return ResponseFactory.CreateError<object>("Master Table does not exist", HttpStatusCode.NotFound);

            var bookDetails = await _rubyDbContext.BookingDetail
                .FirstOrDefaultAsync(d => d.BookingId == master.BookingId);

            List<string> receiptNumbers = new();
            if (bookDetails?.PaymentType == "Cash Payment")
            {
                var eligibility = await _rubyDbContext.EligibilityPeriods
                    .Where(d => d.BookingId == master.BookingId)
                    .ToListAsync();

                receiptNumbers = eligibility
                    .Where(e => !string.IsNullOrWhiteSpace(e.ReceiptReference))
                    .DistinctBy(e => e.ReceiptReference)
                    .Select(e => e.ReceiptReference)
                    .ToList();

                var settlementDetails = await _rubyDbContext.BookingOperationalSettlementDetails
              .Where(d => d.TransactionId == master.Id)
              .ToListAsync();

                var groupedDetails = settlementDetails
                    .GroupBy(d => d.LedgerGroupKey)
                    .ToList();

                var policyBooking = await _rubyDbContext.PolicyBookings.FirstOrDefaultAsync(d => d.Id == master.BookingId);
                var postingPayload = new FinancePostingPayload
                {
                    EntityId = 1,
                    OfficeId = 1,
                    TransactionSource = "PolicySettlement",
                    TransactionSourceUniqueNumber = policyBooking.PolicyId,
                    CurrencyCode = "NGN",
                    TransactionDate = DateTime.UtcNow,
                    TotalAmount = settlementDetails.Where(d => d.OperationType == "Debit").Sum(d => d.Amount),
                    Narration = $"Voucher posting for policy {policyBooking.PolicyId}",
                    ReceiptNumbers = receiptNumbers,
                    PostingDetails = new List<FinancePostingDetail>()
                };

                foreach (var group in groupedDetails)
                {
                    foreach (var entry in group)
                    {
                        var amount = entry.Amount;
                        var description = entry.Description;
                        var postingType = entry.PostingType;
                        var batchRef = group.Key;
                        var accountNumber = entry.AccountNumber;
                        var isCustomerAccount = entry.isCustomerAccountNumber;

                        postingPayload.PostingDetails.Add(new FinancePostingDetail
                        {
                            BatchReference = batchRef,
                            PostingType = postingType,
                            TransactionDate = DateTime.UtcNow,
                            IsCustomerAccountNumber = isCustomerAccount,
                            AccountNumber = accountNumber,
                            Amount = amount,
                            Description = description,
                            DoubleLedgerEntry = entry.OperationType == "Debit" ? "Dr" : "Cr"
                        });
                    }
                }

                try
                {
                    var apiResponse = await _serviceIntegration.PostToFinanceSystemAsync(postingPayload);

                    // Optional: you may need to deserialize the Data if it's not already a dictionary-like structure
                    var financeData = JsonConvert.DeserializeObject<FinanceData>(JsonConvert.SerializeObject(apiResponse.Data));

                    var voucherData = financeData.Transactions;

                    if (voucherData != null)
                    {
                        foreach (var item in voucherData)
                        {
                            string batchRef = item.BatchReference;
                            string voucherNumber = item.VoucherNumber;

                            var matchedEntries = settlementDetails
                                .Where(s => s.LedgerGroupKey == batchRef)
                                .ToList();

                            foreach (var detail in matchedEntries)
                            {
                                detail.TransactionVoucher = voucherNumber;
                            }
                        }

                        master.VoucherNo = financeData.TransactionReference;

                        await _rubyDbContext.SaveChangesAsync();
                    }

                    return ResponseFactory.CreateSuccess<object>(apiResponse.Data, "");
                }
                catch (Exception ex)
                {
                    return ResponseFactory.CreateError<object>($"Failed to post to finance system: {ex.Message}", HttpStatusCode.InternalServerError);
                }
            }
            else
            {
                return ResponseFactory.CreateSuccessWithOutData<object>("", HttpStatusCode.OK);
            }

          
        }
       
        private void ReplaceText(WordprocessingDocument doc, string placeholder, string newValue)
        {
            bool replaced = false;
            foreach (var text in doc.MainDocumentPart.Document.Descendants<Text>())
            {
                if (text.Text.Contains(placeholder))
                {
                    text.Text = text.Text.Replace(placeholder, newValue);
                    replaced = true;
                }
            }

            if (!replaced)
            {
                // Log placeholder not found for troubleshooting
                Console.WriteLine($"No placeholder found for: {placeholder}");
            }
        }
       
        public async Task<byte[]> GenerateCertificateAsync(int policyId)
        {
            var templatePath = System.IO.Path.Combine(_webHostEnvironment.ContentRootPath, "Resources", "DocumentTemplates", "motor_template.pdf");

            await using var fileStream = System.IO.File.OpenRead(templatePath);

            var policy = await _rubyDbContext.PolicyBookings
                .Include(d => d.BookingDetails)
                .FirstOrDefaultAsync(d => d.Id == policyId);

            // Path to your original template PDF


            // Create a memory stream to hold the output PDF
            using var memoryStream = new MemoryStream();
            using var reader = new PdfReader(fileStream);
            using var writer = new PdfWriter(memoryStream);
            using var pdfDoc = new PdfDocument(reader, writer);

            // Access the first page
            var page = pdfDoc.GetFirstPage();
            var canvas = new PdfCanvas(page);

            // Use built-in Helvetica font
            var font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            canvas.SetFontAndSize(font, 10);

            // Dummy data to render (you can replace these)
            string certificateNumber = "CERT-AXA-2024-0001";
            string policyNumber = policy.PolicyId;
            string regNumber = "ABC-123XYZ";
            string policyHolder = policy.CustomerName;
            DateTime startDate = policy.BookingDetails.FirstOrDefault().PolicyActiveStateDate;
            DateTime endDate = policy.BookingDetails.FirstOrDefault().PolicyActiveEndDate;
            string vehicleClass = "Private - Saloon";

            // Begin writing text
            canvas.BeginText();
            canvas.SetFontAndSize(font, 10);

            // Coordinates based on visual estimation — adjust as needed
            canvas.MoveText(140, 675); // Certificate No.
            canvas.ShowText(certificateNumber);

            canvas.ShowText(certificateNumber);
            canvas.MoveText(0, -15);
            canvas.ShowText(policyNumber);
            canvas.MoveText(0, -25);
            canvas.ShowText(regNumber);
            canvas.MoveText(0, -25);
            canvas.ShowText(policyHolder);
            canvas.MoveText(0, -25);
            canvas.ShowText(startDate.ToString("dd/MM/yyyy")); // ✅ fixed
            canvas.MoveText(0, -25);
            canvas.ShowText(endDate.ToString("dd/MM/yyyy"));   // ✅ fixed


            canvas.MoveText(0, -30); // Vehicle Class
            canvas.ShowText(vehicleClass);

            canvas.EndText();

            pdfDoc.Close();
            return memoryStream.ToArray();
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateWorkflowApproval(int policyId, string productName)
        {
            // Fetch the workflow module from the external service
            var workflowService = _serviceProvider.GetRequiredService<IWorkflowService>();
            var module = await workflowService.GetAllWorkflowProcessByModuleForPolicyBook();

            if (module == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Workflow Module is not available", HttpStatusCode.NotFound);

            // Create a single workflow with multiple WorkflowProcessIds
            var workflowToAdd = new Workflow()
            {
                CreatedBy = GetUserClaims(),
                DateCreated = DateTime.UtcNow,
                IsApprovalCompleted = false,
                IsServiceNotified = false,
                ProgressPercentage = 0,
                RequestTitle = productName,
                Status = ApprovalStatusEnum.Pending.GetDescription(),
                ModuleId = _configModels.PolicyWorkflowModuleId,
                SourceId =policyId,
                Type = "Policy",
                // Add all WorkflowProcessIds from the module
                WorkflowProcessIds = module.Data.Select(w => w.Id).ToList()
            };

            // Add workflow to the context (will save this to get the generated WorkflowId)
            _rubyDbContext.Workflows.Add(workflowToAdd);
            await _rubyDbContext.SaveChangesAsync();  // Save to get the Workflow Id

            // Now create the associated WorkflowApprovingOffice records for each WorkflowProcessId in the list
            var workflowApprovingOfficesToAdd = new List<WorkflowApprovingOffice>();

            foreach (var workflowProcessId in workflowToAdd.WorkflowProcessIds)
            {
                var workflowProcess = module.Data.FirstOrDefault(w => w.Id == workflowProcessId);

                if (workflowProcess != null)
                {
                    var approvalSetups = workflowProcess.ApprovalSetups;
                    if (approvalSetups != null && approvalSetups.Any())
                    {
                        foreach (var approvalSetup in approvalSetups)
                        {
                            // Add a new WorkflowApprovingOffice record for each approval level for the current WorkflowProcessId
                            var workflowApprovingOfficeToAdd = new WorkflowApprovingOffice()
                            {
                                WorkflowId = workflowToAdd.Id,  // Set the WorkflowId from the saved workflow
                                IsApprovalCompleted = false,
                                ApprovingOffice = approvalSetup.ApprovingOffice,
                                ApprovingOfficeId = approvalSetup.ApprovingOfficeId ?? 0,
                                FunctionId = approvalSetup.FunctionId ?? 0,
                                ApprovalLevel = approvalSetup.Sequence,  // Sequence represents the approval level
                            };

                            workflowApprovingOfficesToAdd.Add(workflowApprovingOfficeToAdd);
                        }
                    }
                }
            }

            // Add all WorkflowApprovingOffices to the context
            _rubyDbContext.WorkflowApprovingOffices.AddRange(workflowApprovingOfficesToAdd);
            await _rubyDbContext.SaveChangesAsync(); // Save changes for WorkflowApprovingOffices

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Successfully saved workflow and approving offices.", HttpStatusCode.OK);
        }
        private string GetUserClaims()
        {
            var userNameClaim = _contextAccessor.HttpContext?.User?.FindFirst("UserName")?.Value;
            return !string.IsNullOrEmpty(userNameClaim) ? userNameClaim : "Anonymous";
        }
        #endregion



     
        public async Task<string> GenerateFilledCertificateDocxAsync(int policyId)
        {
            var policy = await _rubyDbContext.PolicyBookings
                .Include(d => d.BookingDetails)
                .FirstOrDefaultAsync(d => d.Id == policyId);

            if (policy == null)
                throw new Exception("Policy not found.");

            var booking = policy.BookingDetails.FirstOrDefault();
            if (booking == null)
                throw new Exception("Booking detail not found.");

            string templateFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "Resources", "DocumentTemplates");
            string tempFolder = Path.Combine(templateFolder, "TempGenerated");
            Directory.CreateDirectory(tempFolder);

            var policyAttributes = await _rubyDbContext.BookingSubjectAttributes
               .Where(d => d.BookingId == policy.Id)
               .ToListAsync();

          


            string templatePath = Path.Combine(templateFolder, "AxaWorkss.docx");
            string newDocxPath = Path.Combine(tempFolder, $"Filled_{Guid.NewGuid()}.docx");
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(newDocxPath);
            string newPdfPath = Path.Combine(tempFolder, $"{fileNameWithoutExtension}.pdf");

            var qoutation = await _rubyDbContext.BookingSubjectAttributes.Where(d=>d.BookingId == policy.Id).ToListAsync();
            var nincomId = Guid.NewGuid().ToString("N")[..15];

            string carMake = policyAttributes.FirstOrDefault(a => a.AttributeName.ToLower() == "car make")?.AttributeValue ?? "";
            string carModel = policyAttributes.FirstOrDefault(a => a.AttributeName.ToLower() == "car model")?.AttributeValue ?? "";

            string carName = $"{carMake} {carModel}".Trim();



            try
            {
                // Modify document
                using (DocX document = DocX.Load(templatePath))
                {

                    document.ReplaceText("​policy_no", policy.PolicyId ?? "");
                    document.ReplaceText("reg_num", policy.Customer ?? "");
                    document.ReplaceText("customer_name", policy.CustomerName ?? "");
                    document.ReplaceText("startdate", booking.PolicyActiveStateDate.ToString("yyyy-MM-dd"));
                    document.ReplaceText("enddate", booking.PolicyActiveEndDate.ToString("yyyy-MM-dd"));
                    document.ReplaceText("duration", carName); // 👈 inject car make + model here
                    document.ReplaceText("cn", "594233");
                    document.ReplaceText("nm", nincomId.ToString());
                    document.ReplaceText("pn", policy.PolicyKey);
                    document.SaveAs(newDocxPath);
                }

                // Convert to PDF using LibreOffice
                var libreOfficePath = @"C:\LibreOfficePortable\App\libreoffice\program\soffice.exe";
                var convertProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = libreOfficePath,
                        Arguments = $"--headless --convert-to pdf \"{newDocxPath}\" --outdir \"{tempFolder}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    }
                };

                convertProcess.Start();
                string stdout = await convertProcess.StandardOutput.ReadToEndAsync();
                string stderr = await convertProcess.StandardError.ReadToEndAsync();
                await convertProcess.WaitForExitAsync();

                if (!File.Exists(newPdfPath))
                    throw new Exception($"LibreOffice failed to generate PDF at {newPdfPath}. StdOut: {stdout}, StdErr: {stderr}");

                byte[] pdfBytes = await File.ReadAllBytesAsync(newPdfPath);
                string base64String = Convert.ToBase64String(pdfBytes);

                return base64String;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to generate document or convert to PDF: {ex.Message}", ex);
            }
            finally
            {
                // Clean up temp files
                if (File.Exists(newDocxPath))
                    File.Delete(newDocxPath);

                if (File.Exists(newPdfPath))
                    File.Delete(newPdfPath);
            }
        }
        public async Task<string> GenerateCertificatesForFleetAsync(int policyId)
        {
            var policy = await _rubyDbContext.PolicyBookings
                .Include(d => d.BookingDetails)
                .FirstOrDefaultAsync(d => d.Id == policyId);

            if (policy == null)
                throw new Exception("Policy not found.");

            var booking = policy.BookingDetails.FirstOrDefault();
            if (booking == null)
                throw new Exception("Booking detail not found.");

            var policyAttributes = await _rubyDbContext.BookingSubjectAttributes
                .Where(d => d.BookingId == policy.Id)
                .ToListAsync();

            var groupedAttributes = policyAttributes.GroupBy(d => d.EntityId).ToList();

            string templateFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "Resources", "DocumentTemplates");
            string tempFolder = Path.Combine(templateFolder, "TempGenerated");
            Directory.CreateDirectory(tempFolder);

            string templatePath = Path.Combine(templateFolder, "AxaWorkss.docx");

            List<string> generatedPdfPaths = new List<string>();

            var nincomId = Guid.NewGuid().ToString("N")[..15];

            foreach (var group in groupedAttributes)
            {
                var carAttributes = group.ToList();
                string carMake = carAttributes.FirstOrDefault(a => a.AttributeName.ToLower() == "car make")?.AttributeValue ?? "";
                string carModel = carAttributes.FirstOrDefault(a => a.AttributeName.ToLower() == "car model")?.AttributeValue ?? "";

                string carName = $"{carMake} {carModel}".Trim();

                string newDocxPath = Path.Combine(tempFolder, $"Filled_{Guid.NewGuid()}.docx");
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(newDocxPath);
                string newPdfPath = Path.Combine(tempFolder, $"{fileNameWithoutExtension}.pdf");

              

                // Fill the template
                using (DocX document = DocX.Load(templatePath))
                {
                    document.ReplaceText("​policy_no", policy.PolicyId ?? "");
                    document.ReplaceText("reg_num", policy.Customer ?? "");
                    document.ReplaceText("customer_name", policy.CustomerName ?? "");
                    document.ReplaceText("startdate", booking.PolicyActiveStateDate.ToString("yyyy-MM-dd"));
                    document.ReplaceText("enddate", booking.PolicyActiveEndDate.ToString("yyyy-MM-dd"));
                    document.ReplaceText("duration", carName); // 👈 inject car make + model here
                    document.ReplaceText("cn", "594233");
                    document.ReplaceText("nm", nincomId.ToString());
                    document.ReplaceText("pn", policy.PolicyKey);
                    document.SaveAs(newDocxPath);
                }

                // Convert to PDF
                var libreOfficePath = @"C:\LibreOfficePortable\App\libreoffice\program\soffice.exe";
                var convertProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = libreOfficePath,
                        Arguments = $"--headless --convert-to pdf \"{newDocxPath}\" --outdir \"{tempFolder}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    }
                };

                convertProcess.Start();
                await convertProcess.WaitForExitAsync();

                if (!File.Exists(newPdfPath))
                    throw new Exception($"Failed to generate PDF for {carName}");

                generatedPdfPaths.Add(newPdfPath);

                // Clean up docx after conversion
                if (File.Exists(newDocxPath))
                    File.Delete(newDocxPath);
            }

            // Decision point: single file or zip multiple
            if (generatedPdfPaths.Count == 1)
            {
                byte[] pdfBytes = await File.ReadAllBytesAsync(generatedPdfPaths[0]);

                // Cleanup single pdf file
                File.Delete(generatedPdfPaths[0]);

                return Convert.ToBase64String(pdfBytes);
            }
            else
            {
                // Multiple files → create ZIP
                string zipFilePath = Path.Combine(tempFolder, $"Certificates_{Guid.NewGuid()}.zip");

                using (var zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
                {
                    foreach (var pdfPath in generatedPdfPaths)
                    {
                        zip.CreateEntryFromFile(pdfPath, Path.GetFileName(pdfPath));
                        File.Delete(pdfPath); // Clean after adding
                    }
                }

                byte[] zipBytes = await File.ReadAllBytesAsync(zipFilePath);
                File.Delete(zipFilePath); // Cleanup ZIP too

                return Convert.ToBase64String(zipBytes);
            }
        }
        public async Task<string> GeneratePolicyKeyAsync(int policyId)
        {
            string prefix = "G/";
            string business = "";

            // Get the ProductId from PolicyBookings
            var productId = await _rubyDbContext.PolicyBookings
                .Where(d => d.Id == policyId)
                .Select(d => d.ProductId)
                .FirstOrDefaultAsync();

            if (productId == 0)
                return null; // ProductId not found, handle error if needed

            // Get the first letter of Location from BookingSbus
            var firstLetter = await _rubyDbContext.BookingSbus
                .Where(d => d.BookingId == policyId)
                .Select(d => d.Location)
                .Distinct()
                .FirstOrDefaultAsync();

            if (firstLetter == null)
                return null;

            var firstLetterOfLocation = firstLetter.Length > 0 ? firstLetter[0].ToString().ToUpper() : string.Empty;

            // Get BusinessType and handle accordingly
            var businessType = await _rubyDbContext.BookingBusinessInformation
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            if (businessType != null)
            {
                if (businessType.BusinessType == "Co-Insurance")
                {
                    business = "Co";
                }
                else if (businessType.BusinessType == "Sole Insurance")
                {
                    business = "D";
                }
                else
                {
                    business = "F";
                }
            }
            else
            {
                business = "F"; // Default to "F" if no business type is found
            }

            // Construct the suffix
            string suffix = $"/{firstLetterOfLocation}/{business}";

            // Get the product name and abbreviation
            var product = await _rubyDbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
                return null; // Handle missing product case

            string productAbbreviation = GetAbbreviation(product.Name ?? "XX"); // fallback to "XX" if product name is null

            // Get the year suffix
            string yearSuffix = DateTime.UtcNow.Year.ToString().Substring(2); // e.g., "25"

            // Construct the final Policy Key
            return $"{prefix}{productAbbreviation}/{554283}/{yearSuffix}{suffix}";
        }
        public static string GetAbbreviation(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return "XX";

            var words = productName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 1)
            {
                return new string(productName
                    .Where(char.IsLetter)
                    .Take(2)
                    .Select(char.ToUpper)
                    .ToArray());
            }

            return string.Concat(words.Select(w => char.ToUpper(w[0])));
        }




        #region

        private async Task<BookingBusinessInformationResponse> GetSingleBookingBusinessInformation(int BookingBusinessId)
        {
            // Retrieve the booking business information with related data only if necessary
            var bookingQuery = _rubyDbContext.BookingBusinessInformation.AsQueryable();

            // Only include related data if it's required for the specific case
            bookingQuery = bookingQuery
                .Include(b => b.BusinessBrokeredDetail)
                .Include(b => b.CoInsuranceDetails)
                .Include(b => b.FacultativeInsurer);

            var booking = await bookingQuery
                .FirstOrDefaultAsync(b => b.Id == BookingBusinessId);

            if (booking == null)
            {
                throw new KeyNotFoundException($"BookingBusinessInformation with ID {BookingBusinessId} was not found.");
            }

            // Map the data to the response model
            var bookingResponse = new BookingBusinessInformationResponse
            {
                //Id = booking.Id,
                BookingId = booking.BookingId,
                AdditionalInformation = booking.AdditionalInformation,
                BusinessSource = booking.BusinessSource,
                BusinessType = booking.BusinessType,

                // Handle FacultativeInsurer, it could be null
                FacultativeInsurers = booking.FacultativeInsurer?.InsurerId,

                // Handle BusinessBrokeredDetail, it could be null
                BrokeredDetails = booking.BusinessBrokeredDetail != null
                    ? new BrokeredDetailResponse
                    {
                        BrokerId = booking.BusinessBrokeredDetail.BrokerId
                    }
                    : null,

                // Handle CoInsuranceDetails, it could be null or an empty list
                CoInsuranceDetails = booking.CoInsuranceDetails?.Select(d => new CoInsuranceDetailResponse
                {
                    InsurerId = d.InsurerId,
                    Portion = d.Portion,
                    IsLead = d.IsLead
                }).ToList() ?? new List<CoInsuranceDetailResponse>(),
            };

            return bookingResponse;
        }
        private async Task<BaseResponse<BookingDetailResponse>> GetBookingDetailById(int bookingId)
        {
            
            // Retrieve the BookingDetail by BookingId
            var bookingDetail = await _rubyDbContext.BookingDetail
                .FirstOrDefaultAsync(bd => bd.BookingId == bookingId);

            if (bookingDetail == null)
                return ResponseFactory.CreateError<BookingDetailResponse>("Booking Detail not found.", HttpStatusCode.NotFound);
            

            // Map the BookingDetail entity to a response DTO (you can adjust based on your needs)
            var bookingDetailResponse = new BookingDetailResponse
            {
                Id = bookingDetail.BookingId,
                PaymentType = bookingDetail.PaymentType,
                PolicyActiveStateDate = bookingDetail.PolicyActiveStateDate,
                PolicyActiveEndDate = bookingDetail.PolicyActiveEndDate,
                Duration = bookingDetail.Duration,
                PaymentCycle = bookingDetail.PaymentCycle
            };

            return ResponseFactory.CreateSuccess<BookingDetailResponse>(bookingDetailResponse, "Booking Detail retrieved successfully");
        }
        private async Task<BaseResponse<SbuDetailResponse>> GetSbuDetails(int policyId)
        {
            var response = new BaseResponse<SbuDetailResponse>();

            var bookingSbus = await _rubyDbContext.BookingSbus
                .Include(sbu => sbu.BookingSbuAgents)
                .ThenInclude(agent => agent.BookingSubSbuAgent)
                .Where(x => x.BookingId == policyId)
                .ToListAsync();

            if (bookingSbus == null || !bookingSbus.Any())
                return ResponseFactory.CreateError<SbuDetailResponse>("Policy not found.", HttpStatusCode.NotFound);
           

            var sbuSharingResponse = new SbuDetailResponse
            {
                PolicyId = policyId,
                Comments = bookingSbus.FirstOrDefault()?.Comments ?? string.Empty,
                Location = bookingSbus.FirstOrDefault()?.Location ?? string.Empty,
                Sub = bookingSbus.Select(sbu => new SubResponse
                {
                    Name = sbu.Name ?? string.Empty,
                    SubId = sbu.ExternalId,
                    SharingPercentage = sbu.ProportionPercentage,
                    Participants = sbu.BookingSbuAgents?.Select(agent => new ParticipantResponse
                    {
                        Name = agent.Name ?? string.Empty,
                        ParticipantsId = agent.ExternalId,
                        SharingPercentage = agent.ProportionPercentage,
                        SubAgents = agent.BookingSubSbuAgent?.Select(subAgent => new SubAgentResponse
                        {
                            Name = subAgent.FullName ?? string.Empty,
                            SubAgentId = subAgent.ExternalId,
                            Email = subAgent.Email,
                            PhoneNumber = subAgent.PhoneNumber,
                            SharingPercentage = subAgent.ProportionPercentage
                        }).ToList() ?? new List<SubAgentResponse>()
                    }).ToList() ?? new List<ParticipantResponse>()
                }).ToList()
            };

           
            return ResponseFactory.CreateSuccess<SbuDetailResponse>(sbuSharingResponse, "SBU details retrieved successfully.");

        }
        private async Task<List<Quotation>> GetPredecessorsAsync(Quotation quote)
        {
            var predecessors = new List<Quotation>();
            while (quote.PreviousQuoteId != null)
            {
                quote = await _rubyDbContext.Quotations.FirstOrDefaultAsync(q => q.Id == quote.PreviousQuoteId);
                if (quote != null) predecessors.Add(quote);
            }
            return predecessors;
        }
        private async Task<List<Quotation>> GetSuccessorsAsync(Quotation quote)
        {
            var successors = await _rubyDbContext.Quotations
                .Where(q => q.PreviousQuoteId == quote.Id)
                .ToListAsync();

            var allSuccessors = new List<Quotation>(successors);

            foreach (var successor in successors)
            {
                allSuccessors.AddRange(await GetSuccessorsAsync(successor));
            }

            return allSuccessors;
        }
        private async Task<BaseResponse<List<LocationFieldResponses>>> GetGenericLocation(int productId)
        {
            

            // Fetch all locations related to the product ID
            var locations = await _rubyDbContext.ProductGenericLocations
                .Include(l => l.ProductGenericLocationFields)
                .ThenInclude(f => f.ProductGenericLocationDropdownOptions)
                .Where(l => l.ProductId == productId)
                .ToListAsync();

            if (locations == null || !locations.Any())
                return ResponseFactory.CreateError<List<LocationFieldResponses>>("Locations not found.",HttpStatusCode.NotFound);


            var locationResponses = locations.Select(l => new LocationFieldResponses
            {
                LocationId = l.Id,
                LocationName = l.Name,
                ProductId = l.ProductId,
                RequiredGenericLocation = l.RequiredGenericLocation,
                RequiredSpecificGenericLocation = l.RequiredSpecificGenericLocation,
                Attributes = l.ProductGenericLocationFields.Select(f => new LocationFieldResponse
                {
                    AttributeId = f.Id,
                    AttributeName = f.FieldName,
                    AttributeType = f.FieldType.ToString(),
                    IsRequired = f.IsRequired,
                    DropdownOptions = f.ProductGenericLocationDropdownOptions?.Select(option => option.Value).ToList()
                }).ToList()
            }).ToList();

           
           

            return ResponseFactory.CreateSuccess<List<LocationFieldResponses>>(locationResponses, "Location fields retrieved successfully.");
        }
        
       
        private async Task<BaseResponse<List<GenericLocationAttributeResponse>>> GetLocationAttributes(int bookingId)
        {
            var response = new BaseResponse<List<GenericLocationAttributeResponse>>();

            // Fetch all location attributes for the given bookingId, including related ProductGenericLocation
            var booking = await _rubyDbContext.PolicyBookingGenericLocations
                .Include(d => d.ProductGenericLocation) 
                .Where(d => d.PolicyBookingId == bookingId)
                .ToListAsync();

            if (booking == null || !booking.Any())
                return ResponseFactory.CreateError<List<GenericLocationAttributeResponse>>
                    ("No location attributes found for the specified booking.", HttpStatusCode.NotFound);

            // Group the attributes by EntityId
            var groupedAttributes = booking
                .GroupBy(d => d.EntityId)
                .Select(group => new GenericLocationAttributeResponse
                {
                    EntityId = group.Key,
                    GenericLocationName = booking.FirstOrDefault()?.ProductGenericLocation.Name, // Get GenericLocationName
                    Attributes = group.Select(d => new GenericLocationAttributeResponse.Detail
                    {
                        Id = d.Id,
                        AttributeId = d.GenericLocationId,
                        AttributeName = d.FieldName,
                        AttributeValue = d.FieldValue
                    }).ToList()
                })
                .ToList();

            return ResponseFactory.CreateSuccess<List<GenericLocationAttributeResponse>>(groupedAttributes, "Location attributes retrieved successfully");
        }
       

        private static int GetNextPolicyCode(RubyDbContext RubyContext)
        {

            int seqQuence;
            var connection = RubyContext.Database.GetDbConnection();
            connection.Open();
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = TableSequenceQueries.PolicyBooking_CODE;
                var obj = cmd.ExecuteScalar();
                seqQuence = Convert.ToInt32(obj);
            }
            connection.Close();
            return seqQuence;

        }
        private string UserClaims()
        {
            // Retrieve UserName from claims
            var userNameClaim = _contextAccessor.HttpContext?.User?.FindFirst("UserName")?.Value;

            // If the claim is not present or the user is not authenticated, return a default value
            return !string.IsNullOrEmpty(userNameClaim) ? userNameClaim : "Anonymous";
        }
        private string DisplayBusinessSourceDescription(BusinessSource source)
        {
            string description = source.GetDescription();
            return description;
        }
        private string DisplayBusinessTypeDescription(BusinessTypeValue source)
        {
            string description = source.GetDescription();
            return description;
        }
        private string DisplayPolicyStatusDescription(PolicyBookingStatus source)
        {
            string description = source.GetDescription();
            return description;
        }

        private async Task<BaseResponse<List<EligibilityResponse>>> GetEligibilityResponses(int policyId)
        {
            var response = new BaseResponse<List<EligibilityResponse>>();

            var eligibility = await _rubyDbContext.EligibilityPeriods
                .Where(d => d.BookingId == policyId)
                .ToListAsync();

            // Map the eligibility data 
            response.Data = eligibility.Select(d => new EligibilityResponse
            {
                Id = d.Id,
                EligibilityStartDate = d.EligibilityStartDate,
                EligibilityEndDate = d.EligibilityEndDate,
                Duration = d.DurationInMonths,
                ReceiptReference =d.ReceiptReference,
                Remarks = d.Remarks
            }).ToList();

            // If no data is found, ensure Data is an empty list
            if (response.Data == null || !response.Data.Any())
            {
                response.Data = new List<EligibilityResponse>();
            }

            response.Success = true;
            response.ResponseMessage = "Eligibility responses retrieved successfully.";
            return response;
        }

        private string GetSequence(int totalDays)
        {
            if (totalDays < 30)
                return "Daily";
            else if (totalDays >= 30 && totalDays < 90)
                return "Monthly";
            else if (totalDays >= 90 && totalDays < 120)
                return "Quarterly";
            else if (totalDays >= 120 && totalDays < 270)
                return "Half-Yearly"; 
            else if (totalDays >= 270 && totalDays < 365)
                return "Nine-Monthly";
            else if (totalDays == 365)
                return "Yearly";
            else
                return "Custom";
        }
        private string GenerateReceiptReference()
        {
            var random = new Random();
            var number = random.Next(100000, 999999); 
            return $"FIN{number}"; 
        }
        private void ValidateSharingPercentage(decimal percentage, string entity)
        {
            if (percentage <= 0 || percentage > 100)
            {
                throw new ArgumentException($"Invalid sharing percentage for {entity}: {percentage}");
            }
        }


      

        private void FormatHeader(ExcelRange cell)
        {
            cell.Style.Font.Bold = true;
            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
        }

        private static string ComputeHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes); 
            }
        }

        public Task<string> GenerateCertificatePdfBase64Async(int policyId)
        {
            throw new NotImplementedException();
        }

        public class FinancePostingPayload
        {
            public int EntityId { get; set; }
            public int OfficeId { get; set; }
            public string TransactionSource { get; set; }
            public string TransactionSourceUniqueNumber { get; set; }
            public string CurrencyCode { get; set; }
            public DateTime TransactionDate { get; set; }
            public decimal TotalAmount { get; set; }
            public string Narration { get; set; }
            public List<string> ReceiptNumbers { get; set; }
            public List<FinancePostingDetail> PostingDetails { get; set; }
        }

        public class FinancePostingDetail
        {
            public string BatchReference { get; set; }
            public string PostingType { get; set; }
            public DateTime TransactionDate { get; set; }
            public bool IsCustomerAccountNumber { get; set; }
            public string AccountNumber { get; set; }
            public decimal Amount { get; set; }
            public string Description { get; set; }
            public string DoubleLedgerEntry { get; set; } // "DR" or "CR"
        }


        public class FinanceTransaction
        {
            public string TransactionType { get; set; }
            public string BatchReference { get; set; }
            public string VoucherNumber { get; set; }
        }

        public class FinanceData
        {
            public List<FinanceTransaction> Transactions { get; set; }
            public string TransactionReference { get; set; }
            public string Status { get; set; }
            public DateTime DateCommitted { get; set; }
        }


        #endregion
    }



}





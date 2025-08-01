using FluentValidation;
using Microsoft.EntityFrameworkCore;
using RubyNonlife.Application.Dtos.Requests.Reinsurance;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Booking;
using RubyNonlife.Application.Dtos.Responses.ReinsuranceResponse;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Implementations;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.Reinsurance;
using RubyNonlife.Infrastructure.Contract;
using RubyNonlife.Infrastructure.Persistence;
using System.Net;


namespace RubyNonlife.Infrastructure.Implementations
{
    public class ReinsuranceService : IReinsuranceService
    {
        private readonly RubyDbContext _rubyDbContext;
        private readonly IValidator<ReinsuranceAgreementRequestDto> _validator;

        public ReinsuranceService(RubyDbContext rubyDbContext,
            IValidator<ReinsuranceAgreementRequestDto> validator
           )
        {
            _rubyDbContext = rubyDbContext;
            _validator = validator;

        }

        /// <summary>
        /// Get Transaction Types
        /// </summary>
        public async Task<BaseResponse<List<GenericNameResponse>>> GetTransactionType()
        {
            var businessTypes = await _rubyDbContext.PolicyBusinessTypes.ToListAsync();
            var businessData = businessTypes.Select(c => new GenericNameResponse()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(businessData, "Business Type retrieved Successfully");
        }
        /// <summary>
        /// Create a new reinsurance agreement
        /// </summary>
        public async Task<BaseResponse<GenericNameResponse>> CreateAgreementSetup(ReinsuranceAgreementRequestDto request)
        {
            var validationResult = await _validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return ResponseFactory.CreateError<GenericNameResponse>(string.Join(", ", errors), HttpStatusCode.BadRequest);
            }

            ReinsuranceAgreement reinsurance = new()
            {
                BusinessYear = request.BusinessYear,
                TransactionType = request.TransactionType,
                AgreementCaption = request.AgreementCaption,
                AgreementDescription = request.AgreementDescription,
                ExpiresDate = request.ExpiresDate,
                ExpiryDate = request.ExpiryDate,
                Status = ReinsuranceStatus.UnderDevelopment.GetDescription()
            };

            _rubyDbContext.Add(reinsurance);

            await _rubyDbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Reinsurance Agreement Created", HttpStatusCode.Created);
        }

        /// <summary>
        /// Get all reinsurance agreements
        /// </summary>
        /// 

        public async Task<BaseResponse<List<ReinsuranceAgreementResponseDto>>> GetAllAgreements()
        {
            var agreements = await _rubyDbContext.ReinsuranceAgreements.ToListAsync();

            if (!agreements.Any())
                return ResponseFactory.CreateError<List<ReinsuranceAgreementResponseDto>>("No agreements found", HttpStatusCode.NotFound);

            var response = agreements.Select(a => new ReinsuranceAgreementResponseDto
            {
                Id = a.Id,
                BusinessYear = a.BusinessYear,
                TransactionType = a.TransactionType,
                AgreementCaption = a.AgreementCaption,
                AgreementDescription = a.AgreementDescription,
                ExpiresDate = a.ExpiresDate,
                ExpiryDate = a.ExpiryDate,
                Status = a.Status,
                ApprovalStatus = a.ApprovalStatus,
                ReviewStatus = a.ReviewStatus
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<ReinsuranceAgreementResponseDto>>(response, "Agreements retrieved successfully");
        }


        /// <summary>
        /// Get a single reinsurance agreement by ID
        /// </summary>
        public async Task<BaseResponse<ReinsuranceAgreementResponseDto>> GetAgreementById(int id)
        {
            var agreement = await _rubyDbContext.ReinsuranceAgreements.FindAsync(id);

            if (agreement == null)
                return ResponseFactory.CreateError<ReinsuranceAgreementResponseDto>("Agreement not found", HttpStatusCode.NotFound);

            var response = new ReinsuranceAgreementResponseDto
            {
                Id = agreement.Id,
                BusinessYear = agreement.BusinessYear,
                TransactionType = agreement.TransactionType,
                AgreementCaption = agreement.AgreementCaption,
                AgreementDescription = agreement.AgreementDescription,
                ExpiresDate = agreement.ExpiresDate,
                ExpiryDate = agreement.ExpiryDate,
                Status = agreement.Status,
                ApprovalStatus = agreement.ApprovalStatus,
                ReviewStatus = agreement.ReviewStatus
            };

            return ResponseFactory.GetSuccessResponse<ReinsuranceAgreementResponseDto>(response, "Agreement retrieved successfully");
        }

        /// <summary>
        /// Update an existing reinsurance agreement
        /// </summary>
        public async Task<BaseResponse<GenericNameResponse>> UpdateAgreement(int id, ReinsuranceAgreementRequestDto request)
        {
            var agreement = await _rubyDbContext.ReinsuranceAgreements.FindAsync(id);
            if (agreement == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Agreement not found", HttpStatusCode.NotFound);

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return ResponseFactory.CreateError<GenericNameResponse>(string.Join(", ", errors), HttpStatusCode.BadRequest);
            }

            agreement.BusinessYear = request.BusinessYear;
            agreement.TransactionType = request.TransactionType;
            agreement.AgreementCaption = request.AgreementCaption;
            agreement.AgreementDescription = request.AgreementDescription;
            agreement.ExpiresDate = request.ExpiresDate;
            agreement.ExpiryDate = request.ExpiryDate;

            _rubyDbContext.ReinsuranceAgreements.Update(agreement);
            await _rubyDbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Reinsurance Agreement Updated", HttpStatusCode.OK);
        }

        /// <summary>
        /// Delete a reinsurance agreement
        /// </summary>
        public async Task<BaseResponse<GenericNameResponse>> DeleteAgreement(int id)
        {
            var agreement = await _rubyDbContext.ReinsuranceAgreements.FindAsync(id);
            if (agreement == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Agreement not found", HttpStatusCode.NotFound);

            _rubyDbContext.ReinsuranceAgreements.Remove(agreement);
            await _rubyDbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Reinsurance Agreement Deleted", HttpStatusCode.OK);
        }


        /// <summary>
        /// Get lines of Business
        /// </summary>
        public async Task<BaseResponse<List<GenericNameResponse>>> GetProductClass()
        {
            var productClass = await _rubyDbContext.ProductClasses.ToListAsync();
            var response = productClass.Select(p => new GenericNameResponse()
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(response, "Product Classes retrieved successfully");
        }
        /// <summary>
        /// Treaty and underwriter calculation
        /// </summary>

        public Task<BaseResponse<TreatyCapacityCalculationResponseDto>> CalculateTreaty(decimal retentionAmount, int numberOfLines)
        {
            if (numberOfLines <= 0)
                return Task.FromResult(
                    ResponseFactory.CreateError<TreatyCapacityCalculationResponseDto>("Number of lines must be greater than zero", HttpStatusCode.BadRequest));

            if (retentionAmount == 0)
                return Task.FromResult(ResponseFactory.CreateError<TreatyCapacityCalculationResponseDto>("Retention capacity can be null", HttpStatusCode.BadRequest));

            var treatyCapacity = retentionAmount * numberOfLines;

            var underWriterCapacity = retentionAmount + treatyCapacity;

            TreatyCapacityCalculationResponseDto responseDto = new()
            {
                TreatyCapacity = treatyCapacity,
                UnderWriterCapacity = underWriterCapacity
            };

            return Task.FromResult(ResponseFactory.GetSuccessResponse<TreatyCapacityCalculationResponseDto>(responseDto, "Retention capacity retrieved successfully"));

        }

        /// <summary>
        /// Create Production Layers
        /// </summary>
        /// 
        public async Task<BaseResponse<GenericNameResponse>> CreateProtectionLayer(ProtectionLayerRequestDto request)
        {
            if (string.IsNullOrWhiteSpace(request.ProtectionType))
                return ResponseFactory.CreateError<GenericNameResponse>("Protection type cannot be empty", HttpStatusCode.BadRequest);

            if (string.IsNullOrWhiteSpace(request.ProtectionSubType))
                return ResponseFactory.CreateError<GenericNameResponse>("Protection SubType cannot be empty", HttpStatusCode.BadRequest);

            ReinsuranceProtectionSchedule schedule = new()
            {
                AgreementId = request.AgreementId,
                ProtectionType = request.ProtectionType,
                ProtectionSubType = request.ProtectionSubType,
                TreatyCapacity = request.TreatyCapacity
            };

            if (request.ProtectionSubType == "Excess of loss")
            {
                schedule.Deductible = request.Deductible;
            }
            else
            {
                schedule.RetentionAmount = request.RetentionAmount;
                schedule.NumbersOfLines = request.NumbersOfLines;
                schedule.UnderWriterCapacity = request.UnderWriterCapacity;
            }

            _rubyDbContext.Add(schedule);
            await _rubyDbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Protection Layer Created Successfully", HttpStatusCode.Created);
        }

        /// <summary>
        /// Get all Production Layers
        /// </summary>
        /// 
        public async Task<BaseResponse<List<ProtectionLayerResponseDto>>> GetAllProtectionLayers()
        {
            var protectionLayers = await _rubyDbContext.ReinsuranceProtectionSchedules
                .Select(x => new ProtectionLayerResponseDto
                {
                    Id = x.Id,
                    AgreementId = x.AgreementId,
                    ProtectionType = x.ProtectionType,
                    ProtectionSubType = x.ProtectionSubType,
                    RetentionAmount = x.RetentionAmount,
                    NumbersOfLines = x.NumbersOfLines,
                    TreatyCapacity = x.TreatyCapacity,
                    UnderWriterCapacity = x.UnderWriterCapacity,
                    Deductible = x.Deductible
                })
                .ToListAsync();

            if (!protectionLayers.Any())
                return ResponseFactory.CreateError<List<ProtectionLayerResponseDto>>("No Protection Layers found", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse(protectionLayers, "Protection Layers Retrieved Successfully");
        }
        /// <summary>
        /// get single Production Layers
        /// </summary>
        /// 
        public async Task<BaseResponse<ProtectionLayerResponseDto>> GetProtectionLayerById(int id)
        {
            var protectionLayer = await _rubyDbContext.ReinsuranceProtectionSchedules
                .Where(x => x.Id == id)
                .Select(x => new ProtectionLayerResponseDto
                {
                    Id = x.Id,
                    AgreementId = x.AgreementId,
                    ProtectionType = x.ProtectionType,
                    ProtectionSubType = x.ProtectionSubType,
                    RetentionAmount = x.RetentionAmount,
                    NumbersOfLines = x.NumbersOfLines,
                    TreatyCapacity = x.TreatyCapacity,
                    UnderWriterCapacity = x.UnderWriterCapacity,
                    Deductible = x.Deductible
                })
                .FirstOrDefaultAsync();

            if (protectionLayer == null)
                return ResponseFactory.CreateError<ProtectionLayerResponseDto>("Protection Layer not found", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse(protectionLayer, "Protection Layer Retrieved Successfully");
        }

        /// <summary>
        /// update Production Layers
        /// </summary>
        /// 
        public async Task<BaseResponse<GenericNameResponse>> UpdateProtectionLayer(int id, ProtectionLayerRequestDto request)
        {
            var schedule = await _rubyDbContext.ReinsuranceProtectionSchedules.FindAsync(id);

            if (schedule == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Protection Layer not found", HttpStatusCode.NotFound);

            if (string.IsNullOrWhiteSpace(request.ProtectionType) || string.IsNullOrWhiteSpace(request.ProtectionSubType))
                return ResponseFactory.CreateError<GenericNameResponse>("Protection Type and SubType cannot be empty", HttpStatusCode.BadRequest);

            schedule.ProtectionType = request.ProtectionType;
            schedule.ProtectionSubType = request.ProtectionSubType;
            schedule.TreatyCapacity = request.TreatyCapacity;

            if (request.ProtectionSubType == "Excess of loss")
            {
                schedule.Deductible = request.Deductible;
                schedule.RetentionAmount = decimal.Zero;
                schedule.NumbersOfLines = 0;
                schedule.UnderWriterCapacity = decimal.Zero;
            }
            else
            {
                schedule.RetentionAmount = request.RetentionAmount;
                schedule.NumbersOfLines = request.NumbersOfLines;
                schedule.UnderWriterCapacity = request.UnderWriterCapacity;
                schedule.Deductible = decimal.Zero;
            }

            _rubyDbContext.Update(schedule);
            await _rubyDbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Protection Layer Updated Successfully", HttpStatusCode.OK);
        }

        /// <summary>
        /// delete Production Layers
        /// </summary>
        /// 
        public async Task<BaseResponse<GenericNameResponse>> DeleteProtectionLayer(int id)
        {
            var schedule = await _rubyDbContext.ReinsuranceProtectionSchedules
                .FirstOrDefaultAsync(d => d.Id == id);

            if (schedule == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Protection Layer not found", HttpStatusCode.NotFound);

            _rubyDbContext.Remove(schedule);
            await _rubyDbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Protection Layer Deleted Successfully", HttpStatusCode.OK);
        }


        public async Task<List<SimulationResult>> Simulate(string productName, decimal premium, decimal totalSumAssured)
        {
            // Define these per product (could be from DB)
            decimal retention = 3_500_000m;
            decimal treaty = 2_500_000m;
            decimal covered = retention + treaty;
            decimal excess = totalSumAssured - covered;

            // Avoid invalid operations
            if (totalSumAssured <= 0 || premium <= 0)
                return new List<SimulationResult>();

            // Calculate ratio of each layer to total sum assured
            decimal retentionRatio = retention / totalSumAssured;
            decimal treatyRatio = treaty / totalSumAssured;
            decimal excessRatio = excess / totalSumAssured;

            // Calculate premiums proportionally
            decimal retentionPremium = Math.Round(retentionRatio * premium, 2);
            decimal treatyPremium = Math.Round(treatyRatio * premium, 2);
            decimal excessPremium = Math.Round(excessRatio * premium, 2);

            // Underwriting capacity = sum of all layers
            decimal underwritingCapacity = retention + treaty + excess;

            // Create a list of simulation results
            var results = new List<SimulationResult>
    {
        new SimulationResult
        {
            RetentionCapacity = retention,
            AssociatedPremium = retentionPremium.ToString("N2")
        },
        new SimulationResult
        {
            TreatyCapacity = treaty,
            AssociatedPremium = treatyPremium.ToString("N2")
        },
        new SimulationResult
        {
            ExcessCapacity = excess,
            AssociatedPremium = excessPremium.ToString("N2"),
            
        },
        new SimulationResult
        {
            UnderwritingCapacity = underwritingCapacity
              // This can be a stand-alone field too if needed
        }
    };

            return await Task.FromResult(results);
        }




    }
}






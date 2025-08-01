using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RubyNonlife.Domain.Models.Lookups;




namespace RubyNonlife.Domain.Models.ProductEntities;

public partial class Product : BaseEntity
{
   
    public Product ()
    {
        ProductBaseSubjectTypeCovers = new List<ProductBaseSubjectTypeCover>();
        ProductAdditionalSubjectTypeCovers = new List<ProductAdditionalSubjectTypeCover>();
        ProductCostType = new List<ProductCostType>();
        ProductCostOfInsurances = new List<ProductCostOfInsurance>();
        //ProductDocuments = new List<ProductDocument>();
        ProductAllowedPaymentFrequency= new List<ProductAllowedPaymentFrequency>();
        ProductFeeSetup = new List<ProductFeeSetup>();
        ProductThresholds = new List<ProductThreshold>();
        ProductDeductibles = new List<ProductDeductible>();
        ProductDurationDetails = new List<ProductDurationDetail>();
        ProductCategorySelections = new List<ProductCategorySelection>();




}



    public string Name { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string Alias { get; set; }
    public bool RequiresUnderWriter { get; set; } = false;
    public bool RequireUnderWritingAtBooking { get; set; } = false;
    public bool IsApprovalRequired { get; set; }
    public bool RequiresGenericLocation {  get; set; }
    public decimal? MinimumPremium { get; set; }
    public string? PremiumAccount { get; set; }
    public string? IncomeAccount { get; set; }
    public string? ClaimsAccount { get; set; }
    public int PercentageProgress { get; set; }
    public string SetupStatus { get; set; } = null!;
    public string ApprovalStatus { get; set; }
    public string ProductSetupStages {  get; set; }
    public bool IsCurrentlyRejected { get; set; }=false;

    public bool IsApproved { get; set; } = false;
    public bool CanBookPolicy { get; set; } = false;

 
    public int ProductClassId { get; set; }
   

    public int? VariantId { get; set; }
    
    
    public ICollection<ProductCostType> ProductCostType { get; set; }
    public ICollection<ProductCostOfInsurance> ProductCostOfInsurances { get; set; }
    //public ICollection<ProductDocument> ProductDocuments { get; set; }
    public ICollection<ProductAdditionalSubjectTypeCover> ProductAdditionalSubjectTypeCovers {  get; set; }
    public ICollection<ProductBaseSubjectTypeCover> ProductBaseSubjectTypeCovers { get; set; }
    public ICollection<ProductSubjectType> ProductSubjectTypes { get; set; }
    public ICollection<ProductPenalty> ProductPenalties { get; set; }
    public ICollection<ProductAllowedPaymentFrequency> ProductAllowedPaymentFrequency {  get; set; }
    public ICollection<ProductSubjectCategory> ProductSubjectCategories { get; set; }

    public ICollection<IncomeLedger> IncomeLedger { get; set; }
    public ICollection<ExpenseLedger> ExpenseLedgers { get; set; }
    public ICollection<ReceivableLedger> ReceivableLedgers {  get; set; }
    public ICollection<PayableLedger> PayableLedgers { get; set; }
    public ICollection<ProductFeeSetup> ProductFeeSetup {  get; set; }
    public ICollection<ProductGenericLocation> ProductGenericLocations { get; set; }
    public ICollection<ProductDocumentCategory> ProductDocumentCategory { get; set; } = new List<ProductDocumentCategory>();
    public virtual ICollection<ProductStageAudit> ProductStageAudits { get; set; } = new List<ProductStageAudit>();
    public virtual ICollection<ProductDisapproval> ProductDisapprovals { get; set; } = new List<ProductDisapproval>();
    public virtual ICollection<ProductThreshold> ProductThresholds { get; set; }
    public virtual ICollection<ProductDeductible> ProductDeductibles { get; set; }
    public virtual ICollection<ProductDurationRate> ProductDurationRates { get; set; }
    public virtual ICollection<ProductDurationDetail> ProductDurationDetails {  get; set; }
    public virtual ICollection<ProductCategorySelection> ProductCategorySelections {  get; set; }
}

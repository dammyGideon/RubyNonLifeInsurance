using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models;
using RubyNonlife.Domain.Models.ApprovalWorks;
using RubyNonlife.Domain.Models.CustomerEntities;
using RubyNonlife.Domain.Models.GenericEntities;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.NonLifeProduct;
using RubyNonlife.Domain.Models.PolicyEntities;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Domain.Models.QuoteEntities;
using RubyNonlife.Domain.Models.Reinsurance;
using RubyNonlife.Infrastructure.DatabaseSeed;
using System.Security.Claims;






namespace RubyNonlife.Infrastructure.Persistence;

public partial class RubyDbContext : DbContext
{
    private readonly IHttpContextAccessor _contextAccessor;
    private IConfiguration _configuration;
    public RubyDbContext(DbContextOptions<RubyDbContext> options, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(options)
    {
        _contextAccessor = httpContextAccessor;
        _configuration = configuration;
    }




    public DbSet<AuditLog> Audilogs { get; set; }
    public DbSet<ProductClass> ProductClasses { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }

    public DbSet<CoversRiderLimit> CoversRiderLimits { get; set; }
    public DbSet<PaymentFrequency> PaymentFrequencies { get; set; }
    public DbSet<CalculationsParameter> CalculationsParameters { get; set; }
    public DbSet<CollectionSource> CollectionSources { get; set; }
    public DbSet<PriceRating> PriceRatings { get; set; }
    public DbSet<DatatypeLength> DatatypeLengths { get; set; }
    public DbSet<PolicyDocument> PolicyDocuments { get; set; }
    public DbSet<Datatype> Datatypes { get; set; }
    public DbSet<PolicyDocumentFormat> PolicyDocumentFormats { get; set; }
    public DbSet<CostOfInsuranceFrequency> CostOfInsuranceFrequencies { get; set; }
    public DbSet<PolicyDocumentSize> PolicyDocumentSizes { get; set; }
    public virtual DbSet<FeeLookup> FeeLookups { get; set; }
    public DbSet<CarModel> CarModels { get; set; }
    public DbSet<CarMake> CarMakes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<IncomeLedger> IncomeLedgers { get; set; }
    public DbSet<PayableLedger> PayableLedgers {  get; set; }
    public DbSet<ExpenseLedger> ExpenseLedgers { get; set; }
    public DbSet<ReceivableLedger> ReceivableLedgers { get; set; }
    public DbSet<ProductAdditionalSubjectTypeCover> ProductAdditionalCovers { get; set; }
    public DbSet<ProductBaseSubjectTypeCover> ProductBaseCovers { get; set; }
    public DbSet<ProductCostType> ProductCostTypes { get; set; }
    public DbSet<ProductCostOfInsurance> ProductCostOfInsurances { get; set; }
    public DbSet<ProductPenalty> ProductPenalties { get; set; }
    public DbSet<ProductDocumentCategory> ProductDocumentCategories { get; set; }
    public DbSet<ProductDocument> ProductDocuments { get; set; }
    public DbSet<ProductStaging> ProductStaging { get; set; }
    public DbSet<ProductAllowedPaymentFrequency> ProductAllowedPaymentFrequencies { get; set; }
    public DbSet<ProductSubjectType> ProductSubjectTypes { get; set; }
    public DbSet<ProductSubjectTypeAttribute> ProductSubjectTypeAttributes { get; set; }
    public DbSet<ProductSubjectCategory> ProductSubjectCategories { get; set; }
    public DbSet<ProductSubjectTypeAttributeOption> ProductSubjectTypeAttributeOptions { get; set; }
    public DbSet<ProductGenericLocation> ProductGenericLocations { get; set; }
    public DbSet<ProductGenericLocationField> ProductGenericLocationFields { get; set; }
    public DbSet<ProductGenericLocationDropdownOption> ProductGenericLocationDropdownOptions { get; set; }
    public DbSet<ProductStageAudit> ProductStageAudits { get; set; }
    public DbSet<ProductDisapproval> ProductDisapprovals { get; set; }

    //Quote lookups
    public DbSet<BusinessType> BusinessTypes { get; set; }
    public DbSet<QuotePreferences> QuotePreferences { get; set; }
    public DbSet<QuoteType> QuoteTypes { get; set; }
    public DbSet<PolicyDuration> PolicyDurations { get; set; }
    public DbSet<QuoteChannel> QuoteChannels { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<LocalGovernmentAreaLookup> LocalGovernmentAreaLookups { get; set; }

    public DbSet<Quotation> Quotations { get; set; }
    public DbSet<QuotationAttributeValue> QuotationAttributeValues { get; set; }
    public DbSet<QuotationBaseCover> QuotationBaseCovers { get; set; }
    public DbSet<QuotationAdditionalCover> QuotationAdditionalCovers { get; set; }
    public DbSet<QuoteNegotiation> QuoteNegotiations { get; set; }
    public DbSet<QuotationPriceCalculationAudit> QuotationPriceCalculationAudits {  get; set; }


    //public virtual DbSet<DocumentCategory> DocumentCategories {  get; set; }
    public virtual DbSet<DocumentLookup> DocumentLookups { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
    public virtual DbSet<CustomerDocument> CustomerDocuments { get; set; }
    public virtual DbSet<CustomerLedger> CustomerLedgers { get; set; }
    public virtual DbSet<CustomerLedger2> CustomerLedger2s { get; set; }
    public virtual DbSet<CustomerModification> CustomerModifications { get; set; }
    public virtual DbSet<CustomerModificationDocument> CustomerModificationDocuments { get; set; }
    public virtual DbSet<CustomerOccupation> CustomerOccupations { get; set; }
    public virtual DbSet<CustomerOnboardingApproval> CustomerOnboardingApprovals { get; set; }
    public virtual DbSet<CustomerPhoneBook> CustomerPhoneBooks { get; set; }
    public virtual DbSet<CustomerTitleLookup> CustomerTitleLookups { get; set; }
    public virtual DbSet<CustomersBkp> CustomersBkps { get; set; }
    public virtual DbSet<NatureOfBusinessLookup> NatureOfBusinessLookups { get; set; }

    public virtual DbSet<BankLookup> BankLookups { get; set; }
    public virtual DbSet<BankAccount> BankAccounts { get; set; }
    public virtual DbSet<CustomerBankAccount> CustomerBankAccounts { get; set; }

    public virtual DbSet<ProductSubjectAttributeDropdownMapping> ProductSubjectAttributeDropdownMappings { get; set; }

    public virtual DbSet<PolicyBookingBeneficiary> PolicyBookingBeneficiaries { get; set; }
    public virtual DbSet<PolicyBroker> PolicyBrokers { get; set; }
    public virtual DbSet<PolicyBusinessType> PolicyBusinessTypes { get; set; }
    public virtual DbSet<PolicyBusinessSource> PolicyBusinessSources { get; set; }
    public virtual DbSet<PolicyBookingInsurer> PolicyBookingInsurers { get; set; }
    public virtual DbSet<PolicyAdditionalInformation> PolicyAdditionalInformation { get; set; }
    public virtual DbSet<PolicyBookingPaymentType> PolicyBookingPaymentTypes { get; set; }


    public virtual DbSet<PolicyBooking> PolicyBookings { get; set; }
    public virtual DbSet<BookingBeneficiaryType> BookingBeneficiaryTypes { get; set; }
    public DbSet<PolicyNumberCounter> PolicyNumberCounters { get; set; }

    public virtual DbSet<BookingBusinessInformation> BookingBusinessInformation { get; set; }
    public virtual DbSet<BookingSubjectAttribute> BookingSubjectAttributes { get; set; }
    public virtual DbSet<CoInsuranceDetail> CoInsuranceDetails { get; set; }
    public virtual DbSet<FacultativeInsurer> FacultativeInsurers { get; set; }
    public virtual DbSet<BusinessBrokeredDetail> BusinessBrokeredDetails { get; set; }
    public virtual DbSet<BookingDetail> BookingDetail { get; set; }
    public virtual DbSet<PaymentTypeBookingDetail> PaymentTypeBookingDetails { get; set; }
    public virtual DbSet<ProductFeeSetup> ProductFeeSetups { get; set; }
    public virtual DbSet<CreditNotePayment> CreditNotePayments { get; set; }
    public virtual DbSet<EligibilityPeriod> EligibilityPeriods { get; set; }
    public virtual DbSet<BookingSbu> BookingSbus { get; set; }
    public virtual DbSet<BookingSbuAgent> BookingSbuAgents { get; set; }
    public virtual DbSet<BookingSubSbuAgent> BookingSubSbuAgents { get; set; }
    public virtual DbSet<PolicyBookingGenericLocation> PolicyBookingGenericLocations { get; set; }
    public virtual DbSet<BookingOperationalTransactionsMaster> BookingOperationalTransactionsMasters { get; set; }
    public virtual DbSet<BookingOperationalSettlementDetails> BookingOperationalSettlementDetails { get; set; }
    public virtual DbSet<BookingUploadedDocument> BookingUploadedDocuments { get; set; }

    //public virtual DbSet<BookingBeneficiary> BookingBeneficiaries { get; set; }


    public virtual DbSet<ReinsuranceAgreement> ReinsuranceAgreements { get; set; }
    public virtual DbSet<ReinsuranceAgreementChat> ReinsuranceAgreementChats { get; set; }
    public virtual DbSet<ReinsuranceProtectionSchedule> ReinsuranceProtectionSchedules { get; set; }

    public virtual DbSet<Workflow> Workflows { get; set; }
    public virtual DbSet<WorkFlowApproval> WorkFlowApprovals { get; set; }
    public virtual DbSet<WorkflowApprovingOffice> WorkflowApprovingOffices { get; set; }
    public virtual DbSet<ProductPriceConfiguration> ProductPriceConfigurations { get; set; }
    public virtual DbSet<LineOfBusinessAttributeCategory> LineOfBusinessAttributeCategories { get; set; }
    public virtual DbSet<LineOfBusinessAttributeItem> LineOfBusinessAttributeItems { get; set; }
    public virtual DbSet<LineOfBusinessInsuredObject> LineOfBusinessInsuredObjects { get; set; }
    public virtual DbSet<LineOfBusinessAttributeDropdownMapping> LineOfBusinessAttributeDropdownMappings { get; set; }
    public virtual DbSet<ProductThreshold> ProductThresholds {  get; set; }
    public virtual DbSet<ProductDeductible> ProductDeductibles {  get; set; }
    public virtual DbSet<ProductDurationDetail> ProductDurationDetails {  get; set; }
    public virtual DbSet<ProductCategorySelection> ProductCategorySelections { get; set; }
    public virtual DbSet<ProductApprovingOfficePriceConfiguration> ProductApprovingOfficePriceConfigurations {  get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var auditEntries = OnBeforeSaveChanges();
        var result = await base.SaveChangesAsync(cancellationToken);
        await OnAfterSaveChangesAsync(auditEntries);
        return result;

    }
    private List<AuditEntry> OnBeforeSaveChanges()
    {
        ChangeTracker.DetectChanges();
        var auditEntries = new List<AuditEntry>();

        foreach (var entry in ChangeTracker.Entries())
        {
            if (entry.Entity is AuditLog || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                continue;
            AuditEntry auditEntry = new(entry)
            {
                TableName = entry.Metadata.GetTableName(),
                ActionDate = DateTime.UtcNow,
                UserId = GetCurrentUserId()
            };

            foreach (var property in entry.Properties)
            {
                string propertyName = property.Metadata.Name;
                if (property.IsTemporary)
                {
                    auditEntry.TemporaryProperties.Add(property);
                    continue;
                }

                switch (entry.State)
                {
                    case EntityState.Added:
                        auditEntry.Action = AuditTrailEnum.Insert.ToString();
                        auditEntry.NewValues[propertyName] = property.CurrentValue;
                        break;

                    case EntityState.Deleted:
                        auditEntry.Action = AuditTrailEnum.Delete.ToString();
                        auditEntry.OldValues[propertyName] = property.OriginalValue;
                        break;
                    case EntityState.Modified:
                        auditEntry.Action = AuditTrailEnum.Update.ToString();
                        auditEntry.OldValues[propertyName] = property.OriginalValue;
                        auditEntry.NewValues[propertyName] = property.CurrentValue;
                        break;
                }
            }
            auditEntries.Add(auditEntry);
        }

        foreach (var auditEntry in auditEntries.Where(ae => !ae.HasTemporaryProperties))
        {
            Audilogs.Add(auditEntry.ToAuditLog());
        }
        return auditEntries.Where(ae => ae.HasTemporaryProperties).ToList();
    }
    public string GetCurrentUserId()
    {
        var userId = _contextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
        {
            return null;
        }
        return userId;
    }
    private Task OnAfterSaveChangesAsync(List<AuditEntry> auditEntries)
    {
        if (auditEntries == null || auditEntries.Count == 0)
            return Task.CompletedTask;
        foreach (var auditEntry in auditEntries)
        {
            foreach (var prop in auditEntry.TemporaryProperties)
            {
                if (prop.Metadata.IsPrimaryKey())
                {
                    auditEntry.KeyValues[prop.Metadata.Name] = prop.CurrentValue;
                }
                else
                {
                    auditEntry.NewValues[prop.Metadata.Name] = prop.CurrentValue;
                }
            }
            Audilogs.Add(auditEntry.ToAuditLog());
        }
        return SaveChangesAsync();
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>()
            .HavePrecision(10, 2);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"])
                      .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.ApplyConfiguration(new ProductClassConfiguration());
        modelBuilder.ApplyConfiguration(new ProductVariantConfiguration());
        modelBuilder.ApplyConfiguration(new CoversRiderLimitConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentFrequencyConfiguration());
        modelBuilder.ApplyConfiguration(new CalculationsParameterConfiguration());
        modelBuilder.ApplyConfiguration(new CollectionSourceConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyDocumentsConfiguration());
        modelBuilder.ApplyConfiguration(new DatatypeLengthConfiguration());
        modelBuilder.ApplyConfiguration(new DatatypeConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyDocumentFormatConfiguration());
        modelBuilder.ApplyConfiguration(new PriceRatingConfiguration());
        modelBuilder.ApplyConfiguration(new CostOfInsuranceFrequencyConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyDocumentSizeConfiguration());
        modelBuilder.ApplyConfiguration(new QuotePreferenceConfiguration());
        modelBuilder.ApplyConfiguration(new BusinessTypeConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyDurationConfiguration());
        modelBuilder.ApplyConfiguration(new QuoteTypeConfiguration());
        modelBuilder.ApplyConfiguration(new QuoteChannelConfiguration());
        modelBuilder.ApplyConfiguration(new StatesConfiguration());
        modelBuilder.ApplyConfiguration(new CarMakeConfiguration());
        modelBuilder.ApplyConfiguration(new CarModelConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyBookingBeneficiaryConfiguration());
        modelBuilder.ApplyConfiguration(new BusinessSourceConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyBrokerConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyBookingInsurerConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyAdditionalInformationConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyBusinessTypeConfiguration());
        modelBuilder.ApplyConfiguration(new PolicyBookingPaymentTypeConfiguration());
        modelBuilder.ApplyConfiguration(new LocalGovernmentAreaLookupConfiguration());
        modelBuilder.ApplyConfiguration(new FeeLookupConfiguration());
        //modelBuilder.ApplyConfiguration(new BookingBeneficiaryTypeConfiguration());



    
        modelBuilder.Entity<ProductSubjectTypeAttribute>()
            .OwnsMany(psta => psta.DropdownValues, dv =>
            {
                dv.Property(d => d.Value).HasColumnName("DropdownValue");
            });
        modelBuilder.Entity<LineOfBusinessAttributeItem>()
            .OwnsMany(lobat => lobat.BusinessAttributeItemDropdownValues, dv =>
            {
                dv.Property(d => d.Value).HasColumnName("BusinessAttributeItemDropdownValues");
            });

        modelBuilder.Entity<Quotation>()
          .Property(q => q.Premium)
          .HasColumnType("decimal(18,2)");



        modelBuilder.Entity<Quotation>()
          .Property(q => q.SumInsured)
          .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<PolicyBooking>()
            .Property(p => p.SumInsured)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<ProductSubjectType>()
            .HasOne(pst => pst.Product)
            .WithMany(p => p.ProductSubjectTypes)
            .HasForeignKey(pst => pst.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProductAdditionalSubjectTypeCover>()
            .HasOne(pac => pac.Product)
            .WithMany(p => p.ProductAdditionalSubjectTypeCovers)
            .HasForeignKey(pac => pac.ProductId)
            .OnDelete(DeleteBehavior.Restrict);



        modelBuilder.Entity<ProductBaseSubjectTypeCover>()
            .HasOne(pbc => pbc.Product)
            .WithMany(p => p.ProductBaseSubjectTypeCovers)
            .HasForeignKey(pbc => pbc.ProductId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<ProductSubjectTypeAttribute>()
            .HasOne(pbc => pbc.ProductSubjectCategory)
            .WithMany(psc => psc.ProductSubjectTypeAttributes)
            .HasForeignKey(psc => psc.ProductSubjectCategoryId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<ProductSubjectType>()
            .HasOne(p => p.ProductSubjectCategory)
            .WithMany(p => p.ProductSubjectTypes)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductSubjectTypeAttribute>()
           .HasOne(psta => psta.ProductSubjectType)
           .WithMany(pst => pst.ProductSubjectTypeAttributes)
           .HasForeignKey(psta => psta.ProductSubjectTypeId);

        modelBuilder.Entity<ProductCategorySelection>()
          .HasOne(cs => cs.Product)  
          .WithMany(cs=>cs.ProductCategorySelections)  
          .HasForeignKey(cs => cs.ProductId)  
          .OnDelete(DeleteBehavior.Restrict);



        modelBuilder.Entity<QuotationAttributeValue>()
            .HasOne(pbc => pbc.ProductSubjectTypeAttribute)
            .WithMany(psc => psc.QuoteAttributes)
            .HasForeignKey(psc => psc.AttributeId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<QuotationAttributeValue>()
        .HasOne(qav => qav.Quotation)
        .WithMany(q => q.QuotationAttributeValues)
        .HasForeignKey(qav => qav.QuotationId)
        .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete here to avoid cycle

        modelBuilder.Entity<QuotationPriceCalculationAudit>()
            .HasOne(qav => qav.Quotation)
            .WithMany(qav => qav.QuotationPriceCalculationAudits)
            .HasForeignKey(qav=>qav.QuoteId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configure QuotationAttributeValue -> QuotationAttribute relationship

        modelBuilder.Entity<IncomeLedger>()
            .HasOne(pf => pf.Product)
            .WithMany(pf => pf.IncomeLedger)
            .HasForeignKey(pf => pf.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ExpenseLedger>()
            .HasOne(pf => pf.Product)
            .WithMany(pf => pf.ExpenseLedgers)
            .HasForeignKey(pf => pf.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ReceivableLedger>()
            .HasOne(pf => pf.Product)
            .WithMany(pf => pf.ReceivableLedgers)
            .HasForeignKey(pf => pf.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PayableLedger>()
           .HasOne(pf => pf.Product)
           .WithMany(pf => pf.PayableLedgers)
           .HasForeignKey(pf => pf.ProductId)
           .OnDelete(DeleteBehavior.Restrict);



        modelBuilder.Entity<Quotation>()
           .HasOne(q => q.QuotePreferences)
           .WithMany(qp => qp.Quotation)
           .HasForeignKey(qp => qp.QuotePreferencesId)
           .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<QuotationBaseCover>()
            .HasOne(q => q.ProductBaseSubjectTypeCover)
            .WithMany(q => q.QuotationBaseCover)
            .HasForeignKey(q => q.ProductBaseSubjectTypeCoverId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<QuotationAdditionalCover>()
            .HasOne(q => q.ProductAdditionalSubjectTypeCover)
            .WithMany(q => q.QuotationAdditionalCover)
            .HasForeignKey(q => q.ProductAdditionalSubjectTypeCoverId)
            .OnDelete(DeleteBehavior.Restrict);

      

        modelBuilder.Entity<CarModel>()
             .HasOne(p => p.CarMake)
             .WithMany(p => p.Models)
             .HasForeignKey(p => p.CarMakeId)
             .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<QuoteNegotiation>()
                .HasOne(q => q.Quotation)
                .WithMany(n => n.QuoteNegotiation)
                .HasForeignKey(n => n.QuoteId)
                .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ProductSubjectAttributeDropdownMapping>()
              .HasOne(p => p.ParentAttribute)
              .WithMany(psa => psa.DropdownMappings)
              .HasForeignKey(p => p.ParentAttributeId)
              .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProductSubjectAttributeDropdownMapping>()
             .HasOne(p => p.ChildAttribute)
             .WithMany()
             .HasForeignKey(p => p.ChildAttributeId)
             .OnDelete(DeleteBehavior.NoAction);



        modelBuilder.Entity<ProductGenericLocation>()
             .HasOne(p => p.Product)
             .WithMany(p => p.ProductGenericLocations)
             .HasForeignKey(p => p.ProductId)
             .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProductGenericLocationField>()
              .HasOne(p => p.ProductGenericLocation)
              .WithMany(p => p.ProductGenericLocationFields)
              .HasForeignKey(p => p.GenericLocationId)
              .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<WorkFlowApproval>()
            .HasOne(p => p.Workflows)
            .WithMany(p => p.WorkflowApprovals)
            .HasForeignKey(p => p.WorkFlowId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<WorkflowApprovingOffice>()
            .HasOne(p => p.Workflows)
            .WithMany(p => p.WorkflowApprovingOffices)
            .HasForeignKey(p => p.WorkflowId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<WorkFlowApproval>()
            .HasOne(d=>d.WorkflowApprovingOffice)
            .WithMany(d=>d.WorkFlowApprovals)
            .HasForeignKey(d=>d.WorkflowApprovingOfficeId)
            .OnDelete(DeleteBehavior.NoAction);


        modelBuilder.Entity<WorkflowApprovingOffice>()
           .HasIndex(w => w.WorkflowId)
           .HasDatabaseName("IX_WorkflowId");  // Create an index on WorkflowId

        modelBuilder.Entity<WorkflowApprovingOffice>()
            .HasIndex(w => w.ApprovingOfficeId)
            .HasDatabaseName("IX_ApprovingOfficeId");  // Create an index on ApprovingOfficeId

        modelBuilder.Entity<WorkflowApprovingOffice>()
            .HasIndex(w => w.ApprovalLevel)
            .HasDatabaseName("IX_ApprovalLevel");  // Cre

        modelBuilder.Entity<BankAccount>()
            .HasOne(d => d.BankLookup)
            .WithMany(d => d.BankAccounts)
            .HasForeignKey(d => d.BankId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<DocumentLookup>()
            .HasOne(d => d.DocumentCategory)
            .WithMany(d => d.DocumentLookups)
            .HasForeignKey(d => d.DocumentCategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerDocument>()
            .HasOne(d => d.Customer)
            .WithMany(d => d.CustomerDocuments)
            .HasForeignKey(d => d.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<CustomerDocument>()
            .HasOne(d => d.DocumentType)
            .WithMany(d => d.CustomerDocuments)
            .HasForeignKey(d => d.DocumentTypeId)
            .OnDelete(DeleteBehavior.NoAction);



        modelBuilder.Entity<CustomerBankAccount>()
            .HasOne(d => d.BankAccount)
            .WithMany(d => d.CustomerBankAccounts)
            .HasForeignKey(d => d.BankAccountId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CustomerBankAccount>()
           .HasOne(d => d.Customers)
           .WithMany(d => d.CustomerBankAccounts)
           .HasForeignKey(d => d.CustomerId)
           .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LocalGovernmentAreaLookup>()
            .HasOne(d => d.State)
            .WithMany(d => d.LocalGovernmentAreaLookups)
            .HasForeignKey(d => d.StateId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BookingBusinessInformation>()
            .HasOne(d => d.PolicyBooking)
            .WithMany(d => d.BookingBusinessInformation)
            .HasForeignKey(d => d.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BookingSubjectAttribute>()
            .HasOne(d => d.ProductSubjectTypeAttribute)
            .WithMany(d => d.BookingSubjectAttributes)
            .HasForeignKey(d => d.AttributeId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<BookingSubjectAttribute>()
            .HasOne(d => d.PolicyBooking)
            .WithMany(d => d.BookingSubjectAttributes)
            .HasForeignKey(d => d.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

      
        modelBuilder.Entity<CoInsuranceDetail>()
            .HasOne(d => d.BookingBusinessInformation)
            .WithMany(d => d.CoInsuranceDetails)
            .HasForeignKey(d => d.BusinessInfoId)
            .OnDelete(DeleteBehavior.Cascade);

       
        modelBuilder.Entity<FacultativeInsurer>()
            .HasOne(d => d.BookingBusinessInformation)
            .WithOne(d => d.FacultativeInsurer)
            .HasForeignKey<FacultativeInsurer>(d => d.InsurerId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<BusinessBrokeredDetail>()
            .HasOne(d => d.BookingBusinessInformation)
            .WithOne(d => d.BusinessBrokeredDetail)
            .HasForeignKey<BusinessBrokeredDetail>(d => d.BusinessInfoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BookingDetail>()
            .HasOne(d => d.PolicyBooking)
            .WithMany(d => d.BookingDetails)
            .HasForeignKey(d => d.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PaymentTypeBookingDetail>()
            .HasOne(d => d.BookingDetail)
            .WithMany(d => d.PaymentTypeBookings)
            .HasForeignKey(d => d.BookingDetailId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CreditNotePayment>()
            .HasOne(d => d.BookingDetail)
            .WithMany(d => d.CreditNotePayments)
            .HasForeignKey(d => d.BookingDetailId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProductFeeSetup>()
            .HasOne(d => d.Product)
            .WithMany(d => d.ProductFeeSetup)
            .OnDelete(DeleteBehavior.ClientSetNull);


        modelBuilder.Entity<EligibilityPeriod>()
            .HasOne(d => d.PolicyBooking)
            .WithMany(d => d.EligibilityPeriods)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BookingSbu>()
            .HasOne(d => d.PolicyBooking)
            .WithMany(d => d.BookingSbus)
            .HasForeignKey(d => d.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BookingSbuAgent>()
            .HasOne(d => d.BookingSbu)
            .WithMany(d => d.BookingSbuAgents)
            .HasForeignKey(d => d.BookingSbuId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<BookingSubSbuAgent>()
            .HasOne(d => d.BookingSbuAgent)
            .WithMany(d => d.BookingSubSbuAgent)
            .HasForeignKey(d => d.BookingSbuAgentId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<PolicyBookingGenericLocation>()
            .HasOne(d => d.ProductGenericLocation)
            .WithMany(d => d.PolicyBookingGenericLocation)
            .HasForeignKey(d => d.GenericLocationId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PolicyBookingGenericLocation>()
            .HasOne(d => d.PolicyBooking)
            .WithMany(d => d.PolicyBookingGenericLocation)
            .HasForeignKey(d => d.PolicyBookingId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        modelBuilder.Entity<BookingOperationalTransactionsMaster>()
            .HasOne(d => d.PolicyBooking)
            .WithMany(d => d.BookingOperationalTransactionsMaster)
            .HasForeignKey(d => d.BookingId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<BookingOperationalSettlementDetails>()
            .HasOne(d => d.BookingOperationalTransactionsMaster)
            .WithMany(d => d.BookingOperationalSettlementDetails)
            .HasForeignKey(d => d.TransactionId)
            .OnDelete(DeleteBehavior.NoAction);


        modelBuilder.Entity<BookingUploadedDocument>()
            .HasOne(p => p.ProductDocument)
            .WithMany(d => d.BookingUploadedDocuments)
            .HasForeignKey(p => p.ProductDocumentId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<BookingUploadedDocument>()
            .HasOne(p => p.PolicyBooking)
            .WithOne(b => b.BookingUploadedDocument)
            .HasForeignKey<BookingUploadedDocument>(p => p.PolicyDocumentId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ReinsuranceAgreementChat>()
           .HasOne(ac => ac.ReinsuranceAgreement)
           .WithMany(a => a.ReinsuranceAgreementChat)
           .HasForeignKey(ac => ac.AgreementId)
           .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ReinsuranceProtectionSchedule>()
            .HasOne(ps => ps.ReinsuranceAgreement)
            .WithMany(ps => ps.ReinsuranceProtectionSchedule)
            .HasForeignKey(ps => ps.AgreementId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<Quotation>()
           .HasMany(q => q.QuotationAdditionalCovers)
           .WithOne(qac => qac.Quotation)
           .HasForeignKey(qac => qac.QuotationId)
           .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Quotation>()
            .HasMany(q => q.QuotationBaseCovers)
            .WithOne(qbc => qbc.Quotation)
            .HasForeignKey(qbc => qbc.QuotationId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProductPriceConfiguration>()
            .HasOne(q => q.ProductSubjectTypeAttribute)
            .WithMany(q => q.ProductPriceConfigurations)
            .HasForeignKey(q => q.AttributeId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductPriceConfiguration>()
            .HasOne(q => q.ProductSubjectCategory)
            .WithMany(q => q.ProductPriceConfigurations)
            .HasForeignKey(q => q.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductApprovingOfficePriceConfiguration>()
            .HasOne(q => q.ProductPriceConfiguration)
            .WithMany(q=>q.ApprovingOfficePriceConfigurations)
            .HasForeignKey(q => q.ConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);
        

        modelBuilder.Entity<PolicyBooking>()
        .Property(p => p.DateCreated)
        .HasDefaultValueSql("GETDATE()");

        modelBuilder.Entity<PolicyBooking>()
            .Property(p => p.UpdateDated)
            .IsRequired(false);

        modelBuilder.Entity<LineOfBusinessInsuredObject>()
         .HasOne(l => l.LineOfBusinessAttributeCategory)
         .WithMany(l => l.LineOfBusinessInsuredObjects)
         .HasForeignKey(l => l.CategoryId)
         .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LineOfBusinessAttributeItem>()
         .HasOne(l=>l.LineOfBusinessAttributeCategory)
         .WithMany(l => l.LineOfBusinessAttributeItems)
         .HasForeignKey(l => l.CategoryId)
         .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductThreshold>()
            .HasOne(p => p.Product)
            .WithMany(p => p.ProductThresholds)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductDeductible>()
            .HasOne(p => p.Product)
            .WithMany(p => p.ProductDeductibles)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductDurationRate>()
            .HasOne(p => p.Product)
            .WithMany(p => p.ProductDurationRates)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductDurationDetail>()
            .HasOne(p=>p.Product)
            .WithMany(p => p.ProductDurationDetails)
            .HasForeignKey(p=>p.ProductId)
            .OnDelete(DeleteBehavior.NoAction);


        modelBuilder.Entity<LineOfBusinessAttributeDropdownMapping>()
             .HasOne(p => p.ParentAttribute)
             .WithMany(psa => psa.LineOfBusinessAttributeDropdownMapping)
             .HasForeignKey(p => p.ParentAttributeId)
             .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LineOfBusinessAttributeDropdownMapping>()
             .HasOne(p => p.ChildAttribute)
             .WithMany()
             .HasForeignKey(p => p.ChildAttributeId)
             .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ProductDisapproval>()
            .HasOne(p => p.Product)
            .WithMany(d=>d.ProductDisapprovals)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<ProductStageAudit>()
            .HasOne(p => p.Product)
            .WithMany(d=>d.ProductStageAudits)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.NoAction);


        modelBuilder.Entity<ContactPerson>(entity =>
        {
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.ContactPeople)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CorporateContactPerson_Customers");

            entity.HasOne(d => d.Title)
                .WithMany(p => p.ContactPeople)
                .HasForeignKey(d => d.TitleId)
                .HasConstraintName("FK_ContactPersons_CustomerTitles");



        });
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.AssociationName).HasMaxLength(100);

            entity.Property(e => e.AssociationType).HasMaxLength(50);

            entity.Property(e => e.Bvn)
                .HasMaxLength(50)
                .HasColumnName("BVN");

            entity.Property(e => e.CompanyName).HasMaxLength(100);

            entity.Property(e => e.CreatedBy).HasMaxLength(50);

            entity.Property(e => e.CustomerNumber).HasMaxLength(50);

            entity.Property(e => e.CustomerType).HasMaxLength(50);

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");

            entity.Property(e => e.Email).HasMaxLength(100);

            entity.Property(e => e.EstimatedAnnualRevenue).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.FirstName).HasMaxLength(100);

            entity.Property(e => e.ForeignMailingAddress).HasMaxLength(50);

            entity.Property(e => e.LastName).HasMaxLength(100);

            entity.Property(e => e.MaidenName).HasMaxLength(100);

            entity.Property(e => e.MiddleName).HasMaxLength(100);

            entity.Property(e => e.NinNumber).HasMaxLength(15);

            entity.Property(e => e.PreferredCommunicationMethod).HasMaxLength(50);

            entity.Property(e => e.RcNumber).HasMaxLength(100);

            entity.Property(e => e.ReasonForCreation).HasMaxLength(200);

            entity.Property(e => e.ResidencePermitNumber).HasMaxLength(50);

            entity.Property(e => e.Status).HasMaxLength(50);

            entity.Property(e => e.TaxIdNumber).HasMaxLength(50);

            entity.Property(e => e.UpdatedBy).HasMaxLength(50);

            entity.HasOne(d => d.Gender)
                .WithMany(p => p.Customers)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK_Customers_Genders");

            //entity.HasOne(d => d.MaritalStatus)
            //    .WithMany(p => p.Customers)
            //    .HasForeignKey(d => d.MaritalStatusId)
            //    .HasConstraintName("FK_Customers_MaritalStatuses");

            entity.HasOne(d => d.NatureOfBusiness)
                .WithMany(p => p.Customers)
                .HasForeignKey(d => d.NatureOfBusinessId)
                .HasConstraintName("FK_Customers_NatureOfBusiness");

            //entity.HasOne(d => d.Religion)
            //    .WithMany(p => p.Customers)
            //    .HasForeignKey(d => d.ReligionId)
            //    .HasConstraintName("FK_Customers_Religion");

            entity.HasOne(d => d.StateOfOrigin)
                .WithMany(p => p.Customers)
                .HasForeignKey(d => d.StateOfOriginId)
                .HasConstraintName("FK_Customers_States");

            //entity.HasOne(d => d.Title)
            //    .WithMany(p => p.Customers)
            //    .HasForeignKey(d => d.TitleId)
            //    .HasConstraintName("FK_Customers_CustomerTitles");
        });
        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity.Property(e => e.AddressType)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.BuildingNumber).HasMaxLength(50);

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.Landmark).HasMaxLength(100);

            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

            entity.Property(e => e.Street).HasMaxLength(100);

            entity.Property(e => e.StreetArea).HasMaxLength(100);

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerAddresses_Customers");

            //entity.HasOne(d => d.LocalGovernmentArea)
            //    .WithMany(p => p.CustomerAddresses)
            //    .HasForeignKey(d => d.LocalGovernmentAreaId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_CustomerAddresses_LocalGovernmentAreaLookups");

            //entity.HasOne(d => d.LocalGovernmentAreaNavigation)
            //    .WithMany(p => p.CustomerAddresses)
            //    .HasForeignKey(d => d.LocalGovernmentAreaId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_CustomerAddresses_LocalGovernmentAreas");
        });
        modelBuilder.Entity<CustomerDocument>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(50);

            entity.Property(e => e.DeletedBy).HasMaxLength(50);

            entity.Property(e => e.DocumentName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.ExpiryDate).HasColumnType("date");

            entity.Property(e => e.IssueDate).HasColumnType("date");

            entity.Property(e => e.MimeType).HasMaxLength(50);

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerDocuments)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerDocuments_Customers");

            //entity.HasOne(d => d.DocumentType)
            //    .WithMany(p => p.CustomerDocuments)
            //    .HasForeignKey(d => d.DocumentTypeId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_CustomerDocuments_DocumentTypes");
        });
        modelBuilder.Entity<CustomerLedger>(entity =>
        {
            //entity.HasKey(e => new { e.AccountId, e.CustomerId });

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            //entity.HasOne(d => d.Account)
            //    .WithMany(p => p.CustomerLedgers)
            //    .HasForeignKey(d => d.AccountId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_CustomerLedgers_Accounts");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerLedgers)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerLedgers_Customers");
        });
        modelBuilder.Entity<CustomerLedger2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CustomerLedger2");

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerNumber).HasMaxLength(50);

            entity.Property(e => e.FirstName).HasMaxLength(100);
        });
        modelBuilder.Entity<CustomerModification>(entity =>
        {
            entity.ToTable("CustomerModification");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.CustomerModificationJson).IsRequired();

            entity.HasOne(d => d.CustomerApproval)
                .WithMany(p => p.CustomerModifications)
                .HasForeignKey(d => d.CustomerApprovalId)
                .HasConstraintName("FK_CustomerModification_CustomerOnboardingApprovals");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerModifications)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerModificationApprovals_Customers");
        });
        modelBuilder.Entity<CustomerOccupation>(entity =>
        {
            entity.Property(e => e.AnnualIncomeBand).HasColumnType("money");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.Property(e => e.DeletedBy).HasMaxLength(50);

            entity.Property(e => e.Employer)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.EmploymentType)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.JobTitle)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerOccupations)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerOccupations_Customers");
        });
        modelBuilder.Entity<CustomerOnboardingApproval>(entity =>
        {
            entity.Property(e => e.ApprovalStage).HasMaxLength(50);

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerOnboardingApprovals)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerOnboardingApprovals_Customers");

            //entity.HasOne(d => d.Rm)
            //    .WithMany(p => p.CustomerOnboardingApprovals)
            //    .HasForeignKey(d => d.RmId)
            //    .HasConstraintName("FK_CustomerOnboardingApprovals_RelationshipManagers");
        });
        modelBuilder.Entity<CustomerPhoneBook>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasMaxLength(50);

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DeletedBy).HasMaxLength(50);

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(50);

            //entity.HasOne(d => d.CountryPhoneCode)
            //    .WithMany(p => p.CustomerPhoneBooks)
            //    .HasForeignKey(d => d.CountryPhoneCodeId)
            //    .HasConstraintName("FK_CustomerPhoneBooks_CountryDialingCodes");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerPhoneBooks)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerPhoneBooks_Customers");
        });
        modelBuilder.Entity<CustomerTitleLookup>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });
        modelBuilder.Entity<CustomersBkp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Customers_bkp");

            entity.Property(e => e.AssociationName).HasMaxLength(100);

            entity.Property(e => e.AssociationType).HasMaxLength(50);

            entity.Property(e => e.Bvn)
                .HasMaxLength(50)
                .HasColumnName("BVN");

            entity.Property(e => e.CompanyName).HasMaxLength(100);

            entity.Property(e => e.CreatedBy).HasMaxLength(50);

            entity.Property(e => e.CustomerNumber).HasMaxLength(50);

            entity.Property(e => e.CustomerType).HasMaxLength(50);

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");

            entity.Property(e => e.Email).HasMaxLength(100);

            entity.Property(e => e.EstimatedAnnualRevenue).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.FirstName).HasMaxLength(100);

            entity.Property(e => e.ForeignMailingAddress).HasMaxLength(50);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.LastName).HasMaxLength(100);

            entity.Property(e => e.MaidenName).HasMaxLength(100);

            entity.Property(e => e.MiddleName).HasMaxLength(100);

            entity.Property(e => e.NinNumber).HasMaxLength(15);

            entity.Property(e => e.PreferredCommunicationMethod).HasMaxLength(50);

            entity.Property(e => e.RcNumber).HasMaxLength(100);

            entity.Property(e => e.ReasonForCreation).HasMaxLength(200);

            entity.Property(e => e.ResidencePermitNumber).HasMaxLength(50);

            entity.Property(e => e.Status).HasMaxLength(50);

            entity.Property(e => e.TaxIdNumber).HasMaxLength(50);

            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

     


      


    }


}

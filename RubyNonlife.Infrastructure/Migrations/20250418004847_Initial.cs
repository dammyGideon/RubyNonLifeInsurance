using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RubyNonlife.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audilogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audilogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankLookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankLookups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingBeneficiaryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingBeneficiaryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalculationsParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationsParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarMakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CollectionSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostOfInsuranceFrequencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostOfInsuranceFrequencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoversRiderLimits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoversRiderLimits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLedger2",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AccountName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Customers_bkp",
                columns: table => new
                {
                    CustomerNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaidenName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true),
                    MaritalStatusId = table.Column<short>(type: "smallint", nullable: true),
                    GenderId = table.Column<short>(type: "smallint", nullable: true),
                    OccupationId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    StateOfOriginId = table.Column<int>(type: "int", nullable: true),
                    AverageNumberOfMembersOrEmployees = table.Column<int>(type: "int", nullable: true),
                    AssociationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NinNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BVN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReasonForCreation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HasDualCitizenship = table.Column<bool>(type: "bit", nullable: true),
                    ForeignMailingAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResidencePermitNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreferredCommunicationMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsPoliticallyExposed = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    HasPendingModificationRequest = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfInCorporation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedAnnualRevenue = table.Column<decimal>(type: "decimal(18,2)", precision: 10, scale: 2, nullable: true),
                    NatureOfBusinessId = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RcNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AssociationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RmId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CustomerTitleLookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTitleLookups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatatypeLengths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatatypeLengths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Datatypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datatypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppModule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeeLookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeLookups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenderLookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LineOfBusinessAttributeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinesslineId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineOfBusinessAttributeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatusLookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatusLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NatureOfBusinessLookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureOfBusinessLookups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentFrequencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentFrequencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyAdditionalInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyAdditionalInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBookingBeneficiaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBookingBeneficiaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBookingInsurers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBookingInsurers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBookingPaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBookingPaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBrokers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBrokers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBusinessSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBusinessSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBusinessTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBusinessTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyDocumentFormats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyDocumentFormats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyDocumentSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyDocumentSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyDurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyDurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductStaging",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    ProductStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStaging", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubjectTypeAttributeOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentOptionId = table.Column<int>(type: "int", nullable: true),
                    IsSpecialAttribute = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubjectTypeAttributeOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubjectTypeAttributeOptions_ProductSubjectTypeAttributeOptions_ParentOptionId",
                        column: x => x.ParentOptionId,
                        principalTable: "ProductSubjectTypeAttributeOptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuoteChannels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteChannels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuotePreferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotePreferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuoteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReinsuranceAgreements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessYear = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgreementCaption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgreementDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<bool>(type: "bit", nullable: false),
                    ExpiresDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReinsuranceAgreements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReligionLookup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReligionLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workflows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkflowProcessIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgressPercentage = table.Column<int>(type: "int", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    IsServiceNotified = table.Column<bool>(type: "bit", nullable: false),
                    IsApprovalCompleted = table.Column<bool>(type: "bit", nullable: false),
                    PolicySourceId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccounts_BankLookups_BankId",
                        column: x => x.BankId,
                        principalTable: "BankLookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarMakeId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CarModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarMakes_CarMakeId",
                        column: x => x.CarMakeId,
                        principalTable: "CarMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModels_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DocumentLookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDocUid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptableMimeTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentLookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentLookups_DocumentCategory_DocumentCategoryId",
                        column: x => x.DocumentCategoryId,
                        principalTable: "DocumentCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LineOfBusinessAttributeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsSumAssured = table.Column<bool>(type: "bit", nullable: false),
                    DataType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredAtQuoting = table.Column<bool>(type: "bit", nullable: false),
                    ViolationSpecification = table.Column<bool>(type: "bit", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    IsEditable = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineOfBusinessAttributeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineOfBusinessAttributeItems_LineOfBusinessAttributeCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "LineOfBusinessAttributeCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LineOfBusinessInsuredObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ObjectId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineOfBusinessInsuredObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineOfBusinessInsuredObjects_LineOfBusinessAttributeCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "LineOfBusinessAttributeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiresUnderWriter = table.Column<bool>(type: "bit", nullable: false),
                    RequireUnderWritingAtBooking = table.Column<bool>(type: "bit", nullable: false),
                    IsApprovalRequired = table.Column<bool>(type: "bit", nullable: false),
                    RequiresGenericLocation = table.Column<bool>(type: "bit", nullable: false),
                    MinimumPremium = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    PremiumAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncomeAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimsAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageProgress = table.Column<int>(type: "int", nullable: false),
                    SetupStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSetupStages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCurrentlyRejected = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    CanBookPolicy = table.Column<bool>(type: "bit", nullable: false),
                    ProductClassId = table.Column<int>(type: "int", nullable: false),
                    VariantId = table.Column<int>(type: "int", nullable: true),
                    ProductVariantId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductClasses_ProductClassId",
                        column: x => x.ProductClassId,
                        principalTable: "ProductClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReinsuranceAgreementChats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReinsuranceAgreementChats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReinsuranceAgreementChats_ReinsuranceAgreements_AgreementId",
                        column: x => x.AgreementId,
                        principalTable: "ReinsuranceAgreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReinsuranceProtectionSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementId = table.Column<int>(type: "int", nullable: false),
                    ProtectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtectionSubType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetentionAmount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NumbersOfLines = table.Column<int>(type: "int", nullable: false),
                    TreatyCapacity = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    UnderWriterCapacity = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Deductible = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReinsuranceProtectionSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReinsuranceProtectionSchedules_ReinsuranceAgreements_AgreementId",
                        column: x => x.AgreementId,
                        principalTable: "ReinsuranceAgreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaidenName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    StateOfOriginId = table.Column<int>(type: "int", nullable: true),
                    AverageNumberOfMembersOrEmployees = table.Column<int>(type: "int", nullable: true),
                    AssociationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NinNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BVN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReasonForCreation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HasDualCitizenship = table.Column<bool>(type: "bit", nullable: true),
                    ForeignMailingAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResidencePermitNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreferredCommunicationMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsPoliticallyExposed = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    HasPendingModificationRequest = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfInCorporation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedAnnualRevenue = table.Column<decimal>(type: "decimal(18,2)", precision: 10, scale: 2, nullable: true),
                    NatureOfBusinessId = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RcNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AssociationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RmId = table.Column<int>(type: "int", nullable: true),
                    LeadId = table.Column<int>(type: "int", nullable: true),
                    PayableLedger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncomeLedger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseLeger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerTitles",
                        column: x => x.TitleId,
                        principalTable: "CustomerTitleLookups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customers_Genders",
                        column: x => x.GenderId,
                        principalTable: "GenderLookup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customers_MaritalStatuses",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatusLookup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customers_NatureOfBusiness",
                        column: x => x.NatureOfBusinessId,
                        principalTable: "NatureOfBusinessLookups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customers_Religion",
                        column: x => x.ReligionId,
                        principalTable: "ReligionLookup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customers_States",
                        column: x => x.StateOfOriginId,
                        principalTable: "States",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LocalGovernmentAreaLookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGovernmentAreaLookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalGovernmentAreaLookups_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowApprovingOffices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkflowId = table.Column<int>(type: "int", nullable: false),
                    IsApprovalCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ApprovingOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovingOfficeId = table.Column<int>(type: "int", nullable: false),
                    FunctionId = table.Column<int>(type: "int", nullable: false),
                    ApprovalLevel = table.Column<int>(type: "int", nullable: false),
                    IsOnHold = table.Column<bool>(type: "bit", nullable: false),
                    HeldByUserId = table.Column<int>(type: "int", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowApprovingOffices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowApprovingOffices_Workflows_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "Workflows",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BusinessAttributeItemDropdownValues",
                columns: table => new
                {
                    LineOfBusinessAttributeItemId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessAttributeItemDropdownValues = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessAttributeItemDropdownValues", x => new { x.LineOfBusinessAttributeItemId, x.Id });
                    table.ForeignKey(
                        name: "FK_BusinessAttributeItemDropdownValues_LineOfBusinessAttributeItems_LineOfBusinessAttributeItemId",
                        column: x => x.LineOfBusinessAttributeItemId,
                        principalTable: "LineOfBusinessAttributeItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineOfBusinessAttributeDropdownMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentAttributeId = table.Column<int>(type: "int", nullable: false),
                    ParentValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildAttributeId = table.Column<int>(type: "int", nullable: false),
                    ChildValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineOfBusinessAttributeDropdownMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineOfBusinessAttributeDropdownMappings_LineOfBusinessAttributeItems_ChildAttributeId",
                        column: x => x.ChildAttributeId,
                        principalTable: "LineOfBusinessAttributeItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LineOfBusinessAttributeDropdownMappings_LineOfBusinessAttributeItems_ParentAttributeId",
                        column: x => x.ParentAttributeId,
                        principalTable: "LineOfBusinessAttributeItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseLedgers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncomeLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeLedgers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAllowedPaymentFrequencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PaymentFrequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAllowedPaymentFrequencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAllowedPaymentFrequencies_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategorySelections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsGeneric = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategorySelections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategorySelections_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCostOfInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DebitAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayableAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermValue = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CostBearer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayFormula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CollectionSourceId = table.Column<int>(type: "int", nullable: false),
                    CostTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCostOfInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCostOfInsurances_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCostTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CostTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCostTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCostTypes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDeductibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsuredSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixedAmount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    DeductibleRate = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ApplicationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDeductibles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDeductibles_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDisapprovals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCommented = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDisapprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDisapprovals_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDocumentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDocumentCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDocumentCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDurationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DurationInDays = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AppliedFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDurationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDurationDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDurationRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DurationRate = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDurationRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDurationRate_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductFeeSetups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    FeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageValue = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeeSetups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeeSetups_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductGenericLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredGenericLocation = table.Column<bool>(type: "bit", nullable: false),
                    RequiredSpecificGenericLocation = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGenericLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGenericLocations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPenalties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LowerLimit = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    UpperLimit = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Penalty = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPenalties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPenalties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStageAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStageAudits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStageAudits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSubjectCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubjectCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubjectCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductThresholds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductThresholds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductThresholds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuoteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessTypeId = table.Column<int>(type: "int", nullable: false),
                    QuoteTypeId = table.Column<int>(type: "int", nullable: false),
                    PolicyDurationId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuotePreferencesId = table.Column<int>(type: "int", nullable: false),
                    RiskLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateOfOperation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLA = table.Column<double>(type: "float", nullable: false),
                    SLAUsage = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    LockedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgressPercentage = table.Column<int>(type: "int", nullable: true),
                    SumInsured = table.Column<decimal>(type: "decimal(18,2)", precision: 10, scale: 2, nullable: true),
                    Premium = table.Column<decimal>(type: "decimal(18,2)", precision: 10, scale: 2, nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    AgentId = table.Column<int>(type: "int", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LostRatio = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    RequiresUnderwritingApproval = table.Column<bool>(type: "bit", nullable: false),
                    QuoteStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousQuoteId = table.Column<int>(type: "int", nullable: true),
                    VersionNumber = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    FleetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotations_BusinessTypes_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalTable: "BusinessTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotations_PolicyDurations_PolicyDurationId",
                        column: x => x.PolicyDurationId,
                        principalTable: "PolicyDurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotations_QuotePreferences_QuotePreferencesId",
                        column: x => x.QuotePreferencesId,
                        principalTable: "QuotePreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotations_QuoteTypes_QuoteTypeId",
                        column: x => x.QuoteTypeId,
                        principalTable: "QuoteTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceivableLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivableLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceivableLedgers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactPersons_CustomerTitles",
                        column: x => x.TitleId,
                        principalTable: "CustomerTitleLookups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CorporateContactPerson_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetArea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AddressType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerBankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BankAccountId = table.Column<int>(type: "int", nullable: false),
                    IsCustomerDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerBankAccounts_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBankAccounts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerDocuments_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerDocuments_DocumentLookups_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentLookups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLedgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerLedgers_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerOccupations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Employer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmploymentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AnnualIncomeBand = table.Column<decimal>(type: "money", precision: 10, scale: 2, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOccupations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOccupations_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerOnboardingApprovals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ApprovalStage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Justification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateStatusChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOnboardingApprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOnboardingApprovals_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerPhoneBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPhoneBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerPhoneBooks_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowApprovals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkFlowId = table.Column<int>(type: "int", nullable: false),
                    ApproverUserId = table.Column<int>(type: "int", nullable: false),
                    ApprovalLevel = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    WorkflowApprovingOfficeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowApprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlowApprovals_WorkflowApprovingOffices_WorkflowApprovingOfficeId",
                        column: x => x.WorkflowApprovingOfficeId,
                        principalTable: "WorkflowApprovingOffices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkFlowApprovals_Workflows_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "Workflows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDocumentCategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDocuments_ProductDocumentCategories_ProductDocumentCategoryId",
                        column: x => x.ProductDocumentCategoryId,
                        principalTable: "ProductDocumentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductGenericLocationFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenericLocationId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGenericLocationFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGenericLocationFields_ProductGenericLocations_GenericLocationId",
                        column: x => x.GenericLocationId,
                        principalTable: "ProductGenericLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SubjectTypeId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubjectTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubjectTypes_ProductSubjectCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductSubjectCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSubjectTypes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuotationId = table.Column<int>(type: "int", nullable: false),
                    PolicyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SumInsured = table.Column<decimal>(type: "decimal(18,2)", precision: 10, scale: 2, nullable: true),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeInQue = table.Column<TimeOnly>(type: "time", nullable: true),
                    SlaPerformance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CoverPeriod = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaveState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentationComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyBookings_Quotations_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "Quotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuotationPriceCalculationAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuoteId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    CoverId = table.Column<int>(type: "int", nullable: false),
                    AppliedRate = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AdjustedPremium = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Affects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationPriceCalculationAudits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuotationPriceCalculationAudits_Quotations_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuoteNegotiations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuoteId = table.Column<int>(type: "int", nullable: false),
                    NegotiationRound = table.Column<int>(type: "int", nullable: false),
                    RequestedDiscount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ResponseDiscount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    NegotiationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitiatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NegotiationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteNegotiations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuoteNegotiations_Quotations_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerModification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerApprovalId = table.Column<int>(type: "int", nullable: true),
                    CustomerOldJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerModificationJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerModificationApprovals_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerModification_CustomerOnboardingApprovals",
                        column: x => x.CustomerApprovalId,
                        principalTable: "CustomerOnboardingApprovals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductGenericLocationDropdownOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationFieldId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGenericLocationDropdownOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGenericLocationDropdownOptions_ProductGenericLocationFields_LocationFieldId",
                        column: x => x.LocationFieldId,
                        principalTable: "ProductGenericLocationFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAdditionalCovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LimitType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateTable = table.Column<bool>(type: "bit", nullable: false),
                    RateApplied = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    MaximumAmount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    isFixed = table.Column<bool>(type: "bit", nullable: false),
                    FixedPremium = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    AdditionalCoverId = table.Column<int>(type: "int", nullable: false),
                    DisplayFormula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductSubjectTypeId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdditionalCovers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAdditionalCovers_ProductSubjectTypes_ProductSubjectTypeId",
                        column: x => x.ProductSubjectTypeId,
                        principalTable: "ProductSubjectTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductAdditionalCovers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductBaseCovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LimitType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateTable = table.Column<bool>(type: "bit", nullable: false),
                    RateApplied = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    MaximumAmount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    BaseCoverId = table.Column<int>(type: "int", nullable: false),
                    isFixed = table.Column<bool>(type: "bit", nullable: false),
                    FixedPremium = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    DisplayFormula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductSubjectTypeId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBaseCovers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductBaseCovers_ProductSubjectTypes_ProductSubjectTypeId",
                        column: x => x.ProductSubjectTypeId,
                        principalTable: "ProductSubjectTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductBaseCovers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubjectTypeAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSubjectCategoryId = table.Column<int>(type: "int", nullable: false),
                    FieldType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsSumInsured = table.Column<bool>(type: "bit", nullable: false),
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    DataLength = table.Column<int>(type: "int", nullable: true),
                    SpecifyOperator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComparativeValueType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComparativeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenericStateLgaStreet = table.Column<bool>(type: "bit", nullable: false),
                    RequiresUnderwriting = table.Column<bool>(type: "bit", nullable: false),
                    AvailableAtQuotation = table.Column<bool>(type: "bit", nullable: false),
                    HasParentChildOptions = table.Column<bool>(type: "bit", nullable: false),
                    ProductSubjectTypeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubjectTypeAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubjectTypeAttributes_ProductSubjectCategories_ProductSubjectCategoryId",
                        column: x => x.ProductSubjectCategoryId,
                        principalTable: "ProductSubjectCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSubjectTypeAttributes_ProductSubjectTypes_ProductSubjectTypeId",
                        column: x => x.ProductSubjectTypeId,
                        principalTable: "ProductSubjectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingBusinessInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingBusinessInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingBusinessInformation_PolicyBookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyActiveStateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyActiveEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentCycle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitiatedWithCreditNote = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetail_PolicyBookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingOperationalTransactionsMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Premium = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingOperationalTransactionsMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingOperationalTransactionsMasters_PolicyBookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingSbus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    ProportionPercentage = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ExternalId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSbus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingSbus_PolicyBookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingUploadedDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDocumentId = table.Column<int>(type: "int", nullable: false),
                    PolicyDocumentId = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingUploadedDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingUploadedDocuments_PolicyBookings_PolicyDocumentId",
                        column: x => x.PolicyDocumentId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingUploadedDocuments_ProductDocuments_ProductDocumentId",
                        column: x => x.ProductDocumentId,
                        principalTable: "ProductDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EligibilityPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    EligibilityStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EligibilityEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationInMonths = table.Column<int>(type: "int", nullable: false),
                    ReceiptReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExtended = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherAmount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EligibilityPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EligibilityPeriods_PolicyBookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyBookingGenericLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyBookingId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenericLocationId = table.Column<int>(type: "int", nullable: false),
                    ProductGenericLocationFieldId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyBookingGenericLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyBookingGenericLocations_PolicyBookings_PolicyBookingId",
                        column: x => x.PolicyBookingId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PolicyBookingGenericLocations_ProductGenericLocationFields_ProductGenericLocationFieldId",
                        column: x => x.ProductGenericLocationFieldId,
                        principalTable: "ProductGenericLocationFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PolicyBookingGenericLocations_ProductGenericLocations_GenericLocationId",
                        column: x => x.GenericLocationId,
                        principalTable: "ProductGenericLocations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerModificationDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerModificationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<int>(type: "int", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModificationDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerModificationDocuments_CustomerModification_CustomerModificationId",
                        column: x => x.CustomerModificationId,
                        principalTable: "CustomerModification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerModificationDocuments_DocumentLookups_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentLookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuotationAdditionalCovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductAdditionalSubjectTypeCoverId = table.Column<int>(type: "int", nullable: false),
                    QuotationId = table.Column<int>(type: "int", nullable: false),
                    CoverStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Indicator = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationAdditionalCovers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuotationAdditionalCovers_ProductAdditionalCovers_ProductAdditionalSubjectTypeCoverId",
                        column: x => x.ProductAdditionalSubjectTypeCoverId,
                        principalTable: "ProductAdditionalCovers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuotationAdditionalCovers_Quotations_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "Quotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuotationBaseCovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductBaseSubjectTypeCoverId = table.Column<int>(type: "int", nullable: false),
                    QuotationId = table.Column<int>(type: "int", nullable: false),
                    CoverStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Indicator = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationBaseCovers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuotationBaseCovers_ProductBaseCovers_ProductBaseSubjectTypeCoverId",
                        column: x => x.ProductBaseSubjectTypeCoverId,
                        principalTable: "ProductBaseCovers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuotationBaseCovers_Quotations_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "Quotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingSubjectAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    AttributeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttributeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSubjectAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingSubjectAttributes_PolicyBookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "PolicyBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingSubjectAttributes_ProductSubjectTypeAttributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "ProductSubjectTypeAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DropdownValues",
                columns: table => new
                {
                    ProductSubjectTypeAttributeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DropdownValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropdownValues", x => new { x.ProductSubjectTypeAttributeId, x.Id });
                    table.ForeignKey(
                        name: "FK_DropdownValues_ProductSubjectTypeAttributes_ProductSubjectTypeAttributeId",
                        column: x => x.ProductSubjectTypeAttributeId,
                        principalTable: "ProductSubjectTypeAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPriceConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    AttributeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectPricing = table.Column<bool>(type: "bit", nullable: false),
                    EffectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectRate = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Affects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPriceConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPriceConfigurations_ProductSubjectCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductSubjectCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPriceConfigurations_ProductSubjectTypeAttributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "ProductSubjectTypeAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSubjectAttributeDropdownMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentAttributeId = table.Column<int>(type: "int", nullable: false),
                    ParentValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildAttributeId = table.Column<int>(type: "int", nullable: false),
                    ChildValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubjectAttributeDropdownMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubjectAttributeDropdownMappings_ProductSubjectTypeAttributes_ChildAttributeId",
                        column: x => x.ChildAttributeId,
                        principalTable: "ProductSubjectTypeAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductSubjectAttributeDropdownMappings_ProductSubjectTypeAttributes_ParentAttributeId",
                        column: x => x.ParentAttributeId,
                        principalTable: "ProductSubjectTypeAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuotationAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuotationId = table.Column<int>(type: "int", nullable: false),
                    AttributeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttributeValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuotationAttributeValues_ProductSubjectTypeAttributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "ProductSubjectTypeAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuotationAttributeValues_Quotations_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "Quotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessBrokeredDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessInfoId = table.Column<int>(type: "int", nullable: false),
                    BrokerId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessBrokeredDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessBrokeredDetails_BookingBusinessInformation_BusinessInfoId",
                        column: x => x.BusinessInfoId,
                        principalTable: "BookingBusinessInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoInsuranceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessInfoId = table.Column<int>(type: "int", nullable: false),
                    InsurerId = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    IsLead = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoInsuranceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoInsuranceDetails_BookingBusinessInformation_BusinessInfoId",
                        column: x => x.BusinessInfoId,
                        principalTable: "BookingBusinessInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacultativeInsurers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessInfoId = table.Column<int>(type: "int", nullable: false),
                    InsurerId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultativeInsurers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacultativeInsurers_BookingBusinessInformation_InsurerId",
                        column: x => x.InsurerId,
                        principalTable: "BookingBusinessInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditNotePayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDetailId = table.Column<int>(type: "int", nullable: false),
                    CreditNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditNotePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditNotePayments_BookingDetail_BookingDetailId",
                        column: x => x.BookingDetailId,
                        principalTable: "BookingDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypeBookingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDetailId = table.Column<int>(type: "int", nullable: false),
                    VoucherType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypeBookingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTypeBookingDetails_BookingDetail_BookingDetailId",
                        column: x => x.BookingDetailId,
                        principalTable: "BookingDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingOperationalSettlementDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingOperationalSettlementDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingOperationalSettlementDetails_BookingOperationalTransactionsMasters_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "BookingOperationalTransactionsMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingSbuAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingSbuId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProportionPercentage = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ExternalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSbuAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingSbuAgents_BookingSbus_BookingSbuId",
                        column: x => x.BookingSbuId,
                        principalTable: "BookingSbus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductApprovingOfficePriceConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigurationId = table.Column<int>(type: "int", nullable: false),
                    FunctionId = table.Column<int>(type: "int", nullable: false),
                    MinPricePercentage = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    MaxPricePercentage = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductApprovingOfficePriceConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductApprovingOfficePriceConfigurations_ProductPriceConfigurations_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "ProductPriceConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingSubSbuAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingSbuAgentId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalId = table.Column<int>(type: "int", nullable: false),
                    ProportionPercentage = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSubSbuAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingSubSbuAgents_BookingSbuAgents_BookingSbuAgentId",
                        column: x => x.BookingSbuAgentId,
                        principalTable: "BookingSbuAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BusinessTypes",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6933), "New Business", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6933) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6935), "Renewal", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6935) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6936), "Endorsement", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6936) }
                });

            migrationBuilder.InsertData(
                table: "CalculationsParameters",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5855), "Sum Insured", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5854) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5856), "Rate", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5856) }
                });

            migrationBuilder.InsertData(
                table: "CarMakes",
                columns: new[] { "Id", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7719), "Toyota", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7718) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7721), "Honda", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7720) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7722), "Ford", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7722) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7724), "Chevrolet", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7723) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7725), "Nissan", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7724) },
                    { 6, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7726), "BMW", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7726) },
                    { 7, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7727), "Mercedes-Benz", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7727) },
                    { 8, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7729), "Volkswagen", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7728) },
                    { 9, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7730), "Hyundai", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7729) },
                    { 10, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7731), "Audi", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7730) },
                    { 11, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7732), "Lexus", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7732) },
                    { 12, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7733), "Subaru", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7733) },
                    { 13, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7735), "Mazda", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7734) },
                    { 14, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7736), "Tesla", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7735) },
                    { 15, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7737), "Kia", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7736) }
                });

            migrationBuilder.InsertData(
                table: "CollectionSources",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5957), "Sum Insured", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5957) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5959), "Gross Premium", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5958) }
                });

            migrationBuilder.InsertData(
                table: "CostOfInsuranceFrequencies",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6600), "1 year", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6599) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6602), "2 year", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6601) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6604), "3 year", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6603) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6605), "4 year", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6604) }
                });

            migrationBuilder.InsertData(
                table: "CoversRiderLimits",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5630), "Inclusive", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5629) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5632), "Value", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5631) }
                });

            migrationBuilder.InsertData(
                table: "DatatypeLengths",
                columns: new[] { "Id", "DateCreated", "Length", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6175), 10, "10 Characters", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6174) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6177), 17, "17 Characters", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6176) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6179), 4, "4 Characters", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6178) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6181), 20, "20 Characters", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6180) }
                });

            migrationBuilder.InsertData(
                table: "Datatypes",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6280), "Text", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6280) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6282), "Number", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6281) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6284), "Yes-No", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6283) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6286), "Number", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6284) }
                });

            migrationBuilder.InsertData(
                table: "FeeLookups",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(9413), "Management Fee", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9412) },
                    { 2, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(9415), "Broker Fee", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9414) },
                    { 3, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(9416), "Agent Fee", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9416) }
                });

            migrationBuilder.InsertData(
                table: "PaymentFrequencies",
                columns: new[] { "Id", "DateCreated", "DateTime", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5736), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5737), "One Time", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5736) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5738), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5739), "Adhoc", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5738) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5740), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5741), "Monthly", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5740) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5742), "Bi-Monthly", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5742) },
                    { 6, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5743), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5744), "Quarterly", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5743) },
                    { 7, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5745), "Bi-Annually", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5745) },
                    { 8, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5746), new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5747), "Annually", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5746) }
                });

            migrationBuilder.InsertData(
                table: "PolicyAdditionalInformation",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8690), "Premium on quote represents 100% of transaction whole", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8691) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8692), "Premium on quote represents 100% of AXA transactions only", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8693) }
                });

            migrationBuilder.InsertData(
                table: "PolicyBookingBeneficiaries",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8112), "Company", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8112) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8113), "Named Beneficiary", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8114) }
                });

            migrationBuilder.InsertData(
                table: "PolicyBookingInsurers",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8562), "Axa Mansard Insurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8562) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8564), "Aiico Insurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8564) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8565), "Leadway Assurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8566) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8567), "Mutual Benefits Assurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8567) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8568), "African Alliance Insurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8568) },
                    { 6, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8569), "Royal Exchange Assurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8570) }
                });

            migrationBuilder.InsertData(
                table: "PolicyBookingPaymentTypes",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8959), "Cash Payment", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8959) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8961), "Credit Note", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8961) }
                });

            migrationBuilder.InsertData(
                table: "PolicyBrokers",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8427), "A&G Insurance Brokers Ltd", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8427) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8429), "AIICO Insurance Brokers", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8429) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8431), "Boff & Co. Insurance Brokers Ltd", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8431) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8432), "Bluewaters Insurance Brokers Ltd", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8432) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8433), "Banksome Insurance Brokers Ltd", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8434) }
                });

            migrationBuilder.InsertData(
                table: "PolicyBusinessSources",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8295), "Business is Direct", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8295) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8297), "Business is Brokered", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8297) }
                });

            migrationBuilder.InsertData(
                table: "PolicyBusinessTypes",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8827), "Sole Insurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8828) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8829), "Co-Insurance", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8829) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8830), "Facultative Inward", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(8830) }
                });

            migrationBuilder.InsertData(
                table: "PolicyDocumentFormats",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6394), "Pdf", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6394) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6396), "DOC/DOCX", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6395) }
                });

            migrationBuilder.InsertData(
                table: "PolicyDocumentSizes",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6708), "3MB", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6707) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6709), "5MB", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6709) }
                });

            migrationBuilder.InsertData(
                table: "PolicyDocuments",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6066), false, "Driving Licenses", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6065) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6068), false, "Address Proof", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6067) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6069), false, "Identity Proof", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6069) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6075), false, "Vehicle Registration Certificate", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6070) }
                });

            migrationBuilder.InsertData(
                table: "PolicyDurations",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7038), "less than 3 months", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7034) },
                    { 2, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7049), "3 months", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7048) },
                    { 3, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7051), "6 months", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7050) },
                    { 4, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7052), "9 months", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7052) },
                    { 5, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7054), "12 months", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7053) }
                });

            migrationBuilder.InsertData(
                table: "PriceRatings",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6493), "Flat", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6493) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6495), "Percentage", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6495) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6496), "Custom", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6496) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6497), "Rate Per Mille", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6497) }
                });

            migrationBuilder.InsertData(
                table: "ProductClasses",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "ImageName", "IsDeleted", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5256), null, "dadfb5f1-2cbc-4034-8d91-22239796d162.png", false, "Motor", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5249) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5259), null, "cab7b37f-8d5c-4e58-8814-c2d43fda9eb6.png", false, "Fire", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5258) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5261), null, "ea72cda4-ecb2-4b7c-8a52-137f711342a2.png", false, "Marine", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5260) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5263), null, "98c6a2cc-07a4-4b7f-bf79-678ada50d9c2.png", false, "Equipment", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5262) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5265), null, "85b49b67-11db-4747-b780-02bc1bfb8992.png", false, "Energy & Aviation", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5264) },
                    { 6, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5266), null, "c40b95d6-420c-431b-9d92-f2a2065103e0.png", false, "Engineering", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5266) },
                    { 7, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5268), null, "e5da823a-33ea-4f72-9f8a-19a3e69160a5.png", false, "General Accident", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5267) },
                    { 8, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5270), null, "0c807e5f-6d38-4faa-8c8e-475b65914029.png", false, "Personal Lines", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5269) }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5506), "Comprehensive Retail", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5504) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5515), "Retail", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5507) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5516), "Comprehensive Commercial", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5516) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5518), "Commercial", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5517) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5519), "Individuals & Commercial", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(5519) }
                });

            migrationBuilder.InsertData(
                table: "QuoteChannels",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7413), "Direct Agent", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7412) },
                    { 2, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7415), "Brokered", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7415) }
                });

            migrationBuilder.InsertData(
                table: "QuotePreferences",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6843), "Simulation", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6842) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6844), "Customer Based", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(6844) }
                });

            migrationBuilder.InsertData(
                table: "QuoteTypes",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7313), "Fleet", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7312) },
                    { 2, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7315), "Individual", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7314) }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "DateCreated", "Name", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7535), "Abia", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7536) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7539), "Adamawa", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7539) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7540), "Akwa Ibom", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7541) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7542), "Anambra", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7542) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7543), "Bauchi", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7543) },
                    { 6, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7545), "Bayelsa", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7546) },
                    { 7, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7547), "Benue", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7547) },
                    { 8, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7548), "Borno", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7548) },
                    { 9, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7549), "Cross River", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7549) },
                    { 10, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7551), "Delta", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7552) },
                    { 11, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7553), "Ebonyi", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7553) },
                    { 12, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7554), "Edo", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7554) },
                    { 13, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7559), "Ekiti", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7561) },
                    { 14, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7562), "Enugu", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7562) },
                    { 15, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7563), "Gombe", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7564) },
                    { 16, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7565), "Imo", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7565) },
                    { 17, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7566), "Jigawa", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7566) },
                    { 18, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7568), "Kaduna", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7569) },
                    { 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7569), "Kano", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7570) },
                    { 20, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7571), "Katsina", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7571) },
                    { 21, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7572), "Kebbi", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7572) },
                    { 22, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7573), "Kogi", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7573) },
                    { 23, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7574), "Kwara", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7575) },
                    { 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7576), "Lagos", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7576) },
                    { 25, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7577), "Nasarawa", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7577) },
                    { 26, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7578), "Niger", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7578) },
                    { 27, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7579), "Ogun", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7580) },
                    { 28, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7581), "Ondo", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7581) },
                    { 29, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7582), "Osun", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7582) },
                    { 30, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7583), "Oyo", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7583) },
                    { 31, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7584), "Plateau", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7585) },
                    { 32, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7586), "Rivers", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7586) },
                    { 33, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7587), "Sokoto", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7587) },
                    { 34, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7589), "Taraba", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7590) },
                    { 35, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7591), "Yobe", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7591) },
                    { 36, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7592), "Zamfara", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7592) },
                    { 37, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7593), "Federal Capital Territory", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7594) }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarMakeId", "CarModelId", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7839), "Corolla", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7840) },
                    { 2, 1, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7842), "Camry", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7842) },
                    { 3, 1, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7843), "RAV4", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7844) },
                    { 4, 2, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7845), "Civic", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7845) },
                    { 5, 2, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7846), "Accord", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7846) },
                    { 6, 2, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7847), "CR-V", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7848) },
                    { 7, 3, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7849), "F-150", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7849) },
                    { 8, 3, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7850), "Mustang", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7850) },
                    { 9, 3, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7851), "Escape", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7852) },
                    { 10, 4, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7853), "Silverado", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7853) },
                    { 11, 4, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7854), "Equinox", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7855) },
                    { 12, 4, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7855), "Malibu", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7856) },
                    { 13, 5, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7857), "Altima", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7857) },
                    { 14, 5, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7858), "Sentra", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7859) },
                    { 15, 5, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7860), "Rogue", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7860) },
                    { 16, 6, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7861), "3 Series", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7861) },
                    { 17, 6, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7862), "X5", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7863) },
                    { 18, 6, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7864), "5 Series", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7864) },
                    { 19, 7, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7865), "C-Class", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7865) },
                    { 20, 7, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7866), "E-Class", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7867) },
                    { 21, 7, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7871), "GLC", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7883) },
                    { 22, 8, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7884), "Golf", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7884) },
                    { 23, 8, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7885), "Passat", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7886) },
                    { 24, 8, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7887), "Tiguan", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7887) },
                    { 25, 9, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7888), "Elantra", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7889) },
                    { 26, 9, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7889), "Sonata", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7890) },
                    { 27, 9, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7891), "Tucson", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7891) },
                    { 28, 10, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7892), "A4", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7893) },
                    { 29, 10, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7894), "Q5", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7894) },
                    { 30, 10, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7895), "A6", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7895) },
                    { 31, 11, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7901), "RX", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7903) },
                    { 32, 11, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7904), "ES", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7904) },
                    { 33, 11, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7905), "NX", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7906) },
                    { 34, 12, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7907), "Impreza", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7907) },
                    { 35, 12, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7908), "Forester", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7908) },
                    { 36, 12, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7909), "Outback", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7910) },
                    { 37, 13, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7911), "Mazda3", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7911) },
                    { 38, 13, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7912), "CX-5", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7913) },
                    { 39, 13, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7914), "Mazda6", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7914) },
                    { 40, 14, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7915), "Model 3", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7915) },
                    { 41, 14, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7916), "Model S", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7917) },
                    { 42, 14, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7918), "Model X", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7918) },
                    { 43, 15, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7919), "Optima", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7920) },
                    { 44, 15, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7921), "Sorento", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7921) },
                    { 45, 15, null, new DateTime(2025, 4, 18, 1, 48, 46, 907, DateTimeKind.Local).AddTicks(7922), "Sportage", new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(7922) }
                });

            migrationBuilder.InsertData(
                table: "LocalGovernmentAreaLookups",
                columns: new[] { "Id", "DateCreated", "Name", "StateId", "UpdateDated" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9062), "Aba North", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9062) },
                    { 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9065), "Aba South", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9066) },
                    { 3, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9067), "Arochukwu", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9067) },
                    { 4, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9068), "Bende", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9069) },
                    { 5, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9070), "Ikwuano", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9070) },
                    { 6, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9072), "Isiala Ngwa North", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9072) },
                    { 7, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9073), "Isiala Ngwa South", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9074) },
                    { 8, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9075), "Isuikwuato", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9075) },
                    { 9, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9076), "Obi Ngwa", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9076) },
                    { 10, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9078), "Ohafia", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9079) },
                    { 11, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9080), "Osisioma", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9080) },
                    { 12, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9081), "Ugwunagbo", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9081) },
                    { 13, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9082), "Ukwa East", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9083) },
                    { 14, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9084), "Ukwa West", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9084) },
                    { 15, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9085), "Umuahia North", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9085) },
                    { 16, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9086), "Umuahia South", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9087) },
                    { 17, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9088), "Umu Nneochi", 1, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9088) },
                    { 18, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9090), "Demsa", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9090) },
                    { 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9095), "Fufure", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9097) },
                    { 20, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9098), "Ganye", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9098) },
                    { 21, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9099), "Girei", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9099) },
                    { 22, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9100), "Gombi", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9101) },
                    { 23, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9102), "Guyuk", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9102) },
                    { 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9103), "Hong", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9103) },
                    { 25, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9104), "Jada", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9105) },
                    { 26, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9106), "Lamurde", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9106) },
                    { 27, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9107), "Madagali", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9107) },
                    { 28, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9108), "Maiha", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9108) },
                    { 29, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9109), "Mayo-Belwa", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9110) },
                    { 30, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9111), "Michika", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9111) },
                    { 31, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9112), "Mubi North", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9113) },
                    { 32, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9113), "Mubi South", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9114) },
                    { 33, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9115), "Numan", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9115) },
                    { 34, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9117), "Shelleng", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9117) },
                    { 35, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9118), "Song", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9119) },
                    { 36, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9120), "Toungo", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9120) },
                    { 37, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9121), "Yola North", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9121) },
                    { 38, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9122), "Yola South", 2, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9123) },
                    { 100, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9124), "Agege", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9124) },
                    { 101, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9125), "Ajeromi-Ifelodun", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9125) },
                    { 102, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9126), "Alimosho", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9127) },
                    { 103, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9128), "Amuwo-Odofin", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9128) },
                    { 104, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9129), "Apapa", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9129) },
                    { 105, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9130), "Badagry", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9131) },
                    { 106, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9132), "Epe", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9132) },
                    { 107, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9133), "Eti-Osa", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9133) },
                    { 108, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9134), "Ibeju-Lekki", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9135) },
                    { 109, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9136), "Ifako-Ijaiye", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9136) },
                    { 110, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9137), "Ikeja", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9137) },
                    { 111, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9138), "Ikorodu", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9138) },
                    { 112, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9140), "Kosofe", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9140) },
                    { 113, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9141), "Lagos Island", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9141) },
                    { 114, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9142), "Lagos Mainland", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9142) },
                    { 115, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9143), "Mushin", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9144) },
                    { 116, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9145), "Ojo", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9145) },
                    { 117, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9146), "Oshodi-Isolo", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9146) },
                    { 118, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9147), "Shomolu", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9148) },
                    { 119, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9149), "Surulere", 24, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9149) },
                    { 200, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9150), "Ajingi", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9150) },
                    { 201, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9152), "Albasu", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9152) },
                    { 202, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9153), "Bagwai", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9153) },
                    { 203, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9154), "Bebeji", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9155) },
                    { 204, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9156), "Bichi", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9156) },
                    { 205, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9157), "Bunkure", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9157) },
                    { 206, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9158), "Dala", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9159) },
                    { 207, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9161), "Dambatta", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9161) },
                    { 208, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9162), "Dawakin Kudu", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9163) },
                    { 209, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9164), "Dawakin Tofa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9164) },
                    { 210, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9165), "Doguwa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9165) },
                    { 211, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9166), "Fagge", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9166) },
                    { 212, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9168), "Gabasawa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9168) },
                    { 213, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9169), "Garko", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9169) },
                    { 214, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9170), "Garun Mallam", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9170) },
                    { 215, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9171), "Gaya", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9172) },
                    { 216, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9173), "Gezawa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9173) },
                    { 217, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9174), "Gwale", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9174) },
                    { 218, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9175), "Gwarzo", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9176) },
                    { 219, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9177), "Kabo", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9177) },
                    { 220, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9178), "Kano Municipal", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9178) },
                    { 221, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9179), "Karaye", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9180) },
                    { 222, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9181), "Kibiya", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9181) },
                    { 223, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9182), "Kiru", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9182) },
                    { 224, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9183), "Kumbotso", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9184) },
                    { 225, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9185), "Kunchi", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9185) },
                    { 226, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9186), "Kura", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9186) },
                    { 227, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9187), "Madobi", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9188) },
                    { 228, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9189), "Makoda", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9189) },
                    { 229, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9190), "Minjibir", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9190) },
                    { 230, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9191), "Nasarawa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9191) },
                    { 231, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9192), "Rano", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9193) },
                    { 232, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9194), "Rimin Gado", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9194) },
                    { 233, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9195), "Rogo", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9195) },
                    { 234, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9196), "Shanono", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9197) },
                    { 235, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9197), "Sumaila", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9198) },
                    { 236, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9199), "Takai", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9199) },
                    { 237, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9200), "Tarauni", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9200) },
                    { 238, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9201), "Tofa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9202) },
                    { 239, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9203), "Tsanyawa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9203) },
                    { 240, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9204), "Tudun Wada", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9204) },
                    { 241, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9205), "Ungogo", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9205) },
                    { 242, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9206), "Warawa", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9207) },
                    { 243, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9208), "Wudil", 19, new DateTime(2025, 4, 18, 0, 48, 46, 907, DateTimeKind.Utc).AddTicks(9208) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankId",
                table: "BankAccounts",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingBusinessInformation_BookingId",
                table: "BookingBusinessInformation",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_BookingId",
                table: "BookingDetail",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOperationalSettlementDetails_TransactionId",
                table: "BookingOperationalSettlementDetails",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOperationalTransactionsMasters_BookingId",
                table: "BookingOperationalTransactionsMasters",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSbuAgents_BookingSbuId",
                table: "BookingSbuAgents",
                column: "BookingSbuId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSbus_BookingId",
                table: "BookingSbus",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSubjectAttributes_AttributeId",
                table: "BookingSubjectAttributes",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSubjectAttributes_BookingId",
                table: "BookingSubjectAttributes",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSubSbuAgents_BookingSbuAgentId",
                table: "BookingSubSbuAgents",
                column: "BookingSbuAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingUploadedDocuments_PolicyDocumentId",
                table: "BookingUploadedDocuments",
                column: "PolicyDocumentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingUploadedDocuments_ProductDocumentId",
                table: "BookingUploadedDocuments",
                column: "ProductDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessBrokeredDetails_BusinessInfoId",
                table: "BusinessBrokeredDetails",
                column: "BusinessInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarMakeId",
                table: "CarModels",
                column: "CarMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarModelId",
                table: "CarModels",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CoInsuranceDetails_BusinessInfoId",
                table: "CoInsuranceDetails",
                column: "BusinessInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_CustomerId",
                table: "ContactPerson",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_TitleId",
                table: "ContactPerson",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditNotePayments_BookingDetailId",
                table: "CreditNotePayments",
                column: "BookingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerId",
                table: "CustomerAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBankAccounts_BankAccountId",
                table: "CustomerBankAccounts",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBankAccounts_CustomerId",
                table: "CustomerBankAccounts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDocuments_CustomerId",
                table: "CustomerDocuments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDocuments_DocumentTypeId",
                table: "CustomerDocuments",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLedgers_CustomerId",
                table: "CustomerLedgers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModification_CustomerApprovalId",
                table: "CustomerModification",
                column: "CustomerApprovalId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModification_CustomerId",
                table: "CustomerModification",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModificationDocuments_CustomerModificationId",
                table: "CustomerModificationDocuments",
                column: "CustomerModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModificationDocuments_DocumentTypeId",
                table: "CustomerModificationDocuments",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOccupations_CustomerId",
                table: "CustomerOccupations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOnboardingApprovals_CustomerId",
                table: "CustomerOnboardingApprovals",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhoneBooks_CustomerId",
                table: "CustomerPhoneBooks",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MaritalStatusId",
                table: "Customers",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_NatureOfBusinessId",
                table: "Customers",
                column: "NatureOfBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ReligionId",
                table: "Customers",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StateOfOriginId",
                table: "Customers",
                column: "StateOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TitleId",
                table: "Customers",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLookups_DocumentCategoryId",
                table: "DocumentLookups",
                column: "DocumentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EligibilityPeriods_BookingId",
                table: "EligibilityPeriods",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseLedgers_ProductId",
                table: "ExpenseLedgers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FacultativeInsurers_InsurerId",
                table: "FacultativeInsurers",
                column: "InsurerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeLedgers_ProductId",
                table: "IncomeLedgers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LineOfBusinessAttributeDropdownMappings_ChildAttributeId",
                table: "LineOfBusinessAttributeDropdownMappings",
                column: "ChildAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_LineOfBusinessAttributeDropdownMappings_ParentAttributeId",
                table: "LineOfBusinessAttributeDropdownMappings",
                column: "ParentAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_LineOfBusinessAttributeItems_CategoryId",
                table: "LineOfBusinessAttributeItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LineOfBusinessInsuredObjects_CategoryId",
                table: "LineOfBusinessInsuredObjects",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalGovernmentAreaLookups_StateId",
                table: "LocalGovernmentAreaLookups",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypeBookingDetails_BookingDetailId",
                table: "PaymentTypeBookingDetails",
                column: "BookingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyBookingGenericLocations_GenericLocationId",
                table: "PolicyBookingGenericLocations",
                column: "GenericLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyBookingGenericLocations_PolicyBookingId",
                table: "PolicyBookingGenericLocations",
                column: "PolicyBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyBookingGenericLocations_ProductGenericLocationFieldId",
                table: "PolicyBookingGenericLocations",
                column: "ProductGenericLocationFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyBookings_QuotationId",
                table: "PolicyBookings",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdditionalCovers_ProductId",
                table: "ProductAdditionalCovers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdditionalCovers_ProductSubjectTypeId",
                table: "ProductAdditionalCovers",
                column: "ProductSubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAllowedPaymentFrequencies_ProductId",
                table: "ProductAllowedPaymentFrequencies",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductApprovingOfficePriceConfigurations_ConfigurationId",
                table: "ProductApprovingOfficePriceConfigurations",
                column: "ConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBaseCovers_ProductId",
                table: "ProductBaseCovers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBaseCovers_ProductSubjectTypeId",
                table: "ProductBaseCovers",
                column: "ProductSubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategorySelections_ProductId",
                table: "ProductCategorySelections",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCostOfInsurances_ProductId",
                table: "ProductCostOfInsurances",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCostTypes_ProductId",
                table: "ProductCostTypes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeductibles_ProductId",
                table: "ProductDeductibles",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDisapprovals_ProductId",
                table: "ProductDisapprovals",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDocumentCategories_ProductId",
                table: "ProductDocumentCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDocuments_ProductDocumentCategoryId",
                table: "ProductDocuments",
                column: "ProductDocumentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDurationDetails_ProductId",
                table: "ProductDurationDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDurationRate_ProductId",
                table: "ProductDurationRate",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeeSetups_ProductId",
                table: "ProductFeeSetups",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGenericLocationDropdownOptions_LocationFieldId",
                table: "ProductGenericLocationDropdownOptions",
                column: "LocationFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGenericLocationFields_GenericLocationId",
                table: "ProductGenericLocationFields",
                column: "GenericLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGenericLocations_ProductId",
                table: "ProductGenericLocations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPenalties_ProductId",
                table: "ProductPenalties",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPriceConfigurations_AttributeId",
                table: "ProductPriceConfigurations",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPriceConfigurations_CategoryId",
                table: "ProductPriceConfigurations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductClassId",
                table: "Products",
                column: "ProductClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductVariantId",
                table: "Products",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStageAudits_ProductId",
                table: "ProductStageAudits",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectAttributeDropdownMappings_ChildAttributeId",
                table: "ProductSubjectAttributeDropdownMappings",
                column: "ChildAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectAttributeDropdownMappings_ParentAttributeId",
                table: "ProductSubjectAttributeDropdownMappings",
                column: "ParentAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectCategories_ProductId",
                table: "ProductSubjectCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectTypeAttributeOptions_ParentOptionId",
                table: "ProductSubjectTypeAttributeOptions",
                column: "ParentOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectTypeAttributes_ProductSubjectCategoryId",
                table: "ProductSubjectTypeAttributes",
                column: "ProductSubjectCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectTypeAttributes_ProductSubjectTypeId",
                table: "ProductSubjectTypeAttributes",
                column: "ProductSubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectTypes_CategoryId",
                table: "ProductSubjectTypes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubjectTypes_ProductId",
                table: "ProductSubjectTypes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductThresholds_ProductId",
                table: "ProductThresholds",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationAdditionalCovers_ProductAdditionalSubjectTypeCoverId",
                table: "QuotationAdditionalCovers",
                column: "ProductAdditionalSubjectTypeCoverId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationAdditionalCovers_QuotationId",
                table: "QuotationAdditionalCovers",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationAttributeValues_AttributeId",
                table: "QuotationAttributeValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationAttributeValues_QuotationId",
                table: "QuotationAttributeValues",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationBaseCovers_ProductBaseSubjectTypeCoverId",
                table: "QuotationBaseCovers",
                column: "ProductBaseSubjectTypeCoverId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationBaseCovers_QuotationId",
                table: "QuotationBaseCovers",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationPriceCalculationAudits_QuoteId",
                table: "QuotationPriceCalculationAudits",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_BusinessTypeId",
                table: "Quotations",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_PolicyDurationId",
                table: "Quotations",
                column: "PolicyDurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_ProductId",
                table: "Quotations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_QuotePreferencesId",
                table: "Quotations",
                column: "QuotePreferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_QuoteTypeId",
                table: "Quotations",
                column: "QuoteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuoteNegotiations_QuoteId",
                table: "QuoteNegotiations",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivableLedgers_ProductId",
                table: "ReceivableLedgers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReinsuranceAgreementChats_AgreementId",
                table: "ReinsuranceAgreementChats",
                column: "AgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_ReinsuranceProtectionSchedules_AgreementId",
                table: "ReinsuranceProtectionSchedules",
                column: "AgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowApprovals_WorkflowApprovingOfficeId",
                table: "WorkFlowApprovals",
                column: "WorkflowApprovingOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowApprovals_WorkFlowId",
                table: "WorkFlowApprovals",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalLevel",
                table: "WorkflowApprovingOffices",
                column: "ApprovalLevel");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovingOfficeId",
                table: "WorkflowApprovingOffices",
                column: "ApprovingOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowId",
                table: "WorkflowApprovingOffices",
                column: "WorkflowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audilogs");

            migrationBuilder.DropTable(
                name: "BookingBeneficiaryTypes");

            migrationBuilder.DropTable(
                name: "BookingOperationalSettlementDetails");

            migrationBuilder.DropTable(
                name: "BookingSubjectAttributes");

            migrationBuilder.DropTable(
                name: "BookingSubSbuAgents");

            migrationBuilder.DropTable(
                name: "BookingUploadedDocuments");

            migrationBuilder.DropTable(
                name: "BusinessAttributeItemDropdownValues");

            migrationBuilder.DropTable(
                name: "BusinessBrokeredDetails");

            migrationBuilder.DropTable(
                name: "CalculationsParameters");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CoInsuranceDetails");

            migrationBuilder.DropTable(
                name: "CollectionSources");

            migrationBuilder.DropTable(
                name: "ContactPerson");

            migrationBuilder.DropTable(
                name: "CostOfInsuranceFrequencies");

            migrationBuilder.DropTable(
                name: "CoversRiderLimits");

            migrationBuilder.DropTable(
                name: "CreditNotePayments");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "CustomerBankAccounts");

            migrationBuilder.DropTable(
                name: "CustomerDocuments");

            migrationBuilder.DropTable(
                name: "CustomerLedger2");

            migrationBuilder.DropTable(
                name: "CustomerLedgers");

            migrationBuilder.DropTable(
                name: "CustomerModificationDocuments");

            migrationBuilder.DropTable(
                name: "CustomerOccupations");

            migrationBuilder.DropTable(
                name: "CustomerPhoneBooks");

            migrationBuilder.DropTable(
                name: "Customers_bkp");

            migrationBuilder.DropTable(
                name: "DatatypeLengths");

            migrationBuilder.DropTable(
                name: "Datatypes");

            migrationBuilder.DropTable(
                name: "DropdownValues");

            migrationBuilder.DropTable(
                name: "EligibilityPeriods");

            migrationBuilder.DropTable(
                name: "ExpenseLedgers");

            migrationBuilder.DropTable(
                name: "FacultativeInsurers");

            migrationBuilder.DropTable(
                name: "FeeLookups");

            migrationBuilder.DropTable(
                name: "IncomeLedgers");

            migrationBuilder.DropTable(
                name: "LineOfBusinessAttributeDropdownMappings");

            migrationBuilder.DropTable(
                name: "LineOfBusinessInsuredObjects");

            migrationBuilder.DropTable(
                name: "LocalGovernmentAreaLookups");

            migrationBuilder.DropTable(
                name: "PaymentFrequencies");

            migrationBuilder.DropTable(
                name: "PaymentTypeBookingDetails");

            migrationBuilder.DropTable(
                name: "PolicyAdditionalInformation");

            migrationBuilder.DropTable(
                name: "PolicyBookingBeneficiaries");

            migrationBuilder.DropTable(
                name: "PolicyBookingGenericLocations");

            migrationBuilder.DropTable(
                name: "PolicyBookingInsurers");

            migrationBuilder.DropTable(
                name: "PolicyBookingPaymentTypes");

            migrationBuilder.DropTable(
                name: "PolicyBrokers");

            migrationBuilder.DropTable(
                name: "PolicyBusinessSources");

            migrationBuilder.DropTable(
                name: "PolicyBusinessTypes");

            migrationBuilder.DropTable(
                name: "PolicyDocumentFormats");

            migrationBuilder.DropTable(
                name: "PolicyDocuments");

            migrationBuilder.DropTable(
                name: "PolicyDocumentSizes");

            migrationBuilder.DropTable(
                name: "PriceRatings");

            migrationBuilder.DropTable(
                name: "ProductAllowedPaymentFrequencies");

            migrationBuilder.DropTable(
                name: "ProductApprovingOfficePriceConfigurations");

            migrationBuilder.DropTable(
                name: "ProductCategorySelections");

            migrationBuilder.DropTable(
                name: "ProductCostOfInsurances");

            migrationBuilder.DropTable(
                name: "ProductCostTypes");

            migrationBuilder.DropTable(
                name: "ProductDeductibles");

            migrationBuilder.DropTable(
                name: "ProductDisapprovals");

            migrationBuilder.DropTable(
                name: "ProductDurationDetails");

            migrationBuilder.DropTable(
                name: "ProductDurationRate");

            migrationBuilder.DropTable(
                name: "ProductFeeSetups");

            migrationBuilder.DropTable(
                name: "ProductGenericLocationDropdownOptions");

            migrationBuilder.DropTable(
                name: "ProductPenalties");

            migrationBuilder.DropTable(
                name: "ProductStageAudits");

            migrationBuilder.DropTable(
                name: "ProductStaging");

            migrationBuilder.DropTable(
                name: "ProductSubjectAttributeDropdownMappings");

            migrationBuilder.DropTable(
                name: "ProductSubjectTypeAttributeOptions");

            migrationBuilder.DropTable(
                name: "ProductThresholds");

            migrationBuilder.DropTable(
                name: "QuotationAdditionalCovers");

            migrationBuilder.DropTable(
                name: "QuotationAttributeValues");

            migrationBuilder.DropTable(
                name: "QuotationBaseCovers");

            migrationBuilder.DropTable(
                name: "QuotationPriceCalculationAudits");

            migrationBuilder.DropTable(
                name: "QuoteChannels");

            migrationBuilder.DropTable(
                name: "QuoteNegotiations");

            migrationBuilder.DropTable(
                name: "ReceivableLedgers");

            migrationBuilder.DropTable(
                name: "ReinsuranceAgreementChats");

            migrationBuilder.DropTable(
                name: "ReinsuranceProtectionSchedules");

            migrationBuilder.DropTable(
                name: "WorkFlowApprovals");

            migrationBuilder.DropTable(
                name: "BookingOperationalTransactionsMasters");

            migrationBuilder.DropTable(
                name: "BookingSbuAgents");

            migrationBuilder.DropTable(
                name: "ProductDocuments");

            migrationBuilder.DropTable(
                name: "CarMakes");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "CustomerModification");

            migrationBuilder.DropTable(
                name: "DocumentLookups");

            migrationBuilder.DropTable(
                name: "BookingBusinessInformation");

            migrationBuilder.DropTable(
                name: "LineOfBusinessAttributeItems");

            migrationBuilder.DropTable(
                name: "BookingDetail");

            migrationBuilder.DropTable(
                name: "ProductPriceConfigurations");

            migrationBuilder.DropTable(
                name: "ProductGenericLocationFields");

            migrationBuilder.DropTable(
                name: "ProductAdditionalCovers");

            migrationBuilder.DropTable(
                name: "ProductBaseCovers");

            migrationBuilder.DropTable(
                name: "ReinsuranceAgreements");

            migrationBuilder.DropTable(
                name: "WorkflowApprovingOffices");

            migrationBuilder.DropTable(
                name: "BookingSbus");

            migrationBuilder.DropTable(
                name: "ProductDocumentCategories");

            migrationBuilder.DropTable(
                name: "BankLookups");

            migrationBuilder.DropTable(
                name: "CustomerOnboardingApprovals");

            migrationBuilder.DropTable(
                name: "DocumentCategory");

            migrationBuilder.DropTable(
                name: "LineOfBusinessAttributeCategories");

            migrationBuilder.DropTable(
                name: "ProductSubjectTypeAttributes");

            migrationBuilder.DropTable(
                name: "ProductGenericLocations");

            migrationBuilder.DropTable(
                name: "Workflows");

            migrationBuilder.DropTable(
                name: "PolicyBookings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductSubjectTypes");

            migrationBuilder.DropTable(
                name: "Quotations");

            migrationBuilder.DropTable(
                name: "CustomerTitleLookups");

            migrationBuilder.DropTable(
                name: "GenderLookup");

            migrationBuilder.DropTable(
                name: "MaritalStatusLookup");

            migrationBuilder.DropTable(
                name: "NatureOfBusinessLookups");

            migrationBuilder.DropTable(
                name: "ReligionLookup");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "ProductSubjectCategories");

            migrationBuilder.DropTable(
                name: "BusinessTypes");

            migrationBuilder.DropTable(
                name: "PolicyDurations");

            migrationBuilder.DropTable(
                name: "QuotePreferences");

            migrationBuilder.DropTable(
                name: "QuoteTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductClasses");

            migrationBuilder.DropTable(
                name: "ProductVariants");
        }
    }
}

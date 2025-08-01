using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.UtitlityModel
{

    public class ConfigModels
        {
            public string AllowedHosts { get; set; }
            public Transactions Transactions { get; set; }
            public string SwaggerUi { get; set; }
            public int LifeLossRatioThreshold { get; set; }
            public string NicconBaseUrl { get; set; }
            public string NicconToken { get; set; }
            public string NicconActiveStatus { get; set; }
            public string IDMBaseUrl { get; set; }
            public int AxaInsuranceCompanyId { get; set; }
            public int FinanceCurrencyId { get; set; }
            public int ControlAccountId { get; set; }

            public string RubyFinanceBaseUrl { get; set; }
            public string RubyAdminUrl { get; set; }
            public string ProjectionSheetUrl { get; set; }
            public string BonusLifeProductCode { get; set; }
            public string EPPProductCode { get; set; }
            public string MLIPProductCode { get; set; }
            public string ExcelFilePath { get; set; }
            public string NameLookUpBaseUrl { get; set; }
            public string PolicyNumberGenerator { get; set; }
            public int BrokerCommissionCostTypeId { get; set; }
            public int AgentCommissionCostTypeId { get; set; }
            public string PolicyBookingTransactionSourceId { get; set; }
            public string PolicyBookingEntityId { get; set; }
            public int DefaultPolicyTenure { get; set; }
            public int DeathRiderId { get; set; }
            public int UnderWriterTeamProductApprovalProcess { get; set; }
            public int FinConTeamProductApprovalProcess { get; set; }
            public int ProductTeamProductApprovalProcess { get; set; }
            public int IndividualProductTypeId { get; set; }
            public int GroupLifeProductTypeId { get; set; }
            public int OrdinaryIndividualProductSubTypeId { get; set; }
            public int ProductWorkflowModuleId {  get; set; }
            public int PolicyWorkflowModuleId { get; set; }
            public int ProductTeamApprovingOffice { get; set; }
            public int UnderwritingTeamApprovingOffice { get; set; }
   
            public int BrokerTypeId { get; set; }
            public int InsuranceTypeId { get; set; }
            public int FirstAprovingOffice { get; set; }
            public int SecondApprovingOffice { get; set; }
            public int MaximumEntryAgeMaxThreshold { get; set; }
            public int MaximumEntryAgeMinThreshold { get; set; }
            public int MinimumEntryAgeMaxThreshold { get; set; }
            public int MinimumEntryAgeMinThreshold { get; set; }
            public int IndividualCostOptionsId { get; set; }
            public int ManualCostOptionsId { get; set; }
            public int AverageAgeCostOptionsId { get; set; }
            public int MinimumCostOptionsId { get; set; }
            public bool DisableAuthentication { get; set; }
            public bool IsTestEnv { get; set; }
            public List<short> CustomerAccountCreationEntities { get; set; }
            public string RubyAuthenticationToken { get; set; }
            public Processmakerconfiguration ProcessMakerConfiguration { get; set; }
            public Notificationconfiguration NotificationConfiguration { get; set; }
            public Fileserverconfiguration FileServerConfiguration { get; set; }
            public Apicollection APICollection { get; set; }
         
            public Logging Logging { get; set; }
            public Tokenparams TokenParams { get; set; }
            public Policymedicals PolicyMedicals { get; set; }
            public Policybookingquestionaire PolicyBookingQuestionaire { get; set; }
            public Policybookingdocument PolicyBookingDocument { get; set; }
            public Nonlifepolicybookingdocument NonLifePolicyBookingDocument { get; set; }
            public Policydocumentapprovedformats PolicyDocumentApprovedFormats { get; set; }
            public string EmailSender { get; set; }
            public string AdminPassword { get; set; }
            public string AdminUsername { get; set; }
            public int LifeLineOfBusinessId { get; set; }
            public Customerfinance CustomerFinance { get; set; }
            public int UnderWriterTeamId { get; set; }
            public WorkflowTemplate WorkflowEmailTemplate { get; set; }
            public PolicyFinancials PolicyFinancials { get; set; }
            public Reinsurance Reinsurance { get; set; }
            public List<APIUrl> ApiUrls { get; set; }
            public string MockLarms { get; set; }

        }



        public class PolicyFinancials
        {
            public string FeeDescription { get; set; }
            public string IFeeVoucherType { get; set; }
            public string IncomeRecognitionDescription { get; set; }
            public string IncomeRecognitionVoucherType { get; set; }
        }

        public class WorkflowTemplate
        {
            public string LoggedEmail { get; set; }
            public string LoggedEmailSubject { get; set; }
            public string ApprovedEmail { get; set; }
            public string ApprovedEmailSubject { get; set; }
            public string DeclinedEmail { get; set; }
            public string DeclinedEmailSubject { get; set; }
            public string ReminderEmail { get; set; }
            public string ReminderEmailSubject { get; set; }
            public string FinalApprovalEmail { get; set; }
            public string FinalApprovalEmailSubject { get; set; }
        }
        public class Connectionstrings
        {
            public string DBSequenceQuery { get; set; }
            public string CustomerNumberSequenceQuery { get; set; }
            public string RubyConnection { get; set; }
        }

        public class Transactions
        {
            public string Credited { get; set; }
            public string Debited { get; set; }
        }

        public class Processmakerconfiguration
        {
            public string ProcessMakerUri { get; set; }
            public string Environment { get; set; }
            public Customercase CustomerCase { get; set; }
            public Productcase ProductCase { get; set; }
            public Customermodificationcase CustomerModificationCase { get; set; }
        }

        public class Customercase
        {
            public string ProcessUID { get; set; }
            public string TaskUID { get; set; }
            public string UserUID { get; set; }
            public string PoliticallyExposedPerson { get; set; }
            public string NonPoliticallyExposedPerson { get; set; }
            public string IdCardDocId { get; set; }
        }

        public class Productcase
        {
            public string ProcessUID { get; set; }
            public string TaskUID { get; set; }
            public string UserUID { get; set; }
            public Documentuids DocumentUIDs { get; set; }
        }

        public class Documentuids
        {
            public string ProductDocument { get; set; }
            public string TariffDocument { get; set; }
        }

        public class Customermodificationcase
        {
            public string ProcessUID { get; set; }
            public string TaskUID { get; set; }
            public string UserUID { get; set; }
        }

        public class Notificationconfiguration
        {
            public Emailsettings EmailSettings { get; set; }
            public Smssettings SmsSettings { get; set; }
        }

        public class Emailsettings
        {
            public string FromMail { get; set; }
            public string DisplayName { get; set; }
            public string SmtpUser { get; set; }
            public string SmtpPassword { get; set; }
            public string SmtpHost { get; set; }
            public int SmtpPort { get; set; }
            public bool SmtpEnableSSL { get; set; }
        }

        public class Smssettings
        {
        }

        public class Fileserverconfiguration
        {
            public string BaseUrl { get; set; }
            public string RootDirectory { get; set; }
        }

        public class Apicollection
        {
            public string BaseUrl { get; set; }
            public string TokenKey { get; set; }
            public string TokenSecret { get; set; }
        }



    public class Logging
        {
            public Loglevel LogLevel { get; set; }
        }

        public class Loglevel
        {
            public string Default { get; set; }
            public string Microsoft { get; set; }
            public string MicrosoftHostingLifetime { get; set; }
        }

        public class Tokenparams
        {
            public string grant_type { get; set; }
            public string scope { get; set; }
            public string client_id { get; set; }
            public string client_secret { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string usr_uid { get; set; }
        }

        public class Policymedicals
        {
            public string ClientMedicalEmailSubject { get; set; }
            public string HospitalMedicalEmailSubject { get; set; }
            public string MedicalsUrlLink { get; set; }
        }

        public class Policybookingquestionaire
        {
            public string NonMedical { get; set; }
            public string Hypertension { get; set; }
            public string PMarc { get; set; }
            public string Diabetic { get; set; }
        }

        public class Policybookingdocument
        {
            public string TemporalPolicyPath { get; set; }
            public string PolicyDocument { get; set; }
            public string PolicyCertificate { get; set; }
            public string ProvisionalPolicyCertificate { get; set; }
            public string PolicyEndorsementDocument { get; set; }
            public string PolicyEndorsementCertificate { get; set; }
            public string PolicyDocumentFolder { get; set; }
        }

        public class Nonlifepolicybookingdocument
        {
            public string TemporalPolicyPath { get; set; }
            public string PolicyDocument { get; set; }
            public string PolicyCertificate { get; set; }
            public string PolicyEndorsementDocument { get; set; }
            public string PolicyEndorsementCertificate { get; set; }
        }

        public class Policydocumentapprovedformats
        {
            public string[] Formats { get; set; }
        }

        public class Customerfinance
        {
            public string DefaultCurrencyIds { get; set; }
            public string AccountClass { get; set; }
            public string ScCode { get; set; }
            public string AccountCurrency { get; set; }
            public string IndividualAccountType { get; set; }
            public string SmeAccountType { get; set; }
            public string CorporateAccountType { get; set; }
            public string AssociationAccountType { get; set; }
        }

        public class Reinsurance
        {
            public string RetentionAccount { get; set; }
            public string TreatyCommissionAccount { get; set; }
        }


        public class APIUrl
        {
            public ApiUrlEnum Name { get; set; }
            public string BaseUrl { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string TokenCacheName { get; set; }
        }


    public enum ApiUrlEnum
    {
        [Description("Admin")]
        Admin = 1,
        [Description("Finance")]
        Finance = 2,
    }


}

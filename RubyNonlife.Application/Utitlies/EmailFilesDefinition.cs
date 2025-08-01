using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Utitlies
{
    public class EmailFilesDefinition
    {
        #region Root Directories
        public const string ROOT_TEMPLATE_DIRECTORY = "Templates";
        #endregion

        #region Template Files
      
        public const string PRODUCT_SETUP_TEMPLATE = "ProductSetupTemplate.html";
        public const string PRODUCT_SETUP_REJECTION_TEMPLATE = "ProductSetupDisapprovalTemplate.html";
        public const string QUOTATION_GENERATION_TEMPLATE = "QuotationGeneration.html";
     
        public const string Policy_Notification_Template = "PolicyNotificationTemplate.html";
        public const string Policy_Approval_Template = "PolicyApprovalTemplate.html";
        public const string Policy_Decline_Template = "PolicyDeclineTemplate.html";
        public const string Policy_Extra_Mortality_Notification_Template = "ExtraMortalityNotificationTemplate.html";
        public const string Broker_Impairment_Notification_Template = "BrokerImpairmentNotificationTemplate.html";
        public const string Policy_Endorsement_Notification_Template = "EndorsementPaymentNotificationTemplate.html";
        public const string Policy_Endorsement_Approval_Template = "PolicyEndorsementApprovalTemplate.html";
        public const string Policy_Endorsement_Decline_Template = "PolicyEndorsementDeclineTemplate.html";

        public const string NonLifeEndorsementRateModification = "NonLifeEndorsementRateModification.html";
        public const string NonLife_Quotation_Underwriter_Notification_Template = "NonLifeQuotationUnderWriterNotification.html";
        public const string NonLife_Policy_Certificate_Template = "NonLifeQuotationUnderWriterNotification.html";
        public const string TREATY_APPROVAL_NOTIFICATION_TEMPLATE = "TreatySetupApprovalTemplate.html";
        public const string TREATY_DECLINE_NOTIFICATION_TEMPLATE = "TreatySetupDeclineTemplate.html";
        public const string FACULTATIVE_DOCUMENT_TEMPLATE = "FacultativeDocumentTemplate.html";

        public const string Send_NonLife_Quotation_Template = "NonLifeQuotationSendQuotation.html";


        public const string WORKFLOW_EMAIL_TEMPLATE = "WorkflowEmailTemplate.html";


        #endregion
    }
}

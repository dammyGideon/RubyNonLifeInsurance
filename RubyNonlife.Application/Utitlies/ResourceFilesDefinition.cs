using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Utitlies
{
    public static class ResourceFilesDefinition
    {
        #region Root Directories
        public const string ROOT_RESOURCE_DIRECTORY = "Resources";
        public const string RESPONSE_MESSAGE_DIRECTORY = "ResponseMessages";
        public const string EMAIL_SUBJECTS_DIRECTORY = "EmailSubjects";
        public const string JSON_ENUM_DATA = "JsonEnumData";
        public const string PRODUCT_CLASS_ICON_DIRECTORY = "ProductClassIcons";
        #endregion

        #region Response Messages Sub-Directory
        public const string SUCCESS_MESSAGE_DIRECTORY = "Success";
        public const string ERROR_MESSAGE_DIRECTORY = "Error";
        #endregion

        public const string QUOTATION_SUCCESS_MESSAGES = "QuotationSuccessMessages.json";
        public const string QUOTATION_ERROR_MESSAGES = "QuotationErrorMessages.json";
        public const string POLICY_ERROR_MESSAGES = "PolicyErrorMessages.json";
        public const string POLICY_SUCCESS_MESSAGES = "PolicySuccessMessages.json";
        public const string FILE_SERVICE_MESSAGE = "FileServiceMessage.json";


      

        #region Email Subject Files
        public const string CUSTOMER_ONBOARDING_SUBJECTS = "CustomerOnboarding.json";
        public const string PRODUCT_SETUP_SUBJECTS = "ProductSetup.json";
        public const string POLICYBOOKING_SUBJECTS = "PolicyBooking.json";
        public const string NONLIFE_QUOTATION_SUBJECTS = "NonLifeQuotation.json";
        public const string REINSURANCE_SETUP_SUBJECTS = "ReinsuranceSetup.json";
        #endregion

        #region Json Enum Data
        public const string SUBJECT_DATA_TYPES = "SubjectDataTypes.json";
        public const string COST_BEARERS = "CostBearers.json";
        #endregion

    }
}

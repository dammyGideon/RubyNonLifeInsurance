using System.ComponentModel;

namespace RubyNonlife.Domain.Enums
{
    public enum ProductSetupStages
    {
        [Description("Basic Information")]
        BasicInformation,

        [Description("Cost Configurations")]
        CostConfigurations,

        [Description("Subject Configure")]
        SubjectConfigure,

        [Description(" Documentation")]
        Documentation,

        [Description("Attribute Mapping")]
        AttributeMapping,

        [Description("Fee Setup")]
        FeeSetup,

        [Description("Location Setup")]
        LocationSetup,
    }
}

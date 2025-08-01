namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public class ProductCostOfInsuranceRequest
    {
        public int CostType { get; set; }
        public int SourceId { get; set; }
        public int Year { get; set; }
        public decimal? Value { get; set; }
        public decimal Rate { get; set; }
        public string CostBearer { get; set; }
        public string DisplayFormula { get; set; }
    }

    

    //public class SubjectTypeAdditionalCoverRequest
    //{
    //    public short CoverId { get; set; }
    //    public int SubjectTypeId { get; set; }
    //    public string Status { get; set; }
    //    public string CoverLimits { get; set; }
    //    public string DisplayFormula { get; set; }

    //}

}

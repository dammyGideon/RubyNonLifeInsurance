namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public record ProductCostOfInsuranceResponse
    {
        
       public string CostType { get; init; }
        public int Year { get; init; }
        public string CostBearer { get; init; }
        public int CollectionSource { get; init; }
        public decimal? DebitAccount { get; init; }
        public decimal? CreditAmount { get; init; }
    }

    public record AccountSearchResponse
    {
        public string? AccountNumber { get; init; }
        public string? Name { get; init; }
    }


    public record AccountApiResponse<T>
    {
        public string Code { get; init; }
        public string Status { get; init; }
        public string Message { get; set; }
        public List<T> Data { get; init; }
    }

}


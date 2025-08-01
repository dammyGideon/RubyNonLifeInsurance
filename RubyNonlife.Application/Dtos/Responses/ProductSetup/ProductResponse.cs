namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public record ProductResponse
    {
        public int? Id { get; set; }
        public string ProductName { get; init; }
        public int ProductClassId { get; init; }
        public string ProductDescription { get; init; }
        public string Alias { get; init; }
        public string Code { get; init; }
        public int Progress { get; init; }
        public string CurrentStage { get; init; }
        public string ApprovalStatus { get; init; }
        public string ProductSetupStages { get; init; }
    }
        
}

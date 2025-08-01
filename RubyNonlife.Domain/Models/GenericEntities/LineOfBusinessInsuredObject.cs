using RubyNonlife.Domain.Models.Lookups;


namespace RubyNonlife.Domain.Models.GenericEntities
{
    public class LineOfBusinessInsuredObject : BaseEntity
    {
        public int CategoryId { get; set; }
        public LineOfBusinessAttributeCategory LineOfBusinessAttributeCategory { get; set; }
        public int ObjectId { get; set; }
    }

}

using RubyNonlife.Domain.Models.Lookups;


namespace RubyNonlife.Domain.Models.GenericEntities
{
    public class LineOfBusinessAttributeCategory : BaseEntity
    {
        public int BusinesslineId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public ICollection<LineOfBusinessInsuredObject> LineOfBusinessInsuredObjects { get; set; }
        public ICollection<LineOfBusinessAttributeItem> LineOfBusinessAttributeItems { get; set; }
    }

}

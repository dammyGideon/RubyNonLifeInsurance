namespace RubyNonlife.Domain.Models.Lookups
{
    public class CarMake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; } = DateTime.UtcNow;
        public ICollection<CarModel> Models {  get; set; }  
    }
}

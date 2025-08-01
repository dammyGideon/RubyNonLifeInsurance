using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.Lookups
{
    public class CarModelYear
    {
        public int Id { get; set; }
        [ForeignKey(nameof(CarModel))]
        public int CarModelId { get; set; }  
        public int Year { get; set; }        
        public CarModel CarModel { get; set; } 
    }

}

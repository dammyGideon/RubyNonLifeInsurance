using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.Lookups
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarMakeId { get; set; }
        public CarMake CarMake { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; } = DateTime.UtcNow;
        public ICollection<CarModel> CarModels { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.LineOfBusines
{
    public class CreateLineOfBusinessAttributeCategoryDto
    {
        public int BusinessLineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public List<CreateLineOfBusinessApplicableObjectDto> ApplicableObjects { get; set; } = new List<CreateLineOfBusinessApplicableObjectDto>();
    }



    public class UpdateLineOfBusinessAttributeCategoryDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public List<ApplicableObjectDto> ApplicableObjects { get; set; }
    }

    public class ApplicableObjectDto
    {
        public int ApplicableObjectId { get; set; }
    }



   

}

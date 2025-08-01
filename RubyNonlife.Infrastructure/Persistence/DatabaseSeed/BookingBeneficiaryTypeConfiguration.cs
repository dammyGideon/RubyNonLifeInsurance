using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubyNonlife.Domain.Models.PolicyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.DatabaseSeed
{
    public class BookingBeneficiaryTypeConfiguration : IEntityTypeConfiguration<BookingBeneficiaryType>
    {
        public void Configure(EntityTypeBuilder<BookingBeneficiaryType> builder)
        {
            builder.HasData(GetPredefinedBeneficiaryTypes());

        }

        private List<BookingBeneficiaryType> GetPredefinedBeneficiaryTypes()
        {
            return new List<BookingBeneficiaryType>{
            new BookingBeneficiaryType { Id = 1,Name = "Spouse" },
            new BookingBeneficiaryType { Id = 2, Name = "Son" },
            new BookingBeneficiaryType { Id = 3, Name = "Father" },
            new BookingBeneficiaryType { Id = 4, Name = "Daughter" },
            new BookingBeneficiaryType { Id = 5, Name = "Mother" },
           };
            
       }
    }
}

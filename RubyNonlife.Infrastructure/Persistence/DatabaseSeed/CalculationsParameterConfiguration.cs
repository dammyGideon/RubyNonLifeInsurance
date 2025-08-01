using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.DatabaseSeed
{
    public class CalculationsParameterConfiguration : IEntityTypeConfiguration<CalculationsParameter>
    {
        public void Configure(EntityTypeBuilder<CalculationsParameter> builder)
        {
            builder.HasData(
                    
                    new CalculationsParameter
                    {
                        Id = 1,
                        Name = "Sum Insured",
                        DateCreated = DateTime.UtcNow,
                    },
                     new CalculationsParameter
                     {
                         Id = 2,
                         Name = "Rate",
                         DateCreated = DateTime.UtcNow,
                     }

                );
        }
    }
}

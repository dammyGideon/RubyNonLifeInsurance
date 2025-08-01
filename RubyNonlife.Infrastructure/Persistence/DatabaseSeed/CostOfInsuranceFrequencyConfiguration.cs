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
    public class CostOfInsuranceFrequencyConfiguration : IEntityTypeConfiguration<CostOfInsuranceFrequency>
    {
        public void Configure(EntityTypeBuilder<CostOfInsuranceFrequency> builder)
        {
            builder.HasData(
                    
                    new CostOfInsuranceFrequency
                    {
                        Id = 1,
                        Name = "1 year",
                        DateCreated= DateTime.UtcNow,
                    },
                    new CostOfInsuranceFrequency
                    {
                        Id = 2,
                        Name = "2 year",
                        DateCreated = DateTime.UtcNow,
                    },

                     new CostOfInsuranceFrequency
                     {
                         Id = 3,
                         Name = "3 year",
                         DateCreated = DateTime.UtcNow,
                     },
                      new CostOfInsuranceFrequency
                      {
                          Id = 4,
                          Name = "4 year",
                          DateCreated = DateTime.UtcNow,
                      }

                );
        }
    }
}

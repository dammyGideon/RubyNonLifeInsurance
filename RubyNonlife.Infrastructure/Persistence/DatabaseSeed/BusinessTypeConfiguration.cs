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
    public class BusinessTypeConfiguration : IEntityTypeConfiguration<BusinessType>
    {
        public void Configure(EntityTypeBuilder<BusinessType> builder)
        {
            builder.HasData(
                    new BusinessType
                    {
                        Id = 1,
                        Name = "New Business",
                       
                    },
                     new BusinessType
                     {
                         Id = 2,
                         Name = "Renewal",
                        
                     },
                      new BusinessType
                      {
                          Id = 3,
                          Name = "Endorsement",
                   
                      }

                );
        }
    }
}

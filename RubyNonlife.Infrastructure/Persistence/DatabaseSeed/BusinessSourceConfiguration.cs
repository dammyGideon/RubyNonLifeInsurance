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
    public class BusinessSourceConfiguration : IEntityTypeConfiguration<PolicyBusinessSource>
    {
        public void Configure(EntityTypeBuilder<PolicyBusinessSource> builder)
        {
            builder.HasData(
                    new PolicyBusinessSource
                    {
                        Id = 1,
                        Name = "Business is Direct",
                    },
                    new PolicyBusinessSource
                    {
                        Id = 2,
                        Name= "Business is Brokered"
                    }
                );
        }
    }
}

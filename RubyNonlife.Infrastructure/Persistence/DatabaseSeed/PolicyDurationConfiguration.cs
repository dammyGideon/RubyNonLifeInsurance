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
    public class PolicyDurationConfiguration : IEntityTypeConfiguration<PolicyDuration>
    {
        public void Configure(EntityTypeBuilder<PolicyDuration> builder)
        {
            builder.HasData(
                    new PolicyDuration
                    {
                        Id = 1,
                        Name = "less than 3 months",
                        DateCreated = DateTime.Now,
                    },
                    new PolicyDuration
                    {
                        Id= 2,
                        Name="3 months",
                        DateCreated = DateTime.Now,
                    },
                    new PolicyDuration
                    {
                        Id=3,
                        Name="6 months",
                        DateCreated = DateTime.Now,
                    },
                    new PolicyDuration
                    {
                        Id =4, 
                        Name="9 months",
                        DateCreated = DateTime.Now,
                    },
                    new PolicyDuration
                    {
                        Id =5,
                        Name="12 months",
                        DateCreated = DateTime.Now,
                    }
                );
        }
    }
}

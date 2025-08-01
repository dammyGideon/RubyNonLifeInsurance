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
    public class PolicyBusinessTypeConfiguration : IEntityTypeConfiguration<PolicyBusinessType>
    {
        public void Configure(EntityTypeBuilder<PolicyBusinessType> builder)
        {
            builder.HasData(
                    new PolicyBusinessType
                    {
                        Id = 1,
                        Name = "Sole Insurance"
                    },
                    new PolicyBusinessType
                    {
                        Id= 2,
                        Name="Co-Insurance"
                    },
                    new PolicyBusinessType
                    {
                        Id=3,
                        Name="Facultative Inward"
                    }
                );
        }
    }
}

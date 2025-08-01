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
    public class PolicyAdditionalInformationConfiguration : IEntityTypeConfiguration<PolicyAdditionalInformation>
    {
        public void Configure(EntityTypeBuilder<PolicyAdditionalInformation> builder)
        {
           builder.HasData(
                        new PolicyAdditionalInformation
                        {
                            Id = 1,
                            Name = "Premium on quote represents 100% of transaction whole",
                        },
                        new PolicyAdditionalInformation
                        {
                            Id = 2,
                            Name = "Premium on quote represents 100% of AXA transactions only"
                        }
               
               );
        }
    }
}

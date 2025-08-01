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
    public class PolicyBookingBeneficiaryConfiguration : IEntityTypeConfiguration<PolicyBookingBeneficiary>
    {
        public void Configure(EntityTypeBuilder<PolicyBookingBeneficiary> builder)
        {
            builder.HasData(
                    new PolicyBookingBeneficiary
                    {
                        Id = 1,
                        Name ="Company"
                    },
                    new PolicyBookingBeneficiary
                    {
                        Id=2,
                        Name ="Named Beneficiary"
                    }
                );
        }
    }
}

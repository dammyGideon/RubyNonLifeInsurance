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
    public class PolicyBookingPaymentTypeConfiguration : IEntityTypeConfiguration<PolicyBookingPaymentType>
    {
        public void Configure(EntityTypeBuilder<PolicyBookingPaymentType> builder)
        {
            builder.HasData(
                    new PolicyBookingPaymentType
                    {
                        Id = 1,
                        Name="Cash Payment"
                    },
                    new PolicyBookingPaymentType
                    {
                        Id =2,
                        Name ="Credit Note"
                    }
                );
        }
    }
}

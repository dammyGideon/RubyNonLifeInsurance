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
    public class PolicyBookingInsurerConfiguration : IEntityTypeConfiguration<PolicyBookingInsurer>
    {
        public void Configure(EntityTypeBuilder<PolicyBookingInsurer> builder)
        {
            builder.HasData(
                    new PolicyBookingInsurer
                    {
                        Id= 1,
                        Name ="Axa Mansard Insurance"
                    },
                    new PolicyBookingInsurer
                    {
                        Id = 2,
                        Name = "Aiico Insurance"
                    },
                    new PolicyBookingInsurer
                    {
                        Id =3,
                        Name = "Leadway Assurance"
                    },
                    new PolicyBookingInsurer
                    {
                        Id = 4,
                        Name = "Mutual Benefits Assurance"
                    },
                    new PolicyBookingInsurer
                    {
                        Id = 5,
                        Name = "African Alliance Insurance"
                    },
                    new PolicyBookingInsurer
                    {
                        Id = 6,
                        Name = "Royal Exchange Assurance"
                    }
                );
        }
    }
}

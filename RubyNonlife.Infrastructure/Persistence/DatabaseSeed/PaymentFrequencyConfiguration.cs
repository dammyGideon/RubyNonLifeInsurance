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
    public class PaymentFrequencyConfiguration : IEntityTypeConfiguration<PaymentFrequency>
    {
        public void Configure(EntityTypeBuilder<PaymentFrequency> builder)
        {
            builder.HasData(

                new PaymentFrequency
                {
                    Id = 1,
                    Name = "One Time",
                    DateTime = DateTime.UtcNow
                },

                new PaymentFrequency
                {
                    Id = 2,
                    Name = "Adhoc",
                    DateTime = DateTime.UtcNow
                },
                new PaymentFrequency
                {
                    Id = 3,
                    Name = "Monthly",
                    DateTime = DateTime.UtcNow
                },
                new PaymentFrequency
                {
                    Id = 5,
                    Name = "Bi-Monthly",
                    DateTime = DateTime.UtcNow
                },
                new PaymentFrequency
                {
                    Id = 6,
                    Name = "Quarterly",
                    DateTime = DateTime.UtcNow
                },
                new PaymentFrequency
                {
                    Id = 7,
                    Name = "Bi-Annually",
                    DateTime = DateTime.UtcNow
                },
                new PaymentFrequency
                {
                    Id = 8,
                    Name = "Annually",
                    DateTime = DateTime.UtcNow
                }
                );
        }
    }
}

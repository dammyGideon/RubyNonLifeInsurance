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
    public class PolicyBrokerConfiguration : IEntityTypeConfiguration<PolicyBroker>
    {
        public void Configure(EntityTypeBuilder<PolicyBroker> builder)
        {
            builder.HasData(
                 new PolicyBroker
                 {
                     Id = 1,
                     Name = "A&G Insurance Brokers Ltd",
                 },
                 new PolicyBroker
                 {
                     Id= 2,
                     Name = "AIICO Insurance Brokers"
                 },
                 new PolicyBroker
                 {
                     Id = 3,
                     Name= "Boff & Co. Insurance Brokers Ltd"
                 },
                 new PolicyBroker
                 {
                     Id = 4,
                     Name= "Bluewaters Insurance Brokers Ltd",
                 },
                 new PolicyBroker
                 {
                     Id=5,
                     Name= "Banksome Insurance Brokers Ltd"
                 }
                );
        }
    }
}

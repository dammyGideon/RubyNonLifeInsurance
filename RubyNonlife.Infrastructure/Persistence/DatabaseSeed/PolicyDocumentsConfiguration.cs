using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubyNonlife.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.DatabaseSeed
{
    public class PolicyDocumentsConfiguration : IEntityTypeConfiguration<PolicyDocument>
    {
        public void Configure(EntityTypeBuilder<PolicyDocument> builder)
        {
            builder.HasData(
                    new PolicyDocument
                    {
                        Id = 1,
                        Name = "Driving Licenses",
                        DateCreated = DateTime.UtcNow,
                    },
                      new PolicyDocument
                      {
                          Id = 2,
                          Name = "Address Proof",
                          DateCreated = DateTime.UtcNow,
                      },
                      new PolicyDocument
                      {
                          Id=3,
                          Name ="Identity Proof",
                          DateCreated = DateTime.UtcNow,
                      },
                      new PolicyDocument
                      {
                          Id=4,
                          Name = "Vehicle Registration Certificate",
                          DateCreated = DateTime.UtcNow,
                      }


                );
        }
    }
}

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
    public class PolicyDocumentSizeConfiguration : IEntityTypeConfiguration<PolicyDocumentSize>
    {
        public void Configure(EntityTypeBuilder<PolicyDocumentSize> builder)
        {
            builder.HasData(

                    new PolicyDocumentSize
                    {
                        Id = 1,
                        Name = "3MB",
                        DateCreated = DateTime.UtcNow,
                    },
                    new PolicyDocumentSize
                    {
                        Id= 2,
                        Name= "5MB",
                        DateCreated= DateTime.UtcNow,
                    }
                );
        }
    }
}

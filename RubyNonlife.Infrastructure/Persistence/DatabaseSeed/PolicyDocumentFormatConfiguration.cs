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
    public class PolicyDocumentFormatConfiguration : IEntityTypeConfiguration<PolicyDocumentFormat>
    {
        public void Configure(EntityTypeBuilder<PolicyDocumentFormat> builder)
        {
            builder.HasData(
                
                    new PolicyDocumentFormat
                    {
                        Id= 1,
                        Name= "Pdf",
                        DateCreated= DateTime.UtcNow,
                    },

                     new PolicyDocumentFormat
                     {
                         Id = 2,
                         Name = "DOC/DOCX",
                         DateCreated = DateTime.UtcNow,
                     }
                      

                );
        }
    }
}

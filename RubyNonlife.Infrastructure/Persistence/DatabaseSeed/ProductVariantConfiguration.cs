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
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.HasData(
                    new ProductVariant
                    {
                        Id = 1,
                        Name = "Comprehensive Retail",
                        DateCreated = DateTime.UtcNow,
                    },
                     new ProductVariant
                     {
                         Id = 2,
                         Name = "Retail",
                         DateCreated = DateTime.UtcNow,
                     },
                     new ProductVariant
                     {
                         Id = 3,
                         Name = "Comprehensive Commercial",
                         DateCreated = DateTime.UtcNow,
                     },
                     new ProductVariant
                     {
                         Id= 4,
                         Name= "Commercial",
                         DateCreated = DateTime.UtcNow,
                     },
                     new ProductVariant
                     {
                         Id=5,
                         Name = "Individuals & Commercial",
                         DateCreated = DateTime.UtcNow,
                     }


                );
        }
    }
}

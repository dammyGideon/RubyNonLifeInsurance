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
    public class CollectionSourceConfiguration : IEntityTypeConfiguration<CollectionSource>
    {
        public void Configure(EntityTypeBuilder<CollectionSource> builder)
        {
            builder.HasData(
                    
                    new CollectionSource
                    {
                        Id = 1,
                        Name = "Sum Insured",
                        DateCreated = DateTime.UtcNow,
                    },

                    new CollectionSource
                    {
                        Id=2,
                        Name= "Gross Premium",
                        DateCreated = DateTime.UtcNow,
                    }

                );
        }
    }
}

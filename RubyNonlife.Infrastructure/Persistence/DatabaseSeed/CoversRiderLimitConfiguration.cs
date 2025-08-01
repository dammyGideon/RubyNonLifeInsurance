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
    public class CoversRiderLimitConfiguration : IEntityTypeConfiguration<CoversRiderLimit>
    {
        public void Configure(EntityTypeBuilder<CoversRiderLimit> builder)
        {
            builder.HasData(
                    
                    new CoversRiderLimit
                    {
                        Id = 1,
                        Name = "Inclusive",
                        DateCreated = DateTime.UtcNow,
                    },
                    new CoversRiderLimit
                    {
                        Id= 2,
                        Name= "Value",
                        DateCreated = DateTime.UtcNow, 
                    }

                );
        }
    }
}

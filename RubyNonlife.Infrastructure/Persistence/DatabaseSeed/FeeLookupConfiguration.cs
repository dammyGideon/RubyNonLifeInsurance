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
    public class FeeLookupConfiguration : IEntityTypeConfiguration<FeeLookup>
    {
        public void Configure(EntityTypeBuilder<FeeLookup> builder)
        {
            builder.HasData(
                    new FeeLookup
                    {
                        Id = 1,
                        Name = "Management Fee",
                        DateCreated = DateTime.Now,
                    },
                    new FeeLookup
                    {
                        Id = 2,
                        Name = "Broker Fee",
                        DateCreated = DateTime.Now,
                    },
                    new FeeLookup
                    {
                        Id=3,
                        Name = "Agent Fee",
                        DateCreated = DateTime.Now,
                    }
                );
        }
    }
}

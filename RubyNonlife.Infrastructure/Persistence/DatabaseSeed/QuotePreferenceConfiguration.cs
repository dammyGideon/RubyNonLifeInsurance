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
    public class QuotePreferenceConfiguration : IEntityTypeConfiguration<QuotePreferences>
    {
        public void Configure(EntityTypeBuilder<QuotePreferences> builder)
        {
            builder.HasData(
                    new QuotePreferences
                    {
                        Id = 1,
                        Name = "Simulation",
                        DateCreated = DateTime.UtcNow,
                    },
                    new QuotePreferences
                    {
                        Id = 2,
                        Name = "Customer Based",
                        DateCreated = DateTime.UtcNow,
                    }
                );
        }
    }
}

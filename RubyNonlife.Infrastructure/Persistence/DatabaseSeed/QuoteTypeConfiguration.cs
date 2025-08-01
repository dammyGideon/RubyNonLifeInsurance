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
    public class QuoteTypeConfiguration : IEntityTypeConfiguration<QuoteType>
    {
        public void Configure(EntityTypeBuilder<QuoteType> builder)
        {
            builder.HasData(
                    new QuoteType
                    {
                        Id =1,
                        Name = "Fleet",
                        DateCreated = DateTime.Now,
                    },
                    new QuoteType
                    {
                        Id=2,
                        Name = "Individual",
                        DateCreated = DateTime.Now,
                    }
                );
        }
    }
}

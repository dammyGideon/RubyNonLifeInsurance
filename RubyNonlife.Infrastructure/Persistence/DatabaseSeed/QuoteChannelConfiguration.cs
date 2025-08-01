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
    public class QuoteChannelConfiguration : IEntityTypeConfiguration<QuoteChannel>
    {
        public void Configure(EntityTypeBuilder<QuoteChannel> builder)
        {
            builder.HasData(
                    new QuoteChannel
                    {
                        Id = 1,
                        Name ="Direct Agent",
                        DateCreated = DateTime.Now,
                    },
                    new QuoteChannel
                    {
                        Id=2,
                        Name="Brokered",
                        DateCreated = DateTime.Now,
                    }
                );
        }
    }
}

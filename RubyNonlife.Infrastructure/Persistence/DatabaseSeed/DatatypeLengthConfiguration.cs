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
    public class DatatypeLengthConfiguration : IEntityTypeConfiguration<DatatypeLength>
    {
        public void Configure(EntityTypeBuilder<DatatypeLength> builder)
        {
            builder.HasData(

                    new DatatypeLength
                    {
                        Id = 1,
                        Name = "10 Characters",
                        Length = 10,
                        DateCreated = DateTime.UtcNow,
                    },
                    new DatatypeLength
                    {
                        Id = 2,
                        Name = "17 Characters",
                        Length = 17,
                        DateCreated = DateTime.UtcNow,
                    },

                    new DatatypeLength
                    {
                        Id = 3,
                        Name = "4 Characters",
                        Length = 4,
                        DateCreated = DateTime.UtcNow,
                    },

                    new DatatypeLength
                    {
                        Id = 4,
                        Name = "20 Characters",
                        Length = 20,
                        DateCreated = DateTime.UtcNow,
                    }

                );
        }
    }
}

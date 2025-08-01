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
    public class DatatypeConfiguration : IEntityTypeConfiguration<Datatype>
    {
        public void Configure(EntityTypeBuilder<Datatype> builder)
        {
            builder.HasData(

                    new Datatype
                    {
                        Id = 1,
                        Name= "Text",
                        DateCreated = DateTime.UtcNow,
                    },
                    new Datatype
                       {
                           Id = 2,
                           Name = "Number",
                           DateCreated = DateTime.UtcNow,
                       },
                    new Datatype
                    {
                        Id = 3,
                        Name = "Yes-No",
                        DateCreated = DateTime.UtcNow,
                    },
                    new Datatype
                    {
                        Id = 4,
                        Name = "Number",
                        DateCreated = DateTime.UtcNow,
                    }




                );
        }
    }
}

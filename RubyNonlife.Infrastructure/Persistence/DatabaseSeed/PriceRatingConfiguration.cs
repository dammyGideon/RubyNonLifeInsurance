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
    public class PriceRatingConfiguration : IEntityTypeConfiguration<PriceRating>
    {
        public void Configure(EntityTypeBuilder<PriceRating> builder)
        {
            builder.HasData(
                    
                    new PriceRating
                    {
                        Id = 1,
                        Name = "Flat",
                       
                    },
                    new PriceRating
                    {
                        Id = 2,
                        Name = "Percentage",
                      
                    },
                    new PriceRating
                     {
                         Id = 3,
                         Name = "Custom",
                       
                     },
                     new PriceRating
                      {
                          Id = 4,
                          Name = "Rate Per Mille",
                          
                      }

                );
        }
    }
}

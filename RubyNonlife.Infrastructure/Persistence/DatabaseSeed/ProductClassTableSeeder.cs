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
    public class ProductClassConfiguration : IEntityTypeConfiguration<ProductClass>
    {
        public void Configure(EntityTypeBuilder<ProductClass> builder)
        {
            builder.HasData(
                    
                    new ProductClass
                    {
                        Id = 1,
                        Name = "Motor",
                        ImageName = "dadfb5f1-2cbc-4034-8d91-22239796d162.png",
                        DateCreated = DateTime.UtcNow,
                    },
                     new ProductClass
                     {
                         Id = 2,
                         Name = "Fire",
                         ImageName = "cab7b37f-8d5c-4e58-8814-c2d43fda9eb6.png",
                         DateCreated = DateTime.UtcNow,
                     },
                     new ProductClass
                     {
                         Id = 3,
                         Name = "Marine",
                         ImageName = "ea72cda4-ecb2-4b7c-8a52-137f711342a2.png",
                         DateCreated = DateTime.UtcNow,
                     },
                      new ProductClass
                      {
                          Id = 4,
                          Name = "Equipment",
                          ImageName = "98c6a2cc-07a4-4b7f-bf79-678ada50d9c2.png",
                          DateCreated = DateTime.UtcNow,
                      },
                      new ProductClass
                       {
                           Id = 5,
                           Name = "Energy & Aviation",
                           ImageName = "85b49b67-11db-4747-b780-02bc1bfb8992.png",
                           DateCreated = DateTime.UtcNow,
                       },
                      new ProductClass
                        {
                            Id = 6,
                            Name = "Engineering",
                            ImageName = "c40b95d6-420c-431b-9d92-f2a2065103e0.png",
                            DateCreated = DateTime.UtcNow,
                        },

                      new ProductClass
                        {
                            Id = 7,
                            Name = "General Accident",
                            ImageName = "e5da823a-33ea-4f72-9f8a-19a3e69160a5.png",
                            DateCreated = DateTime.UtcNow,
                        },
                      new ProductClass
                         {
                             Id = 8,
                             Name = "Personal Lines",
                             ImageName = "0c807e5f-6d38-4faa-8c8e-475b65914029.png",
                             DateCreated = DateTime.UtcNow,
                         }

                );
        }
    }
}

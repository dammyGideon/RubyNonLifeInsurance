using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubyNonlife.Domain.Models.Lookups;
using System;

namespace RubyNonlife.Infrastructure.DatabaseSeed
{
    public class CarMakeConfiguration : IEntityTypeConfiguration<CarMake>
    {
        public void Configure(EntityTypeBuilder<CarMake> builder)
        {
            builder.HasData(
                new CarMake { Id = 1, Name = "Toyota" , CreateAt=DateTime.UtcNow},
                new CarMake { Id = 2, Name = "Honda", CreateAt = DateTime.UtcNow },
                new CarMake { Id = 3, Name = "Ford" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 4, Name = "Chevrolet" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 5, Name = "Nissan", CreateAt = DateTime.UtcNow },
                new CarMake { Id = 6, Name = "BMW" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 7, Name = "Mercedes-Benz" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 8, Name = "Volkswagen", CreateAt = DateTime.UtcNow },
                new CarMake { Id = 9, Name = "Hyundai" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 10, Name = "Audi" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 11, Name = "Lexus", CreateAt = DateTime.UtcNow },
                new CarMake { Id = 12, Name = "Subaru" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 13, Name = "Mazda", CreateAt = DateTime.UtcNow },
                new CarMake { Id = 14, Name = "Tesla" , CreateAt = DateTime.UtcNow },
                new CarMake { Id = 15, Name = "Kia", CreateAt = DateTime.UtcNow }
            );
        }
    }
}

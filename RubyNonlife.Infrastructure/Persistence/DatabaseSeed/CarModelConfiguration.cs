using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubyNonlife.Domain.Models.Lookups;

namespace RubyNonlife.Infrastructure.DatabaseSeed
{
    public class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.HasData(
                // Toyota Models
                new CarModel { Id = 1, CarMakeId = 1, Name = "Corolla" },
                new CarModel { Id = 2, CarMakeId = 1, Name = "Camry" },
                new CarModel { Id = 3, CarMakeId = 1, Name = "RAV4" },

                // Honda Models
                new CarModel { Id = 4, CarMakeId = 2, Name = "Civic" },
                new CarModel { Id = 5, CarMakeId = 2, Name = "Accord" },
                new CarModel { Id = 6, CarMakeId = 2, Name = "CR-V" },

                // Ford Models
                new CarModel { Id = 7, CarMakeId = 3, Name = "F-150" },
                new CarModel { Id = 8, CarMakeId = 3, Name = "Mustang" },
                new CarModel { Id = 9, CarMakeId = 3, Name = "Escape" },

                // Chevrolet Models
                new CarModel { Id = 10, CarMakeId = 4, Name = "Silverado" },
                new CarModel { Id = 11, CarMakeId = 4, Name = "Equinox" },
                new CarModel { Id = 12, CarMakeId = 4, Name = "Malibu" },

                // Nissan Models
                new CarModel { Id = 13, CarMakeId = 5, Name = "Altima" },
                new CarModel { Id = 14, CarMakeId = 5, Name = "Sentra" },
                new CarModel { Id = 15, CarMakeId = 5, Name = "Rogue" },

                // BMW Models
                new CarModel { Id = 16, CarMakeId = 6, Name = "3 Series" },
                new CarModel { Id = 17, CarMakeId = 6, Name = "X5" },
                new CarModel { Id = 18, CarMakeId = 6, Name = "5 Series" },

                // Mercedes-Benz Models
                new CarModel { Id = 19, CarMakeId = 7, Name = "C-Class" },
                new CarModel { Id = 20, CarMakeId = 7, Name = "E-Class" },
                new CarModel { Id = 21, CarMakeId = 7, Name = "GLC" },

                // Volkswagen Models
                new CarModel { Id = 22, CarMakeId = 8, Name = "Golf" },
                new CarModel { Id = 23, CarMakeId = 8, Name = "Passat" },
                new CarModel { Id = 24, CarMakeId = 8, Name = "Tiguan" },

                // Hyundai Models
                new CarModel { Id = 25, CarMakeId = 9, Name = "Elantra" },
                new CarModel { Id = 26, CarMakeId = 9, Name = "Sonata" },
                new CarModel { Id = 27, CarMakeId = 9, Name = "Tucson" },

                // Audi Models
                new CarModel { Id = 28, CarMakeId = 10, Name = "A4" },
                new CarModel { Id = 29, CarMakeId = 10, Name = "Q5" },
                new CarModel { Id = 30, CarMakeId = 10, Name = "A6" },

                // Lexus Models
                new CarModel { Id = 31, CarMakeId = 11, Name = "RX" },
                new CarModel { Id = 32, CarMakeId = 11, Name = "ES" },
                new CarModel { Id = 33, CarMakeId = 11, Name = "NX" },

                // Subaru Models
                new CarModel { Id = 34, CarMakeId = 12, Name = "Impreza" },
                new CarModel { Id = 35, CarMakeId = 12, Name = "Forester" },
                new CarModel { Id = 36, CarMakeId = 12, Name = "Outback" },

                // Mazda Models
                new CarModel { Id = 37, CarMakeId = 13, Name = "Mazda3" },
                new CarModel { Id = 38, CarMakeId = 13, Name = "CX-5" },
                new CarModel { Id = 39, CarMakeId = 13, Name = "Mazda6" },

                // Tesla Models
                new CarModel { Id = 40, CarMakeId = 14, Name = "Model 3" },
                new CarModel { Id = 41, CarMakeId = 14, Name = "Model S" },
                new CarModel { Id = 42, CarMakeId = 14, Name = "Model X" },

                // Kia Models
                new CarModel { Id = 43, CarMakeId = 15, Name = "Optima" },
                new CarModel { Id = 44, CarMakeId = 15, Name = "Sorento" },
                new CarModel { Id = 45, CarMakeId = 15, Name = "Sportage" }
            );
        }
    }
}

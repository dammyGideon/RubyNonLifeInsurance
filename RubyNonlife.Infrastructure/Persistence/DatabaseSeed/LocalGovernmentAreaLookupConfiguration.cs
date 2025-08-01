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
    public class LocalGovernmentAreaLookupConfiguration : IEntityTypeConfiguration<LocalGovernmentAreaLookup>
    {
        public void Configure(EntityTypeBuilder<LocalGovernmentAreaLookup> builder)
        {
            builder.HasData(GetLocalGovernmentAreas());
        }

        private List<LocalGovernmentAreaLookup> GetLocalGovernmentAreas()
        {
            return new List<LocalGovernmentAreaLookup>{
        // Abia State LGAs
        new LocalGovernmentAreaLookup { Id = 1, Name = "Aba North", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 2, Name = "Aba South", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 3, Name = "Arochukwu", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 4, Name = "Bende", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 5, Name = "Ikwuano", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 6, Name = "Isiala Ngwa North", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 7, Name = "Isiala Ngwa South", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 8, Name = "Isuikwuato", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 9, Name = "Obi Ngwa", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 10, Name = "Ohafia", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 11, Name = "Osisioma", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 12, Name = "Ugwunagbo", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 13, Name = "Ukwa East", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 14, Name = "Ukwa West", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 15, Name = "Umuahia North", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 16, Name = "Umuahia South", StateId = 1 },
        new LocalGovernmentAreaLookup { Id = 17, Name = "Umu Nneochi", StateId = 1 },

        // Adamawa State LGAs
        new LocalGovernmentAreaLookup { Id = 18, Name = "Demsa", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 19, Name = "Fufure", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 20, Name = "Ganye", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 21, Name = "Girei", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 22, Name = "Gombi", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 23, Name = "Guyuk", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 24, Name = "Hong", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 25, Name = "Jada", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 26, Name = "Lamurde", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 27, Name = "Madagali", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 28, Name = "Maiha", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 29, Name = "Mayo-Belwa", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 30, Name = "Michika", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 31, Name = "Mubi North", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 32, Name = "Mubi South", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 33, Name = "Numan", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 34, Name = "Shelleng", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 35, Name = "Song", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 36, Name = "Toungo", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 37, Name = "Yola North", StateId = 2 },
        new LocalGovernmentAreaLookup { Id = 38, Name = "Yola South", StateId = 2 },

        // Lagos State LGAs
        new LocalGovernmentAreaLookup { Id = 100, Name = "Agege", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 101, Name = "Ajeromi-Ifelodun", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 102, Name = "Alimosho", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 103, Name = "Amuwo-Odofin", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 104, Name = "Apapa", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 105, Name = "Badagry", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 106, Name = "Epe", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 107, Name = "Eti-Osa", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 108, Name = "Ibeju-Lekki", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 109, Name = "Ifako-Ijaiye", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 110, Name = "Ikeja", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 111, Name = "Ikorodu", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 112, Name = "Kosofe", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 113, Name = "Lagos Island", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 114, Name = "Lagos Mainland", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 115, Name = "Mushin", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 116, Name = "Ojo", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 117, Name = "Oshodi-Isolo", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 118, Name = "Shomolu", StateId = 24 },
        new LocalGovernmentAreaLookup { Id = 119, Name = "Surulere", StateId = 24 },

        // Kano State LGAs
        new LocalGovernmentAreaLookup { Id = 200, Name = "Ajingi", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 201, Name = "Albasu", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 202, Name = "Bagwai", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 203, Name = "Bebeji", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 204, Name = "Bichi", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 205, Name = "Bunkure", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 206, Name = "Dala", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 207, Name = "Dambatta", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 208, Name = "Dawakin Kudu", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 209, Name = "Dawakin Tofa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 210, Name = "Doguwa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 211, Name = "Fagge", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 212, Name = "Gabasawa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 213, Name = "Garko", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 214, Name = "Garun Mallam", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 215, Name = "Gaya", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 216, Name = "Gezawa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 217, Name = "Gwale", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 218, Name = "Gwarzo", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 219, Name = "Kabo", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 220, Name = "Kano Municipal", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 221, Name = "Karaye", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 222, Name = "Kibiya", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 223, Name = "Kiru", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 224, Name = "Kumbotso", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 225, Name = "Kunchi", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 226, Name = "Kura", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 227, Name = "Madobi", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 228, Name = "Makoda", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 229, Name = "Minjibir", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 230, Name = "Nasarawa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 231, Name = "Rano", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 232, Name = "Rimin Gado", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 233, Name = "Rogo", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 234, Name = "Shanono", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 235, Name = "Sumaila", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 236, Name = "Takai", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 237, Name = "Tarauni", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 238, Name = "Tofa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 239, Name = "Tsanyawa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 240, Name = "Tudun Wada", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 241, Name = "Ungogo", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 242, Name = "Warawa", StateId = 19 },
        new LocalGovernmentAreaLookup { Id = 243, Name = "Wudil", StateId = 19 },
        
        // Add remaining states and their LGAs similarly...
    };
        }

    }
}

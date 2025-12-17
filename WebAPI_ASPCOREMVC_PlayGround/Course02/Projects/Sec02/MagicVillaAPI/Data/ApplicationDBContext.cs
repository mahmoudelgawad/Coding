using MagicVillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVillaAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        { }

       public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Villa>().HasData(
            new Villa {
              ID = 1,
              Name = "Rolyal Villa",
              Details= "A Royal Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.",
              ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Royal_villa_of_Durres_01.jpg/960px-Royal_villa_of_Durres_01.jpg?20191004113828",
              Occupancy= 20,
              Rate=5000,
              AreaSqft = 1000,
              Amenity="",
              CreatedDate = new DateTime(2025,12,17)
            },
            new Villa
            {
                ID = 2,
                Name = "Luxury Pool Villa",
                Details = "Luxury Pool Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Pool_villa.jpg/960px-Pool_villa.jpg?20111226054028",
                Occupancy = 10,
                Rate = 800,
                AreaSqft = 600,
                Amenity = "",
                CreatedDate = new DateTime(2025, 12, 17)
            },
            new Villa
            {
                ID = 3,
                Name = "Pool Villa",
                Details = "Pool Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Backyardpool.jpg/960px-Backyardpool.jpg",
                Occupancy = 5,
                Rate = 600,
                AreaSqft = 450,
                Amenity = "",
                CreatedDate = new DateTime(2025, 12, 17)
            },
            new Villa
            {
                ID = 4,
                Name = "Sea View Villa",
                Details = "Sea View Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Coronado_beach_house.jpg/960px-Coronado_beach_house.jpg",
                Occupancy = 6,
                Rate = 750,
                AreaSqft = 590,
                Amenity = "",
                CreatedDate = new DateTime(2025, 12, 17)
            },
            new Villa
            {
                ID = 5,
                Name = "Leak View Villa",
                Details = "Leak View Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9e/06VillaBalbianello.jpg",
                Occupancy = 10,
                Rate = 450,
                AreaSqft = 400,
                Amenity = "",
                CreatedDate = new DateTime(2025, 12, 17)
            }
           );
        }
    }
}

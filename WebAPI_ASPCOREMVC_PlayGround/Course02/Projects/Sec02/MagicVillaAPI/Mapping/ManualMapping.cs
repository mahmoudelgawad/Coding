using MagicVillaAPI.Models;
using MagicVillaAPI.Models.DTO;

namespace MagicVillaAPI.Mapping
{
    public class ManualMapping
    {
        public static Villa Map(VillaDTO villaDto)
        {
            return new Villa
            {
                ID = villaDto.ID,
                Name = villaDto.Name,
                Details = villaDto.Details,
                AreaSqft = villaDto.AreaSqft,
                ImageUrl = villaDto.ImageUrl,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Amenity = villaDto.Amenity,
            };
        }

        public static Villa Map(VillaCreatDTO villaDto)
        {
            return new Villa
            {
                Name = villaDto.Name,
                Details = villaDto.Details,
                AreaSqft = villaDto.AreaSqft,
                ImageUrl = villaDto.ImageUrl,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Amenity = villaDto.Amenity,
            };
        }

        public static Villa Map(VillaUpdateDTO villaDto)
        {
            return new Villa
            {
                ID = villaDto.ID,
                Name = villaDto.Name,
                Details = villaDto.Details,
                AreaSqft = villaDto.AreaSqft,
                ImageUrl = villaDto.ImageUrl,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Amenity = villaDto.Amenity,
            };
        }
        public static VillaUpdateDTO Map(Villa villa)
        {
            return new VillaUpdateDTO
            {
                ID = villa.ID,
                Name = villa.Name,
                Details = villa.Details,
                AreaSqft = villa.AreaSqft,
                ImageUrl = villa.ImageUrl,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Amenity = villa.Amenity
            };
        }
    }
}

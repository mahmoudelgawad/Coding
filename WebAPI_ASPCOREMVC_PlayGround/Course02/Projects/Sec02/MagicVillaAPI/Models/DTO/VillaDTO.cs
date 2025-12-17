using System.ComponentModel.DataAnnotations;

namespace MagicVillaAPI.Models.DTO
{
    public class VillaDTO
    {
        public int ID { get; set; }

        //#data annotation
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public double Rate { get; set; }
        public string Details { get; set; }
        public int AreaSqft { get; set;}
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}

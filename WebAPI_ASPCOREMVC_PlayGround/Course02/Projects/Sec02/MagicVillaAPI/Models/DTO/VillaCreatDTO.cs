using System.ComponentModel.DataAnnotations;

namespace MagicVillaAPI.Models.DTO
{
    public class VillaCreatDTO
    {
        //#data annotation
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public int AreaSqft { get; set;}
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}

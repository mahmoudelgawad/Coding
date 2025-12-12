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

        public float AreaSqft { get; set;}

        public int Occupancy { get; set; }
    }
}

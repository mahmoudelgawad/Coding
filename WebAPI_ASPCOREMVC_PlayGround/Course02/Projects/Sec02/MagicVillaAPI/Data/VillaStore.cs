using MagicVillaAPI.Models.DTO;

namespace MagicVillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villas = new List<VillaDTO>{
                new VillaDTO{ ID = 1,Name="Pool View"},
                new VillaDTO{ ID = 2,Name="Beach View"}
            };
    }
}

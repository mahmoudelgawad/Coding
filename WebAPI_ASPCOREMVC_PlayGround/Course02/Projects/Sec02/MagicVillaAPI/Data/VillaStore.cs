using MagicVillaAPI.Models.DTO;

namespace MagicVillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villas = new List<VillaDTO>{
                new VillaDTO{ ID = 1,Name="Pool View",Occupancy = 5, AreaSqft =300.0f},
                new VillaDTO{ ID = 2,Name="Beach View",Occupancy = 3,AreaSqft = 150.0f}
            };
    }
}

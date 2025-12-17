using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class seeddatavillas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "ID", "Amenity", "AreaSqft", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Royal Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Royal_villa_of_Durres_01.jpg/960px-Royal_villa_of_Durres_01.jpg?20191004113828", "Rolyal Villa", 20, 5000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxury Pool Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Pool_villa.jpg/960px-Pool_villa.jpg?20111226054028", "Luxury Pool Villa", 10, 800.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pool Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Backyardpool.jpg/960px-Backyardpool.jpg", "Pool Villa", 5, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", 590, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sea View Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Coronado_beach_house.jpg/960px-Coronado_beach_house.jpg", "Sea View Villa", 6, 750.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leak View Villa description highlights ultimate luxury, blending opulent decor (crystal chandeliers, silk carpets, marble floors) with exclusive amenities like private pools/Jacuzzis, sea views, multiple en-suite bedrooms, maid's quarters, fine dining areas, and high-tech features, all designed for prestige and relaxation, echoing palace grandeur in a private sanctuary.", "https://upload.wikimedia.org/wikipedia/commons/9/9e/06VillaBalbianello.jpg", "Leak View Villa", 10, 450.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}

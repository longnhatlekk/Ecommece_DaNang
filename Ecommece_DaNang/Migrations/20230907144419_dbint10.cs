using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductOption",
                columns: new[] { "productOptionId", "Price", "ProductId", "productOptionName" },
                values: new object[,]
                {
                    { 7, 6500000m, 3, "64GB" },
                    { 8, 6800000m, 3, "256GB" },
                    { 9, 7500000m, 3, "512GB" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 9);
        }
    }
}

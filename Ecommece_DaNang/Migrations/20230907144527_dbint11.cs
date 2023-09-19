using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductOption",
                columns: new[] { "productOptionId", "Price", "ProductId", "productOptionName" },
                values: new object[,]
                {
                    { 10, 12000000m, 4, "64GB" },
                    { 11, 13000000m, 4, "256GB" },
                    { 12, 14000000m, 4, "512GB" },
                    { 13, 12500000m, 5, "64GB" },
                    { 14, 13000000m, 5, "256GB" },
                    { 15, 13500000m, 5, "512GB" },
                    { 16, 15000000m, 6, "64GB" },
                    { 17, 15500000m, 6, "256GB" },
                    { 18, 16000000m, 6, "512GB" },
                    { 19, 15500000m, 7, "64GB" },
                    { 20, 16500000m, 7, "256GB" },
                    { 21, 17500000m, 7, "512GB" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 21);
        }
    }
}

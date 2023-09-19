using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductOption",
                columns: new[] { "productOptionId", "Price", "ProductId", "productOptionName" },
                values: new object[,]
                {
                    { 22, 19000000m, 8, "64GB" },
                    { 23, 19500000m, 8, "256GB" },
                    { 24, 20000000m, 8, "512GB" },
                    { 25, 5000000m, 11, "40mm" },
                    { 26, 6000000m, 11, "44mm" },
                    { 27, 23900000m, 16, "128GB" },
                    { 28, 26900000m, 16, "256GB" },
                    { 29, 51000000m, 17, "1T" },
                    { 30, 62000000m, 17, "2T" },
                    { 31, 17490000m, 18, "64GB" },
                    { 32, 19490000m, 18, "256GB" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 32);
        }
    }
}

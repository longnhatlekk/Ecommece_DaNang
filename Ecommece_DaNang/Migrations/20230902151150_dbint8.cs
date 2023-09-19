using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductOption",
                columns: new[] { "productOptionId", "Price", "ProductId", "productOptionName" },
                values: new object[,]
                {
                    { 1, 5000000m, 1, "64GB" },
                    { 2, 5500000m, 1, "256GB" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 2);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbinit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "Iphone");

            migrationBuilder.InsertData(
                table: "CateProduct",
                columns: new[] { "CateID", "CateName" },
                values: new object[,]
                {
                    { "AP", "Apple Watch" },
                    { "IP", "Iphone" },
                    { "LG", "LG" },
                    { "OP", "Oppo" },
                    { "PC", "PoCo" },
                    { "SS", "Sam Sung" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CateId", "Description", "Image", "Price", "ProductName", "Quantity" },
                values: new object[] { 1, "IP", "• Màn hình: OLED5.8″Super Retina\r\n\r\n• Hệ điều hành: iOS 12\r\n\r\n• Camera sau: 12 MP\r\n\r\n• Camera trước: 7 MP\r\n\r\n• Chip: Apple A11 Bionic\r\n\r\n• RAM: 3 GB\r\n\r\n• Bộ nhớ trong: 64 GB\r\n\r\n• SIM: 1 Nano SIM\r\n\r\n• Pin: 2716 mAh, công nghệ sạc không dây Qi và công nghệ sạc nhanh 15W\r\n\r\n• Chuẩn chống nước và chống bụi IP67", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fhitaothom.com%2Fsan-pham%2Fiphone-x-lock%2F&psig=AOvVaw3UDdvSAkSnhpWbA_ofkpNv&ust=1693639686996000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDbkdHxiIEDFQAAAAAdAAAAABAD", 5000000m, "Iphone x", 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "AP");

            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "LG");

            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "OP");

            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "PC");

            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "SS");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "IP");

            migrationBuilder.InsertData(
                table: "CateProduct",
                columns: new[] { "CateID", "CateName" },
                values: new object[] { "Iphone", "Iphone 8" });
        }
    }
}

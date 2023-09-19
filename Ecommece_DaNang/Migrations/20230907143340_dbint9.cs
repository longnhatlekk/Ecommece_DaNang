using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "ImageProduct",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageProduct", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_ImageProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 16000000m);

            migrationBuilder.InsertData(
                table: "ProductOption",
                columns: new[] { "productOptionId", "Price", "ProductId", "productOptionName" },
                values: new object[,]
                {
                    { 3, 6000000m, 1, "512GB" },
                    { 4, 6000000m, 2, "64GB" },
                    { 5, 6300000m, 2, "256GB" },
                    { 6, 7000000m, 2, "512GB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageProduct_ProductId",
                table: "ImageProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageProduct");

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductOption",
                keyColumn: "productOptionId",
                keyValue: 6);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Image",
                value: "https://cellbuddy.in/buddy/wp-content/uploads/2022/09/X-Space-grey-2.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Image",
                value: "https://theedgestores.com/wp-content/uploads/2021/12/refurb-iphone-xs-gold-1-3.jpeg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Image",
                value: "https://product.hstatic.net/200000348419/product/iphone_11_be5db75904c5439c8718ca264a91ea71_master.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Image",
                value: "https://tabletplaza.vn/images/mau-ip-11-pro-max.jpg?1654154298046");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Image",
                value: "https://truesmart.com.vn/wp-content/uploads/iphone-12-pro-256gb-quoc-te-chinh-hang-cu-p10049.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Image",
                value: "https://mobileworld.com.vn/uploads/product/brand/iphone-12-pro-max-mobileworld.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Image",
                value: "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_iphone13_hero_09142021_inline.jpg.slideshow-xlarge_2x.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Image",
                value: "https://thanhmobile.vn/uploads/plugin/product_items/896/iphone-13-pro-max-256gb-2.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Image", "Price" },
                values: new object[] { "https://truesmart.com.vn/wp-content/uploads/iphone-13-pro-128gb-quoc-te-new-p9745.jpg", 4129000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Image",
                value: "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2023/2/14/1147651/Screen-Shot-2023-02--01.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Image",
                value: "https://cdn11.dienmaycholon.vn/filewebdmclnew/DMCL21/Picture//Apro/Apro_product_31747/apple-watch-se-_main_442_1020.png.webp");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Image",
                value: "https://cdn.tgdd.vn/Products/Images/7077/289798/apple-watch-se-2022-44mm-vien-nhom-den-xanh-1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Image",
                value: "https://cdn.tgdd.vn/Products/Images/7077/289825/Slider/vi-vn-apple-watch-s8-lte-45mm-(8).jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Image",
                value: "https://cdn.tgdd.vn/Products/Images/7077/289814/Slider/apple-watch-ultra-alpine-m637985871601777347.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Image",
                value: "https://cdn.tgdd.vn/Products/Images/522/248096/Slider/ipad-air-5637867629018282670.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Image",
                value: "https://cdn.tgdd.vn/Products/Images/522/295458/Slider/ipad-pro-m2-11-inch-wifi-cellular-128gb638030918788729407.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Image",
                value: "https://cdn.tgdd.vn/Products/Images/522/269330/Slider/vi-vn-ipad-pro-m1-11-inch-wifi-cellular-2tb-2021-1.jpeg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Image",
                value: "https://cdn.tgdd.vn/Products/Images/522/274155/Slider/ipad-air-5-m1-wifi-cellular-64gb637867631880933424.jpg");
        }
    }
}

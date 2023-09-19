using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ImageProduct",
                columns: new[] { "ImageId", "Color", "Image", "ProductId" },
                values: new object[,]
                {
                    { 1, "Trắng", "https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-hh-600x600.jpg", 1 },
                    { 2, "Đen", "https://cellbuddy.in/buddy/wp-content/uploads/2022/09/X-Space-grey-2.png", 1 },
                    { 3, "Trắng", "https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-hh-600x600.jpg", 2 },
                    { 4, "Đen", "https://cellbuddy.in/buddy/wp-content/uploads/2022/09/X-Space-grey-2.png", 2 },
                    { 5, "Gold", "https://p.ipricegroup.com/uploaded_9613fe97543343dafd8307992bf3526f.jpg", 2 },
                    { 6, "Trắng", "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-200x200.jpg", 3 },
                    { 7, "Tím", "https://i.insider.com/5df10d81fd9db229ba736a77?width=700", 3 },
                    { 8, "Trắng", "https://product.hstatic.net/200000571041/product/iphone-11-pro-bac-600x600-200x200-1_5583b7a21a5643798a9761d18dfba888.jpeg", 4 },
                    { 9, "Xanh Rêu", "https://cdn.tgdd.vn/Products/Images/42/200533/iphone-11-pro-max-green-600x600.jpg", 4 },
                    { 10, "Gold", "https://cdn.mobilecity.vn/mobilecity-vn/images/2021/07/iphone-11-pro-max-vang.jpg.webp", 4 },
                    { 11, "Gold", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone-12-pro-gold-2020?wid=2000&hei=1897&fmt=jpeg&qlt=95&.v=1635202844000", 5 },
                    { 12, "Trắng", "https://media.solotodo.com/media/products/1249252_picture_1602843842.png", 5 },
                    { 13, "Xanh", "https://bizweb.dktcdn.net/thumb/1024x1024/100/398/430/products/iphone-12-pro-family-hero-f7dab161-d654-4f74-8959-ddfeb48ef397.jpg?v=1660804901257", 5 },
                    { 14, "Xanh", "https://cdn.tgdd.vn/Products/Images/42/213033/iphone-12-pro-max-xanh-duong-new-600x600-600x600.jpg", 6 },
                    { 15, "Gold", "https://huydungmobile.com/wp-content/uploads/2023/01/refurb-iphone-12-pro-max-gold-2020.jpeg", 6 },
                    { 16, "Trắng", "https://cdnphoto.dantri.com.vn/EGz2fNvNzX9yTEmcRkcsss4JO-Q=/thumb_w/1020/2023/05/04/iphone-12-pro-max-1683213868319.jpg", 6 },
                    { 17, "Hồng", "https://techland.com.vn/wp-content/uploads/2021/09/iphone-13-pink-select-2021.png", 7 },
                    { 18, "Trắng", "https://cdn.viettelstore.vn/Images/Product/ProductImage/452166194.jpeg", 7 },
                    { 19, "Xanh", "https://cdn.tgdd.vn/Products/Images/42/223602/s16/iphone-13-blue-thumbtz-650x650.png", 7 },
                    { 20, "Xanh", "https://cdn2.cellphones.com.vn/x/media/catalog/product/3/_/3_51_1_7.jpg", 8 },
                    { 21, "Trắng", "https://cdn2.cellphones.com.vn/x358,webp,q100/media/catalog/product/4/_/4_36_3_2_1_9.jpg", 8 },
                    { 22, "Đen", "https://cdn.viettelstore.vn/Images/Product/ProductImage/1191787513.jpeg", 8 },
                    { 29, "Trắng", "https://cdn.hoanghamobile.com/i/preview/Uploads/2022/12/20/whatsapp-image-2022-12-20-at-14-37-24-1.jpeg", 11 },
                    { 30, "Đen", "https://bizweb.dktcdn.net/100/031/560/products/mpln3ref-vw-34fr-plus-watch-40-alum-midnight-nc-se-broshop.jpg?v=1663311761107", 11 },
                    { 31, "Đen", "https://cdn2.cellphones.com.vn/x/media/catalog/product/i/p/ipad-pro-13-select-wifi-spacegray-202210-02.jpg", 16 },
                    { 32, "Trắng", "https://newtechshop.vn/wp-content/uploads/2023/03/Danh-gia-Ipad-Pro-M2-9.png", 16 },
                    { 33, "Đen", "https://cdn.tgdd.vn/Products/Images/522/269328/ipad-pro-m1-11-inch-wifi-2tb-2021-xam-thumb-600x600.jpeg", 17 },
                    { 34, "Trắng", "https://cdn.tgdd.vn/Products/Images/522/269328/ipad-pro-m1-11-inch-wifi-2tb-2021-bac-thumb-600x600.jpeg", 17 },
                    { 35, "Tím", "https://futureworld.com.vn/media/catalog/product/cache/4dbf4504e0d2fdef53ffcd9886d02b04/s/c/screen_shot_2022-06-23_at_10.21.59.png", 18 },
                    { 36, "Xanh", "https://laptopvang.com/wp-content/uploads/2022/03/Apple-iPad-Air-5-Blue-laptopvang1.png", 18 },
                    { 37, "Trắng", "https://i.blogs.es/a4dfe7/apple_ipad_air_4/450_1000.webp", 18 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ImageProduct",
                keyColumn: "ImageId",
                keyValue: 37);
        }
    }
}

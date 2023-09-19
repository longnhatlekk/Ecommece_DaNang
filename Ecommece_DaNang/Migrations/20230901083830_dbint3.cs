using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CateId", "Description", "Image", "Price", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 2, "IP", "• Màn hình: OLED5.8″ Super Retina, 1125 x 2436 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 12, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP\r\n\r\n• Camera trước: Dual 7 MP\r\n\r\n• Chip: Apple A12 Bionic (7 nm)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 512 GB\r\n\r\n• SIM: 2 sim gồm nano SIM và e-Sim\r\n\r\n• Pin: 2658 mAh, hỗ trợ sạc nhanh 15W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Xám đen, Vàng hồng, Trắng bạc", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Freviews.com.np%2Fproduct%2Fiphone-xs-max&psig=AOvVaw1ZwmAu-TBv0rotCHroPVuM&ust=1693639736810000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCLCS2enxiIEDFQAAAAAdAAAAABAc", 6000000m, "Iphone xs", 20 },
                    { 3, "IP", "• Màn hình: Liquid Retina IPS LCD, 625 nits (typ), 6.1 inches, 828 x 1792 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP, 13mm (ultrawide), 1/3.6″\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 256 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3110 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Black (đen), Green (xanh mint), Yellow (vàng đồng), Purple (tím), Red (đỏ), White (trắng)", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fthongsokythuat.vn%2Fsp%2Fapple-iphone-11-2019%2F&psig=AOvVaw3PvYf7rJ0RCxZd-qfJQ5IN&ust=1693639921414000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCKDInMLyiIEDFQAAAAAdAAAAABAD", 6500000m, "Iphone 11", 20 },
                    { 4, "IP", "• Màn hình: Super Retina XDR OLED, HDR10, 6.5 inches, 1242 x 2688 pixels\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Bộ 3 camera đầu tiên 12 MP\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 64 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3969 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Matte Space Gray (Xám Đen), Matte Silver (Xám bạc), Matte Gold (Đồng), Matte Midnight Green (Xanh Lá Mạ)", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fchmobile.vn%2Fproducts%2Fiphone-11-pro-max-vang-gold&psig=AOvVaw3PvYf7rJ0RCxZd-qfJQ5IN&ust=1693639921414000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCKDInMLyiIEDFQAAAAAdAAAAABAI", 12000000m, "Iphone 11pro Max", 20 },
                    { 5, "IP", "• Màn hình: OLED6.1″ “Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 3 camera 12 MP\r\n\r\n• Camera trước: 12 MP, f/2.2, 23mm (wide), 1/3.6” SL 3D, (depth/biometrics sensor)\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 2815 mAh, 20 W\r\n\r\n• Kích thước 146.7 x 71.5 x 7.4 mm", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fdidongthongminh.vn%2Fiphone-12-pro-128gb-chinh-hang-vna&psig=AOvVaw1WuNmqS0r9I5GMkyBxo6a-&ust=1693640098755000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCLjyoZzziIEDFQAAAAAdAAAAABAE", 12500000m, "Iphone 12Pro", 20 },
                    { 6, "IP", "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 12 MP, f/2.2, 23mm (wide), 1/3.6\r\n\r\n• Camera trước: 12 MP, f/1.6, 26mm (wide), 1.4µm, dual pixel PDAF, OIS, 12 MP, f/2.4, 120˚, 13mm (ultrawide), 1/3.6\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512 GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3687 mAh, sạc nhanh 20W", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fthongsokythuat.vn%2Fsp%2Fapple-iphone-12-pro-max-2020%2F&psig=AOvVaw1Ri8j6DcVQhlLXSJA7SAyv&ust=1693640176861000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCPjZ4brziIEDFQAAAAAdAAAAABAD", 15000000m, "Iphone 12Pro Max", 20 },
                    { 7, "IP", "• Màn hình: OLED6.1″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3240 mAh, sạc nhanh 20W", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Ftintuc.hoanghamobile.com%2Ftin-tuc%2Fthong-tin-iphone-13-series&psig=AOvVaw12fJ1evbY7wDFnRqvrnoP3&ust=1693641358824000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCMD4jO73iIEDFQAAAAAdAAAAABAD", 15500000m, "Iphone 13", 20 },
                    { 8, "IP", "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 256GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 4352 mAh, sạc nhanh 20W", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fmacbookgiasi.vn%2Fnhung-dieu-can-biet-ve-iphone-13-pro-va-iphone-13-pro-max%2F&psig=AOvVaw12fJ1evbY7wDFnRqvrnoP3&ust=1693641358824000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCMD4jO73iIEDFQAAAAAdAAAAABAI", 19000000m, "Iphone 13Pro Max", 20 },
                    { 9, "OP", "Màn hình: 6.56\", IPS LCD, HD+\r\nCamera Trước: 8 MP ,Sau: Chính 13 MP\r\nHệ Điều Hành:Android 12 ,Chip : MediaTek Helio G35\r\nRam: 8GB, Rom: 128GB\r\nPin: (5000 mAh) ,Sạc nhanh 33W", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fdienmaycholon.vn%2Fdien-thoai-di-dong%2Foppo-a57-4128gb&psig=AOvVaw17cVnrvyoPJXm-R5-DIIzc&ust=1693641729907000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCPDW8575iIEDFQAAAAAdAAAAABAD", 4129000m, "Oppo A57", 20 },
                    { 10, "OP", "Màn hình: 6.59\",  PS LCD, HD+ \r\nCamera Trước: 16 MP ,Sau: Chính 50 MP \r\nHệ Điều Hành:Android 11\r\nChip: Snapdragon 680\r\nRam: 8GB, Rom: 128GB\r\nPin: (5000 mAh), Sạc nhanh 33W", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fwww.thegioididong.com%2Fdtdd%2Foppo-a96-4g&psig=AOvVaw2SplXWYL7KF4zBv7hxLl4D&ust=1693641845410000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCJjP5dX5iIEDFQAAAAAdAAAAABAD", 5790000m, "Oppo A96", 20 },
                    { 11, "AP", "Apple Watch SE 40mm viền nhôm dây silicone có thiết kế hết sức năng động và trẻ trung. Khung viền của đồng hồ được làm từ nhôm với các cạnh được bo góc hoàn hảo. Đồng hồ sở hữu mặt kính cấu tạo từ Ion-X strengthened glass tạo lực tốt hơn những loại kính thông thường vừa tăng sự sang trọng vừa tạo độ bền bỉ chắc chắn. ", "https://cdn11.dienmaycholon.vn/filewebdmclnew/DMCL21/Picture//Apro/Apro_product_31747/apple-watch-se-_main_442_1020.png.webp", 5000000m, "Apple Watch SE 2022", 20 },
                    { 12, "SS", "Camera 13 MP/13 MP, OS: Android 7.0 (Nougat)\r\nBộ nhớ trong 32BG / Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1080 x 1920 pixels\r\n4G LTE / Wifi / Cảm biến vân tay\r\nCPU Exynos 7870 Octa-core 1.6 GHz Cortex-A53\r\nPin Li-Ion 3600 mAh", "https://ibuyonline.vn/wp-content/uploads/2018/04/dien-thoai-samsung-galaxy-j7-pro-5.png", 4190000m, "Samsung Galaxy J7 Pro", 20 },
                    { 13, "SS", "CPU Exynos 7880 8 nhân (8×1.9 GHz) Cortex-A53\r\nRAM 3GB/ Android 7.0 >>\r\nBộ nhớ trong 32GB/ Khe cắm thẻ nhớ ngoài tối đa 256GB\r\nMàn hình Supper Amoled 5.2 inches 1080 x 1920 pixels\r\nChức năng: 2 SIM/Wifi/3G/Bluetooth/GPS, cảm biến vân tay…\r\nPin Li-Po 3500 mAh/ Camera 16Mp/16Mp", "https://ibuyonline.vn/wp-content/uploads/2017/11/dien-thoai-samsung-galaxy-a5-2017-1.png", 4590000m, "Samsung Galaxy A5 2017", 20 },
                    { 14, "SS", "Camera 12Mp/5Mp, OS: Android 6.0 Marshmallow\r\nBộ nhớ trong 32BG/Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1440x2560px\r\n4G LTE/Wifi\r\nCPU Exynos 8890 Octa-core (4×2.3 GHz Mongoose & 4×1.6 GHz Cortex-A53)\r\nPin 3000mAh", "https://ibuyonline.vn/wp-content/uploads/2017/05/dien-thoai-samsung-galaxy-s7-1.jpg", 5900000m, "Samsung Galaxy S7", 20 },
                    { 15, "SS", "Camera 12Mp/5Mp, OS: Android 6.0 Marshmallow\r\nBộ nhớ trong 32BG/Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1440x2560px\r\n4G LTE/Wifi\r\nCPU Exynos 8890 Octa-core (4×2.3 GHz Mongoose & 4×1.6 GHz Cortex-A53)\r\nPin 3000mAh", "https://ibuyonline.vn/wp-content/uploads/2017/05/dien-thoai-samsung-galaxy-s7-1.jpg", 5900000m, "Samsung Galaxy S7", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);
        }
    }
}

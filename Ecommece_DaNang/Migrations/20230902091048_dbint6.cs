using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbint6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "CateProduct",
                columns: new[] { "CateID", "CateName" },
                values: new object[] { "IPA", "IPad" });

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
                columns: new[] { "CateId", "Description", "Image", "ProductName" },
                values: new object[] { "IP", "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n3 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A15 Bionic\r\nRAM:\r\n\r\n6 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n3095 mAh20 W", "https://truesmart.com.vn/wp-content/uploads/iphone-13-pro-128gb-quoc-te-new-p9745.jpg", "Iphone 13Pro" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "IP", "Màn hình:\r\n\r\nOLED6.7\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 16\r\nCamera sau:\r\n\r\nChính 48 MP & Phụ 12 MP, 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A16 Bionic\r\nRAM:\r\n\r\n6 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n4323 mAh20 W", "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2023/2/14/1147651/Screen-Shot-2023-02--01.jpg", 16000000m, "Iphone 14" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "AP", "Màn hình:\r\n\r\nOLED\r\nThời lượng pin:\r\n\r\nKhoảng 18 giờ (ở chế độ sử dụng thông thường)Khoảng 1.5 ngày (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nIon-X strengthened glass44 mm\r\nTính năng cho sức khỏe:\r\n\r\nTheo dõi mức độ stressTính quãng đường chạyĐếm số bước chânTheo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụTheo dõi chu kỳ kinh nguyệtChế độ luyện tậpCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpGửi thông báo khi có tai nạn\r\nHãng\r\n\r\nApple", "https://cdn.tgdd.vn/Products/Images/7077/289798/apple-watch-se-2022-44mm-vien-nhom-den-xanh-1.jpg", 6790000m, "Apple Watch SE 2022 GPS" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "AP", "Màn hình:\r\n\r\nOLED1.9 inch\r\nThời lượng pin:\r\n\r\nKhoảng 18 giờ (ở chế độ sử dụng thông thường)Khoảng 1.5 ngày (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nIon-X strengthened glass45 mm\r\nTính năng cho sức khỏe:\r\n\r\nTheo dõi mức độ stressTính quãng đường chạyĐiện tâm đồĐo nồng độ oxy (SpO2)Theo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụĐếm số bước chânĐo lượng tiêu thụ oxy tối đa (VO2 Max)Theo dõi chu kỳ kinh nguyệtChấm điểm giấc ngủCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpƯớc tính ngày rụng trứng\r\nHãng\r\n\r\nApple", "https://cdn.tgdd.vn/Products/Images/7077/289825/Slider/vi-vn-apple-watch-s8-lte-45mm-(8).jpg", 12490000m, "Apple Watch S8 LTE" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "AP", "Màn hình:\r\n\r\nOLED1.92 inch\r\nThời lượng pin:\r\n\r\nKhoảng 36 giờ (ở chế độ sử dụng thông thường)Khoảng 60 giờ (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nKính Sapphire49 mm\r\nTính năng cho sức khỏe:\r\n\r\nTính quãng đường chạyĐiện tâm đồĐếm số bước chânĐo nồng độ oxy (SpO2)Theo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụTheo dõi chu kỳ kinh nguyệtChấm điểm giấc ngủCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpGửi thông báo khi có tai nạnƯớc tính ngày rụng trứng\r\nHãng\r\n\r\nApple", "https://cdn.tgdd.vn/Products/Images/7077/289814/Slider/apple-watch-ultra-alpine-m637985871601777347.jpg", 19490000m, "Apple Watch Ultra LTE" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "IPA", "Màn hình:\r\n\r\n10.9\"Retina IPS LCD\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nKết nối:\r\n\r\nNghe gọi qua FaceTime\r\nCamera sau:\r\n\r\n12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.6 Wh (~ 7587 mAh)20 W", "https://cdn.tgdd.vn/Products/Images/522/248096/Slider/ipad-air-5637867629018282670.jpg", 14090000m, " iPad Air 5 M1" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CateId", "Description", "Image", "Price", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 16, "IPA", "Màn hình:\r\n\r\n11\"Liquid Retina\r\nHệ điều hành:\r\n\r\niPadOS 16\r\nChip:\r\n\r\nApple M2 8 nhân\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM hoặc 1 eSIM\r\nCamera sau:\r\n\r\nChính 12 MP & Phụ 10 MP, TOF 3D LiDAR\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.65 Wh (~ 7538 mAh)20 W", "https://cdn.tgdd.vn/Products/Images/522/295458/Slider/ipad-pro-m2-11-inch-wifi-cellular-128gb638030918788729407.jpg", 23900000m, " iPad Pro M2 ", 20 },
                    { 17, "IPA", "Màn hình:\r\n\r\n11\"Liquid Retina\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n16 GB\r\nDung lượng lưu trữ:\r\n\r\n2 TB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM hoặc 1 eSIM\r\nCamera sau:\r\n\r\nChính 12 MP & Phụ 10 MP, TOF 3D LiDAR\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.65 Wh (~ 7538 mAh)20 W", "https://cdn.tgdd.vn/Products/Images/522/269330/Slider/vi-vn-ipad-pro-m1-11-inch-wifi-cellular-2tb-2021-1.jpeg", 51000000m, "iPad Pro M1", 20 },
                    { 18, "IPA", "Màn hình:\r\n\r\n10.9\"Retina IPS LCD\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIM\r\nCamera sau:\r\n\r\n12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.6 Wh (~ 7587 mAh)20 W", "https://cdn.tgdd.vn/Products/Images/522/274155/Slider/ipad-air-5-m1-wifi-cellular-64gb637867631880933424.jpg", 17490000m, "iPad Air 5", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "IPA");

            migrationBuilder.InsertData(
                table: "CateProduct",
                columns: new[] { "CateID", "CateName" },
                values: new object[,]
                {
                    { "LG", "LG" },
                    { "OP", "Oppo" },
                    { "PC", "PoCo" },
                    { "SS", "Sam Sung" }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fhitaothom.com%2Fsan-pham%2Fiphone-x-lock%2F&psig=AOvVaw3UDdvSAkSnhpWbA_ofkpNv&ust=1693639686996000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDbkdHxiIEDFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Freviews.com.np%2Fproduct%2Fiphone-xs-max&psig=AOvVaw1ZwmAu-TBv0rotCHroPVuM&ust=1693639736810000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCLCS2enxiIEDFQAAAAAdAAAAABAc");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fthongsokythuat.vn%2Fsp%2Fapple-iphone-11-2019%2F&psig=AOvVaw3PvYf7rJ0RCxZd-qfJQ5IN&ust=1693639921414000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCKDInMLyiIEDFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fchmobile.vn%2Fproducts%2Fiphone-11-pro-max-vang-gold&psig=AOvVaw3PvYf7rJ0RCxZd-qfJQ5IN&ust=1693639921414000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCKDInMLyiIEDFQAAAAAdAAAAABAI");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fdidongthongminh.vn%2Fiphone-12-pro-128gb-chinh-hang-vna&psig=AOvVaw1WuNmqS0r9I5GMkyBxo6a-&ust=1693640098755000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCLjyoZzziIEDFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fthongsokythuat.vn%2Fsp%2Fapple-iphone-12-pro-max-2020%2F&psig=AOvVaw1Ri8j6DcVQhlLXSJA7SAyv&ust=1693640176861000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCPjZ4brziIEDFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Ftintuc.hoanghamobile.com%2Ftin-tuc%2Fthong-tin-iphone-13-series&psig=AOvVaw12fJ1evbY7wDFnRqvrnoP3&ust=1693641358824000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCMD4jO73iIEDFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Image",
                value: "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fmacbookgiasi.vn%2Fnhung-dieu-can-biet-ve-iphone-13-pro-va-iphone-13-pro-max%2F&psig=AOvVaw12fJ1evbY7wDFnRqvrnoP3&ust=1693641358824000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCMD4jO73iIEDFQAAAAAdAAAAABAI");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CateId", "Description", "Image", "ProductName" },
                values: new object[] { "OP", "Màn hình: 6.56\", IPS LCD, HD+\r\nCamera Trước: 8 MP ,Sau: Chính 13 MP\r\nHệ Điều Hành:Android 12 ,Chip : MediaTek Helio G35\r\nRam: 8GB, Rom: 128GB\r\nPin: (5000 mAh) ,Sạc nhanh 33W", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fdienmaycholon.vn%2Fdien-thoai-di-dong%2Foppo-a57-4128gb&psig=AOvVaw17cVnrvyoPJXm-R5-DIIzc&ust=1693641729907000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCPDW8575iIEDFQAAAAAdAAAAABAD", "Oppo A57" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "OP", "Màn hình: 6.59\",  PS LCD, HD+ \r\nCamera Trước: 16 MP ,Sau: Chính 50 MP \r\nHệ Điều Hành:Android 11\r\nChip: Snapdragon 680\r\nRam: 8GB, Rom: 128GB\r\nPin: (5000 mAh), Sạc nhanh 33W", "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fwww.thegioididong.com%2Fdtdd%2Foppo-a96-4g&psig=AOvVaw2SplXWYL7KF4zBv7hxLl4D&ust=1693641845410000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCJjP5dX5iIEDFQAAAAAdAAAAABAD", 5790000m, "Oppo A96" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "SS", "Camera 13 MP/13 MP, OS: Android 7.0 (Nougat)\r\nBộ nhớ trong 32BG / Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1080 x 1920 pixels\r\n4G LTE / Wifi / Cảm biến vân tay\r\nCPU Exynos 7870 Octa-core 1.6 GHz Cortex-A53\r\nPin Li-Ion 3600 mAh", "https://ibuyonline.vn/wp-content/uploads/2018/04/dien-thoai-samsung-galaxy-j7-pro-5.png", 4190000m, "Samsung Galaxy J7 Pro" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "SS", "CPU Exynos 7880 8 nhân (8×1.9 GHz) Cortex-A53\r\nRAM 3GB/ Android 7.0 >>\r\nBộ nhớ trong 32GB/ Khe cắm thẻ nhớ ngoài tối đa 256GB\r\nMàn hình Supper Amoled 5.2 inches 1080 x 1920 pixels\r\nChức năng: 2 SIM/Wifi/3G/Bluetooth/GPS, cảm biến vân tay…\r\nPin Li-Po 3500 mAh/ Camera 16Mp/16Mp", "https://ibuyonline.vn/wp-content/uploads/2017/11/dien-thoai-samsung-galaxy-a5-2017-1.png", 4590000m, "Samsung Galaxy A5 2017" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "SS", "Camera 12Mp/5Mp, OS: Android 6.0 Marshmallow\r\nBộ nhớ trong 32BG/Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1440x2560px\r\n4G LTE/Wifi\r\nCPU Exynos 8890 Octa-core (4×2.3 GHz Mongoose & 4×1.6 GHz Cortex-A53)\r\nPin 3000mAh", "https://ibuyonline.vn/wp-content/uploads/2017/05/dien-thoai-samsung-galaxy-s7-1.jpg", 5900000m, "Samsung Galaxy S7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CateId", "Description", "Image", "Price", "ProductName" },
                values: new object[] { "SS", "Camera 12Mp/5Mp, OS: Android 6.0 Marshmallow\r\nBộ nhớ trong 32BG/Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1440x2560px\r\n4G LTE/Wifi\r\nCPU Exynos 8890 Octa-core (4×2.3 GHz Mongoose & 4×1.6 GHz Cortex-A53)\r\nPin 3000mAh", "https://ibuyonline.vn/wp-content/uploads/2017/05/dien-thoai-samsung-galaxy-s7-1.jpg", 5900000m, "Samsung Galaxy S7" });
        }
    }
}

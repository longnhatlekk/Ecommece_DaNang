﻿// <auto-generated />
using System;
using Ecommece_DaNang.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommece_DaNang.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20230902151150_dbint8")]
    partial class dbint8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommece_DaNang.Entity.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CardId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Card", (string)null);
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.CateProduct", b =>
                {
                    b.Property<string>("CateID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CateName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CateID");

                    b.ToTable("CateProduct", (string)null);

                    b.HasData(
                        new
                        {
                            CateID = "IP",
                            CateName = "Iphone"
                        },
                        new
                        {
                            CateID = "IPA",
                            CateName = "IPad"
                        },
                        new
                        {
                            CateID = "AP",
                            CateName = "Apple Watch"
                        });
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.ProductOption", b =>
                {
                    b.Property<int>("productOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productOptionId"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("productOptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productOptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOption", (string)null);

                    b.HasData(
                        new
                        {
                            productOptionId = 1,
                            Price = 5000000m,
                            ProductId = 1,
                            productOptionName = "64GB"
                        },
                        new
                        {
                            productOptionId = 2,
                            Price = 5500000m,
                            ProductId = 1,
                            productOptionName = "256GB"
                        });
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CateId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CateId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CateId = "IP",
                            Description = "• Màn hình: OLED5.8″Super Retina\r\n\r\n• Hệ điều hành: iOS 12\r\n\r\n• Camera sau: 12 MP\r\n\r\n• Camera trước: 7 MP\r\n\r\n• Chip: Apple A11 Bionic\r\n\r\n• RAM: 3 GB\r\n\r\n• Bộ nhớ trong: 64 GB\r\n\r\n• SIM: 1 Nano SIM\r\n\r\n• Pin: 2716 mAh, công nghệ sạc không dây Qi và công nghệ sạc nhanh 15W\r\n\r\n• Chuẩn chống nước và chống bụi IP67",
                            Image = "https://cellbuddy.in/buddy/wp-content/uploads/2022/09/X-Space-grey-2.png",
                            Price = 5000000m,
                            ProductName = "Iphone x",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 2,
                            CateId = "IP",
                            Description = "• Màn hình: OLED5.8″ Super Retina, 1125 x 2436 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 12, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP\r\n\r\n• Camera trước: Dual 7 MP\r\n\r\n• Chip: Apple A12 Bionic (7 nm)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 512 GB\r\n\r\n• SIM: 2 sim gồm nano SIM và e-Sim\r\n\r\n• Pin: 2658 mAh, hỗ trợ sạc nhanh 15W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Xám đen, Vàng hồng, Trắng bạc",
                            Image = "https://theedgestores.com/wp-content/uploads/2021/12/refurb-iphone-xs-gold-1-3.jpeg",
                            Price = 6000000m,
                            ProductName = "Iphone xs",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 3,
                            CateId = "IP",
                            Description = "• Màn hình: Liquid Retina IPS LCD, 625 nits (typ), 6.1 inches, 828 x 1792 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP, 13mm (ultrawide), 1/3.6″\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 256 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3110 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Black (đen), Green (xanh mint), Yellow (vàng đồng), Purple (tím), Red (đỏ), White (trắng)",
                            Image = "https://product.hstatic.net/200000348419/product/iphone_11_be5db75904c5439c8718ca264a91ea71_master.png",
                            Price = 6500000m,
                            ProductName = "Iphone 11",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 4,
                            CateId = "IP",
                            Description = "• Màn hình: Super Retina XDR OLED, HDR10, 6.5 inches, 1242 x 2688 pixels\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Bộ 3 camera đầu tiên 12 MP\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 64 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3969 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Matte Space Gray (Xám Đen), Matte Silver (Xám bạc), Matte Gold (Đồng), Matte Midnight Green (Xanh Lá Mạ)",
                            Image = "https://tabletplaza.vn/images/mau-ip-11-pro-max.jpg?1654154298046",
                            Price = 12000000m,
                            ProductName = "Iphone 11pro Max",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 5,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.1″ “Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 3 camera 12 MP\r\n\r\n• Camera trước: 12 MP, f/2.2, 23mm (wide), 1/3.6” SL 3D, (depth/biometrics sensor)\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 2815 mAh, 20 W\r\n\r\n• Kích thước 146.7 x 71.5 x 7.4 mm",
                            Image = "https://truesmart.com.vn/wp-content/uploads/iphone-12-pro-256gb-quoc-te-chinh-hang-cu-p10049.jpg",
                            Price = 12500000m,
                            ProductName = "Iphone 12Pro",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 6,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 12 MP, f/2.2, 23mm (wide), 1/3.6\r\n\r\n• Camera trước: 12 MP, f/1.6, 26mm (wide), 1.4µm, dual pixel PDAF, OIS, 12 MP, f/2.4, 120˚, 13mm (ultrawide), 1/3.6\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512 GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3687 mAh, sạc nhanh 20W",
                            Image = "https://mobileworld.com.vn/uploads/product/brand/iphone-12-pro-max-mobileworld.jpg",
                            Price = 15000000m,
                            ProductName = "Iphone 12Pro Max",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 7,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.1″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3240 mAh, sạc nhanh 20W",
                            Image = "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_iphone13_hero_09142021_inline.jpg.slideshow-xlarge_2x.jpg",
                            Price = 15500000m,
                            ProductName = "Iphone 13",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 8,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 256GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 4352 mAh, sạc nhanh 20W",
                            Image = "https://thanhmobile.vn/uploads/plugin/product_items/896/iphone-13-pro-max-256gb-2.jpg",
                            Price = 19000000m,
                            ProductName = "Iphone 13Pro Max",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 9,
                            CateId = "IP",
                            Description = "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n3 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A15 Bionic\r\nRAM:\r\n\r\n6 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n3095 mAh20 W",
                            Image = "https://truesmart.com.vn/wp-content/uploads/iphone-13-pro-128gb-quoc-te-new-p9745.jpg",
                            Price = 4129000m,
                            ProductName = "Iphone 13Pro",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 10,
                            CateId = "IP",
                            Description = "Màn hình:\r\n\r\nOLED6.7\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 16\r\nCamera sau:\r\n\r\nChính 48 MP & Phụ 12 MP, 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A16 Bionic\r\nRAM:\r\n\r\n6 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n4323 mAh20 W",
                            Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2023/2/14/1147651/Screen-Shot-2023-02--01.jpg",
                            Price = 16000000m,
                            ProductName = "Iphone 14",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 11,
                            CateId = "AP",
                            Description = "Apple Watch SE 40mm viền nhôm dây silicone có thiết kế hết sức năng động và trẻ trung. Khung viền của đồng hồ được làm từ nhôm với các cạnh được bo góc hoàn hảo. Đồng hồ sở hữu mặt kính cấu tạo từ Ion-X strengthened glass tạo lực tốt hơn những loại kính thông thường vừa tăng sự sang trọng vừa tạo độ bền bỉ chắc chắn. ",
                            Image = "https://cdn11.dienmaycholon.vn/filewebdmclnew/DMCL21/Picture//Apro/Apro_product_31747/apple-watch-se-_main_442_1020.png.webp",
                            Price = 5000000m,
                            ProductName = "Apple Watch SE 2022",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 12,
                            CateId = "AP",
                            Description = "Màn hình:\r\n\r\nOLED\r\nThời lượng pin:\r\n\r\nKhoảng 18 giờ (ở chế độ sử dụng thông thường)Khoảng 1.5 ngày (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nIon-X strengthened glass44 mm\r\nTính năng cho sức khỏe:\r\n\r\nTheo dõi mức độ stressTính quãng đường chạyĐếm số bước chânTheo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụTheo dõi chu kỳ kinh nguyệtChế độ luyện tậpCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpGửi thông báo khi có tai nạn\r\nHãng\r\n\r\nApple",
                            Image = "https://cdn.tgdd.vn/Products/Images/7077/289798/apple-watch-se-2022-44mm-vien-nhom-den-xanh-1.jpg",
                            Price = 6790000m,
                            ProductName = "Apple Watch SE 2022 GPS",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 13,
                            CateId = "AP",
                            Description = "Màn hình:\r\n\r\nOLED1.9 inch\r\nThời lượng pin:\r\n\r\nKhoảng 18 giờ (ở chế độ sử dụng thông thường)Khoảng 1.5 ngày (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nIon-X strengthened glass45 mm\r\nTính năng cho sức khỏe:\r\n\r\nTheo dõi mức độ stressTính quãng đường chạyĐiện tâm đồĐo nồng độ oxy (SpO2)Theo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụĐếm số bước chânĐo lượng tiêu thụ oxy tối đa (VO2 Max)Theo dõi chu kỳ kinh nguyệtChấm điểm giấc ngủCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpƯớc tính ngày rụng trứng\r\nHãng\r\n\r\nApple",
                            Image = "https://cdn.tgdd.vn/Products/Images/7077/289825/Slider/vi-vn-apple-watch-s8-lte-45mm-(8).jpg",
                            Price = 12490000m,
                            ProductName = "Apple Watch S8 LTE",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 14,
                            CateId = "AP",
                            Description = "Màn hình:\r\n\r\nOLED1.92 inch\r\nThời lượng pin:\r\n\r\nKhoảng 36 giờ (ở chế độ sử dụng thông thường)Khoảng 60 giờ (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nKính Sapphire49 mm\r\nTính năng cho sức khỏe:\r\n\r\nTính quãng đường chạyĐiện tâm đồĐếm số bước chânĐo nồng độ oxy (SpO2)Theo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụTheo dõi chu kỳ kinh nguyệtChấm điểm giấc ngủCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpGửi thông báo khi có tai nạnƯớc tính ngày rụng trứng\r\nHãng\r\n\r\nApple",
                            Image = "https://cdn.tgdd.vn/Products/Images/7077/289814/Slider/apple-watch-ultra-alpine-m637985871601777347.jpg",
                            Price = 19490000m,
                            ProductName = "Apple Watch Ultra LTE",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 15,
                            CateId = "IPA",
                            Description = "Màn hình:\r\n\r\n10.9\"Retina IPS LCD\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nKết nối:\r\n\r\nNghe gọi qua FaceTime\r\nCamera sau:\r\n\r\n12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.6 Wh (~ 7587 mAh)20 W",
                            Image = "https://cdn.tgdd.vn/Products/Images/522/248096/Slider/ipad-air-5637867629018282670.jpg",
                            Price = 14090000m,
                            ProductName = " iPad Air 5 M1",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 16,
                            CateId = "IPA",
                            Description = "Màn hình:\r\n\r\n11\"Liquid Retina\r\nHệ điều hành:\r\n\r\niPadOS 16\r\nChip:\r\n\r\nApple M2 8 nhân\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM hoặc 1 eSIM\r\nCamera sau:\r\n\r\nChính 12 MP & Phụ 10 MP, TOF 3D LiDAR\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.65 Wh (~ 7538 mAh)20 W",
                            Image = "https://cdn.tgdd.vn/Products/Images/522/295458/Slider/ipad-pro-m2-11-inch-wifi-cellular-128gb638030918788729407.jpg",
                            Price = 23900000m,
                            ProductName = " iPad Pro M2 ",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 17,
                            CateId = "IPA",
                            Description = "Màn hình:\r\n\r\n11\"Liquid Retina\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n16 GB\r\nDung lượng lưu trữ:\r\n\r\n2 TB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM hoặc 1 eSIM\r\nCamera sau:\r\n\r\nChính 12 MP & Phụ 10 MP, TOF 3D LiDAR\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.65 Wh (~ 7538 mAh)20 W",
                            Image = "https://cdn.tgdd.vn/Products/Images/522/269330/Slider/vi-vn-ipad-pro-m1-11-inch-wifi-cellular-2tb-2021-1.jpeg",
                            Price = 51000000m,
                            ProductName = "iPad Pro M1",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 18,
                            CateId = "IPA",
                            Description = "Màn hình:\r\n\r\n10.9\"Retina IPS LCD\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIM\r\nCamera sau:\r\n\r\n12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.6 Wh (~ 7587 mAh)20 W",
                            Image = "https://cdn.tgdd.vn/Products/Images/522/274155/Slider/ipad-air-5-m1-wifi-cellular-64gb637867631880933424.jpg",
                            Price = 17490000m,
                            ProductName = "iPad Air 5",
                            Quantity = 20
                        });
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Role", b =>
                {
                    b.Property<string>("RoleID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("RoleID");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            RoleID = "US",
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Card", b =>
                {
                    b.HasOne("Ecommece_DaNang.Entity.Products", "product")
                        .WithMany("card")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommece_DaNang.Entity.Users", "user")
                        .WithMany("card")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.ProductOption", b =>
                {
                    b.HasOne("Ecommece_DaNang.Entity.Products", "products")
                        .WithMany("ProductOptions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Products", b =>
                {
                    b.HasOne("Ecommece_DaNang.Entity.CateProduct", "cateProduct")
                        .WithMany("products")
                        .HasForeignKey("CateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cateProduct");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Users", b =>
                {
                    b.HasOne("Ecommece_DaNang.Entity.Role", "role")
                        .WithMany("user")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.CateProduct", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Products", b =>
                {
                    b.Navigation("ProductOptions");

                    b.Navigation("card");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Role", b =>
                {
                    b.Navigation("user");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Users", b =>
                {
                    b.Navigation("card");
                });
#pragma warning restore 612, 618
        }
    }
}

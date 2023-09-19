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
    [Migration("20230901094137_dbinit4")]
    partial class dbinit4
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
                            CateID = "SS",
                            CateName = "Sam Sung"
                        },
                        new
                        {
                            CateID = "PC",
                            CateName = "PoCo"
                        },
                        new
                        {
                            CateID = "LG",
                            CateName = "LG"
                        },
                        new
                        {
                            CateID = "OP",
                            CateName = "Oppo"
                        },
                        new
                        {
                            CateID = "AP",
                            CateName = "Apple Watch"
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
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fhitaothom.com%2Fsan-pham%2Fiphone-x-lock%2F&psig=AOvVaw3UDdvSAkSnhpWbA_ofkpNv&ust=1693639686996000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDbkdHxiIEDFQAAAAAdAAAAABAD",
                            Price = 5000000m,
                            ProductName = "Iphone x",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 2,
                            CateId = "IP",
                            Description = "• Màn hình: OLED5.8″ Super Retina, 1125 x 2436 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 12, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP\r\n\r\n• Camera trước: Dual 7 MP\r\n\r\n• Chip: Apple A12 Bionic (7 nm)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 512 GB\r\n\r\n• SIM: 2 sim gồm nano SIM và e-Sim\r\n\r\n• Pin: 2658 mAh, hỗ trợ sạc nhanh 15W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Xám đen, Vàng hồng, Trắng bạc",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Freviews.com.np%2Fproduct%2Fiphone-xs-max&psig=AOvVaw1ZwmAu-TBv0rotCHroPVuM&ust=1693639736810000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCLCS2enxiIEDFQAAAAAdAAAAABAc",
                            Price = 6000000m,
                            ProductName = "Iphone xs",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 3,
                            CateId = "IP",
                            Description = "• Màn hình: Liquid Retina IPS LCD, 625 nits (typ), 6.1 inches, 828 x 1792 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP, 13mm (ultrawide), 1/3.6″\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 256 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3110 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Black (đen), Green (xanh mint), Yellow (vàng đồng), Purple (tím), Red (đỏ), White (trắng)",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fthongsokythuat.vn%2Fsp%2Fapple-iphone-11-2019%2F&psig=AOvVaw3PvYf7rJ0RCxZd-qfJQ5IN&ust=1693639921414000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCKDInMLyiIEDFQAAAAAdAAAAABAD",
                            Price = 6500000m,
                            ProductName = "Iphone 11",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 4,
                            CateId = "IP",
                            Description = "• Màn hình: Super Retina XDR OLED, HDR10, 6.5 inches, 1242 x 2688 pixels\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Bộ 3 camera đầu tiên 12 MP\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 64 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3969 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Matte Space Gray (Xám Đen), Matte Silver (Xám bạc), Matte Gold (Đồng), Matte Midnight Green (Xanh Lá Mạ)",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fchmobile.vn%2Fproducts%2Fiphone-11-pro-max-vang-gold&psig=AOvVaw3PvYf7rJ0RCxZd-qfJQ5IN&ust=1693639921414000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCKDInMLyiIEDFQAAAAAdAAAAABAI",
                            Price = 12000000m,
                            ProductName = "Iphone 11pro Max",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 5,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.1″ “Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 3 camera 12 MP\r\n\r\n• Camera trước: 12 MP, f/2.2, 23mm (wide), 1/3.6” SL 3D, (depth/biometrics sensor)\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 2815 mAh, 20 W\r\n\r\n• Kích thước 146.7 x 71.5 x 7.4 mm",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fdidongthongminh.vn%2Fiphone-12-pro-128gb-chinh-hang-vna&psig=AOvVaw1WuNmqS0r9I5GMkyBxo6a-&ust=1693640098755000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCLjyoZzziIEDFQAAAAAdAAAAABAE",
                            Price = 12500000m,
                            ProductName = "Iphone 12Pro",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 6,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 12 MP, f/2.2, 23mm (wide), 1/3.6\r\n\r\n• Camera trước: 12 MP, f/1.6, 26mm (wide), 1.4µm, dual pixel PDAF, OIS, 12 MP, f/2.4, 120˚, 13mm (ultrawide), 1/3.6\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512 GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3687 mAh, sạc nhanh 20W",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fthongsokythuat.vn%2Fsp%2Fapple-iphone-12-pro-max-2020%2F&psig=AOvVaw1Ri8j6DcVQhlLXSJA7SAyv&ust=1693640176861000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCPjZ4brziIEDFQAAAAAdAAAAABAD",
                            Price = 15000000m,
                            ProductName = "Iphone 12Pro Max",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 7,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.1″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3240 mAh, sạc nhanh 20W",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Ftintuc.hoanghamobile.com%2Ftin-tuc%2Fthong-tin-iphone-13-series&psig=AOvVaw12fJ1evbY7wDFnRqvrnoP3&ust=1693641358824000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCMD4jO73iIEDFQAAAAAdAAAAABAD",
                            Price = 15500000m,
                            ProductName = "Iphone 13",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 8,
                            CateId = "IP",
                            Description = "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 256GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 4352 mAh, sạc nhanh 20W",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fmacbookgiasi.vn%2Fnhung-dieu-can-biet-ve-iphone-13-pro-va-iphone-13-pro-max%2F&psig=AOvVaw12fJ1evbY7wDFnRqvrnoP3&ust=1693641358824000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCMD4jO73iIEDFQAAAAAdAAAAABAI",
                            Price = 19000000m,
                            ProductName = "Iphone 13Pro Max",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 9,
                            CateId = "OP",
                            Description = "Màn hình: 6.56\", IPS LCD, HD+\r\nCamera Trước: 8 MP ,Sau: Chính 13 MP\r\nHệ Điều Hành:Android 12 ,Chip : MediaTek Helio G35\r\nRam: 8GB, Rom: 128GB\r\nPin: (5000 mAh) ,Sạc nhanh 33W",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fdienmaycholon.vn%2Fdien-thoai-di-dong%2Foppo-a57-4128gb&psig=AOvVaw17cVnrvyoPJXm-R5-DIIzc&ust=1693641729907000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCPDW8575iIEDFQAAAAAdAAAAABAD",
                            Price = 4129000m,
                            ProductName = "Oppo A57",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 10,
                            CateId = "OP",
                            Description = "Màn hình: 6.59\",  PS LCD, HD+ \r\nCamera Trước: 16 MP ,Sau: Chính 50 MP \r\nHệ Điều Hành:Android 11\r\nChip: Snapdragon 680\r\nRam: 8GB, Rom: 128GB\r\nPin: (5000 mAh), Sạc nhanh 33W",
                            Image = "https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Fwww.thegioididong.com%2Fdtdd%2Foppo-a96-4g&psig=AOvVaw2SplXWYL7KF4zBv7hxLl4D&ust=1693641845410000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCJjP5dX5iIEDFQAAAAAdAAAAABAD",
                            Price = 5790000m,
                            ProductName = "Oppo A96",
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
                            CateId = "SS",
                            Description = "Camera 13 MP/13 MP, OS: Android 7.0 (Nougat)\r\nBộ nhớ trong 32BG / Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1080 x 1920 pixels\r\n4G LTE / Wifi / Cảm biến vân tay\r\nCPU Exynos 7870 Octa-core 1.6 GHz Cortex-A53\r\nPin Li-Ion 3600 mAh",
                            Image = "https://ibuyonline.vn/wp-content/uploads/2018/04/dien-thoai-samsung-galaxy-j7-pro-5.png",
                            Price = 4190000m,
                            ProductName = "Samsung Galaxy J7 Pro",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 13,
                            CateId = "SS",
                            Description = "CPU Exynos 7880 8 nhân (8×1.9 GHz) Cortex-A53\r\nRAM 3GB/ Android 7.0 >>\r\nBộ nhớ trong 32GB/ Khe cắm thẻ nhớ ngoài tối đa 256GB\r\nMàn hình Supper Amoled 5.2 inches 1080 x 1920 pixels\r\nChức năng: 2 SIM/Wifi/3G/Bluetooth/GPS, cảm biến vân tay…\r\nPin Li-Po 3500 mAh/ Camera 16Mp/16Mp",
                            Image = "https://ibuyonline.vn/wp-content/uploads/2017/11/dien-thoai-samsung-galaxy-a5-2017-1.png",
                            Price = 4590000m,
                            ProductName = "Samsung Galaxy A5 2017",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 14,
                            CateId = "SS",
                            Description = "Camera 12Mp/5Mp, OS: Android 6.0 Marshmallow\r\nBộ nhớ trong 32BG/Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1440x2560px\r\n4G LTE/Wifi\r\nCPU Exynos 8890 Octa-core (4×2.3 GHz Mongoose & 4×1.6 GHz Cortex-A53)\r\nPin 3000mAh",
                            Image = "https://ibuyonline.vn/wp-content/uploads/2017/05/dien-thoai-samsung-galaxy-s7-1.jpg",
                            Price = 5900000m,
                            ProductName = "Samsung Galaxy S7",
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 15,
                            CateId = "SS",
                            Description = "Camera 12Mp/5Mp, OS: Android 6.0 Marshmallow\r\nBộ nhớ trong 32BG/Hỗ trợ thẻ nhớ microSD lên tới 256GB\r\nMàn hình Supper Amoled 5.5 inches 1440x2560px\r\n4G LTE/Wifi\r\nCPU Exynos 8890 Octa-core (4×2.3 GHz Mongoose & 4×1.6 GHz Cortex-A53)\r\nPin 3000mAh",
                            Image = "https://ibuyonline.vn/wp-content/uploads/2017/05/dien-thoai-samsung-galaxy-s7-1.jpg",
                            Price = 5900000m,
                            ProductName = "Samsung Galaxy S7",
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

            modelBuilder.Entity("Ecommece_DaNang.Entity.User", b =>
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

                    b.HasOne("Ecommece_DaNang.Entity.User", "user")
                        .WithMany("card")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");
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

            modelBuilder.Entity("Ecommece_DaNang.Entity.User", b =>
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
                    b.Navigation("card");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.Role", b =>
                {
                    b.Navigation("user");
                });

            modelBuilder.Entity("Ecommece_DaNang.Entity.User", b =>
                {
                    b.Navigation("card");
                });
#pragma warning restore 612, 618
        }
    }
}
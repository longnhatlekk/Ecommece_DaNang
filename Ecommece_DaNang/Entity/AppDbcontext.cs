using Microsoft.EntityFrameworkCore;

namespace Ecommece_DaNang.Entity
{
    public class AppDbcontext :DbContext
    {
        public AppDbcontext() { }
        public AppDbcontext(DbContextOptions<AppDbcontext> option) : base(option) { }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<CateProduct> CateProducts { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<ProductOption> productoptions { get; set; }
        public virtual DbSet<ImageProduct> ImageProducts { get;set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Paymentt> Payments { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:Dbcontext"];
            return strConn;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(u => u.UserId);
                entity.Property(u => u.UserName).HasMaxLength(20);
                entity.Property(u => u.Email).HasMaxLength(30);
                entity.Property(u => u.Password).HasMaxLength(30);

                entity.HasOne(u => u.role)
                .WithMany(u => u.user)
                .HasForeignKey(e => e.RoleId);
            });
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");
                entity.HasKey(u => u.RoleID);
                entity.Property(u => u.RoleName).HasMaxLength(10);
            });
            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card");
                entity.HasKey(u => u.CardId);

                entity.HasOne(u => u.user)
                .WithMany(u => u.card)
                .HasForeignKey(e => e.UserId);

                entity.HasOne(u => u.product)
                .WithMany(u => u.card)
                .HasForeignKey(e => e.ProductId);
                entity.HasOne(u => u.ProductOptions)
                .WithMany(u => u.cards)
                .HasForeignKey(e => e.ProductOptionID)
                .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(x => x.ImageProducts)
                .WithMany(x => x.cards)
                .HasForeignKey(x => x.ImageId)
                .OnDelete(DeleteBehavior.NoAction);

            });
            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(u => u.ProductId);
                entity.Property(u => u.ProductName).HasMaxLength(100);
                entity.Property(u => u.Description).HasMaxLength(1000);
                entity.Property(u => u.IsDeleted).HasDefaultValue(true);
                entity.HasOne(u => u.cateProduct)
                .WithMany(u => u.products)
                .HasForeignKey(e => e.CateId);
            });
            modelBuilder.Entity<CateProduct>(entity =>
            {
                entity.ToTable("CateProduct");
                entity.HasKey(u => u.CateID);
                entity.Property(u => u.CateName).HasMaxLength(30);

            });
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("Order");
                entity.HasKey(u => u.OrderId);
                entity.HasOne(u => u.Userss)
                .WithMany(u => u.Orders)
                .HasForeignKey(e => e.UserId)
                 .OnDelete(DeleteBehavior.NoAction); 

                entity.HasOne(u => u.Payments)
                .WithMany(u => u.Orders)
                .HasForeignKey(e => e.PaymentId)
                 .OnDelete(DeleteBehavior.NoAction); 
            });
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");
                entity.HasKey(u => u.OrderDetailId);
                entity.HasOne(u => u.Products)
                .WithMany(u => u.OrderDetails)
                .HasForeignKey(e => e.ProductId);
                entity.HasOne(u => u.Orders)
                .WithMany(u => u.OrderDetails)
                .HasForeignKey(e => e.OrderId);

                entity.HasOne(x => x.imageProduct)
                .WithMany(x => x.orderDetails)
                .HasForeignKey(x => x.ImageId)
                .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(u => u.productOption)
               .WithMany(u => u.orderDetails)
               .HasForeignKey(e => e.ProductOptionID)
               .OnDelete(DeleteBehavior.NoAction);



                

            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleID = "US",
                RoleName = "User"
            });
            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.ToTable("ProductOption");
                entity.HasKey(u => u.productOptionId);

                entity.HasOne(e => e.products)
                .WithMany(e => e.ProductOptions)
                .HasForeignKey(u => u.ProductId);
            });
            modelBuilder.Entity<ImageProduct>(entity =>
            {
                entity.ToTable("ImageProduct");
                entity.HasKey(u => u.ImageId);

                entity.HasOne(u => u.Products)
                .WithMany(u => u.ImageProducts)
                .HasForeignKey(e => e.ProductId);
            });
            modelBuilder.Entity<Paymentt>(entity =>
            {
                entity.ToTable("Payment");
                entity.HasKey(u => u.PaymentId);
                entity.HasOne(u => u.Users)
                .WithMany(u => u.Payments)
                .HasForeignKey(e => e.userID);

            });
            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.ToTable("RefreshToken");
                entity.HasKey(e => e.Id);
                entity.HasOne(u => u.User)
                .WithMany(u => u.refreshTokens)
                .HasForeignKey(e => e.UserId);
            });

            
            modelBuilder.Entity<CateProduct>().HasData(new CateProduct
            {
                CateID = "IP",
                CateName = "Iphone"
            },
            new CateProduct
            {
                CateID = "IPA",
                CateName = "IPad",
            },
            
            new CateProduct
            {
                CateID = "AP",
                CateName = "Apple Watch"
            }

            );
            modelBuilder.Entity<Products>().HasData(new Products
            {
                ProductId = 1,
                ProductName = "Iphone x",
                Description = "• Màn hình: OLED5.8″Super Retina\r\n\r\n• Hệ điều hành: iOS 12\r\n\r\n• Camera sau: 12 MP\r\n\r\n• Camera trước: 7 MP\r\n\r\n• Chip: Apple A11 Bionic\r\n\r\n• RAM: 3 GB\r\n\r\n• Bộ nhớ trong: 64 GB\r\n\r\n• SIM: 1 Nano SIM\r\n\r\n• Pin: 2716 mAh, công nghệ sạc không dây Qi và công nghệ sạc nhanh 15W\r\n\r\n• Chuẩn chống nước và chống bụi IP67",
                Quantity = 20,
                Price = 8000000,
               IsDeleted = true,
               Discount = 37,
               SoldPrice = 5000000,
                CateId = "IP"
            },
            new Products
            {
                ProductId = 2,
                ProductName = "Iphone xs",
                Description = "• Màn hình: OLED5.8″ Super Retina, 1125 x 2436 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 12, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP\r\n\r\n• Camera trước: Dual 7 MP\r\n\r\n• Chip: Apple A12 Bionic (7 nm)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 512 GB\r\n\r\n• SIM: 2 sim gồm nano SIM và e-Sim\r\n\r\n• Pin: 2658 mAh, hỗ trợ sạc nhanh 15W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Xám đen, Vàng hồng, Trắng bạc",
                Quantity = 20,
                Price = 9000000,
                IsDeleted = true,
                Discount = 30,
                SoldPrice = 6000000,
                CateId = "IP"
            }
            ,
            new Products
            {
                ProductId = 3,
                ProductName = "Iphone 11",
                Description = "• Màn hình: Liquid Retina IPS LCD, 625 nits (typ), 6.1 inches, 828 x 1792 pixels cùng 2 lớp kính cường lực\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Dual camera 12 MP, 13mm (ultrawide), 1/3.6″\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 256 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3110 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Black (đen), Green (xanh mint), Yellow (vàng đồng), Purple (tím), Red (đỏ), White (trắng)",
                Quantity = 20,
                Price = 1000000,
                IsDeleted = true,
                Discount = 30,
                SoldPrice = 7000000,
                CateId = "IP"
            },
            new Products
            {
                ProductId = 4,
                ProductName = "Iphone 11pro Max",
                Description = "• Màn hình: Super Retina XDR OLED, HDR10, 6.5 inches, 1242 x 2688 pixels\r\n\r\n• Hệ điều hành: iOS 13, có thể cập nhập lên\r\n\r\n• Camera sau: Bộ 3 camera đầu tiên 12 MP\r\n\r\n• Camera trước: Dual 12 MP, f/2.2, 23mm (wide), 1/3.6″\r\n\r\n• Chip: Apple A13 Bionic (7 nm+)\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ trong: 64 GB\r\n\r\n• SIM: nano SIM hoặc/và e-SIM\r\n\r\n• Pin: 3969 mAh, hỗ trợ sạc nhanh 18W, công nghệ sạc không dây Qi\r\n\r\n• Chuẩn chống nước và chống bụi IP 68\r\n\r\n• Màu sắc: Matte Space Gray (Xám Đen), Matte Silver (Xám bạc), Matte Gold (Đồng), Matte Midnight Green (Xanh Lá Mạ)",
                Quantity = 20,
                Price = 12000000,
                IsDeleted = true,
                Discount = 30,
                SoldPrice = 8400000,
                CateId = "IP"
            },
            new Products
            {
                ProductId = 5,
                ProductName = "Iphone 12Pro",
                Description = "• Màn hình: OLED6.1″ “Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 3 camera 12 MP\r\n\r\n• Camera trước: 12 MP, f/2.2, 23mm (wide), 1/3.6” SL 3D, (depth/biometrics sensor)\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 2815 mAh, 20 W\r\n\r\n• Kích thước 146.7 x 71.5 x 7.4 mm",
                Quantity = 20,
                Price = 14000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 12600000,
                CateId = "IP"
            },
            new Products
            {
                ProductId = 6,
                ProductName = "Iphone 12Pro Max",
                Description = "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 12 MP, f/2.2, 23mm (wide), 1/3.6\r\n\r\n• Camera trước: 12 MP, f/1.6, 26mm (wide), 1.4µm, dual pixel PDAF, OIS, 12 MP, f/2.4, 120˚, 13mm (ultrawide), 1/3.6\r\n\r\n• Chip: Apple A14 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512 GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3687 mAh, sạc nhanh 20W",
                Quantity = 20,
                Price = 18000000,
                Discount = 25,
                SoldPrice = 13500000,
                IsDeleted = true,
                CateId = "IP"
            },
            new Products
            {
                ProductId = 7,
                ProductName = "Iphone 13",
                Description = "• Màn hình: OLED6.1″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 4 GB\r\n\r\n• Bộ nhớ: 512GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 3240 mAh, sạc nhanh 20W",
                Quantity = 20,
                Price = 20000000,
                IsDeleted = true,
                Discount = 20,
                SoldPrice = 16000000,
                CateId = "IP"
            },
            new Products
            {
                ProductId = 8,
                ProductName = "Iphone 13Pro Max",
                Description = "• Màn hình: OLED6.7″Super Retina XDR\r\n\r\n• Hệ điều hành: iOS 15\r\n\r\n• Camera sau: 2 camera 12 MP\r\n\r\n• Camera trước: 12 MP\r\n\r\n• Chip: Apple A15 Bionic.\r\n\r\n• CPU: Hexa-core\r\n\r\n• RAM: 6 GB\r\n\r\n• Bộ nhớ: 256GB\r\n\r\n• SIM: 1 Nano SIM & 1 eSIM Hỗ trợ 5G\r\n\r\n• Pin: 4352 mAh, sạc nhanh 20W",
                Quantity = 20,
                Price = 20000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 18000000,
                CateId = "IP"

            },
            new Products
            {
                ProductId = 9,
                ProductName = "Iphone 13Pro",
                Description = "Màn hình:\r\n\r\nOLED6.1\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 15\r\nCamera sau:\r\n\r\n3 camera 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A15 Bionic\r\nRAM:\r\n\r\n6 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n3095 mAh20 W",
                Quantity = 20,
                Price = 18000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 16200000,
                CateId = "IP"

            },
            new Products
            {
                ProductId = 10,
                ProductName = "Iphone 14",
                Description = "Màn hình:\r\n\r\nOLED6.7\"Super Retina XDR\r\nHệ điều hành:\r\n\r\niOS 16\r\nCamera sau:\r\n\r\nChính 48 MP & Phụ 12 MP, 12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nChip:\r\n\r\nApple A16 Bionic\r\nRAM:\r\n\r\n6 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIMHỗ trợ 5G\r\nPin, Sạc:\r\n\r\n4323 mAh20 W",
                Quantity = 20,
                Price = 20000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 18000000,
                CateId = "IP"

            },
            new Products
            {
                ProductId = 11,
                ProductName = "Apple Watch SE 2022",
                Description = "Apple Watch SE 40mm viền nhôm dây silicone có thiết kế hết sức năng động và trẻ trung. Khung viền của đồng hồ được làm từ nhôm với các cạnh được bo góc hoàn hảo. Đồng hồ sở hữu mặt kính cấu tạo từ Ion-X strengthened glass tạo lực tốt hơn những loại kính thông thường vừa tăng sự sang trọng vừa tạo độ bền bỉ chắc chắn. ",
                Quantity = 20,
                Price = 6000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 5400000,
                CateId = "AP"

            },
            new Products
            {
                ProductId = 12,
                ProductName = "Apple Watch SE 2022 GPS",
                Description = "Màn hình:\r\n\r\nOLED\r\nThời lượng pin:\r\n\r\nKhoảng 18 giờ (ở chế độ sử dụng thông thường)Khoảng 1.5 ngày (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nIon-X strengthened glass44 mm\r\nTính năng cho sức khỏe:\r\n\r\nTheo dõi mức độ stressTính quãng đường chạyĐếm số bước chânTheo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụTheo dõi chu kỳ kinh nguyệtChế độ luyện tậpCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpGửi thông báo khi có tai nạn\r\nHãng\r\n\r\nApple",
                Quantity = 20,
                Price = 9000000,
                IsDeleted = true,
                Discount = 20,
                SoldPrice = 7200000,
                CateId = "AP"
            },
            new Products
            {
                ProductId = 13,
                ProductName = "Apple Watch S8 LTE",
                Description = "Màn hình:\r\n\r\nOLED1.9 inch\r\nThời lượng pin:\r\n\r\nKhoảng 18 giờ (ở chế độ sử dụng thông thường)Khoảng 1.5 ngày (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nIon-X strengthened glass45 mm\r\nTính năng cho sức khỏe:\r\n\r\nTheo dõi mức độ stressTính quãng đường chạyĐiện tâm đồĐo nồng độ oxy (SpO2)Theo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụĐếm số bước chânĐo lượng tiêu thụ oxy tối đa (VO2 Max)Theo dõi chu kỳ kinh nguyệtChấm điểm giấc ngủCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpƯớc tính ngày rụng trứng\r\nHãng\r\n\r\nApple",
                Quantity = 20,
                Price = 14000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 12600000,
                CateId = "AP"
            },
            new Products
            {
                ProductId = 14,
                ProductName = "Apple Watch Ultra LTE",
                Description = "Màn hình:\r\n\r\nOLED1.92 inch\r\nThời lượng pin:\r\n\r\nKhoảng 36 giờ (ở chế độ sử dụng thông thường)Khoảng 60 giờ (ở chế độ tiết kiệm pin)\r\nKết nối với hệ điều hành:\r\n\r\niPhone 8 trở lên với iOS phiên bản mới nhất\r\nMặt:\r\n\r\nKính Sapphire49 mm\r\nTính năng cho sức khỏe:\r\n\r\nTính quãng đường chạyĐiện tâm đồĐếm số bước chânĐo nồng độ oxy (SpO2)Theo dõi giấc ngủĐo nhịp timTính lượng calories tiêu thụTheo dõi chu kỳ kinh nguyệtChấm điểm giấc ngủCảm biến nhiệt độNhắc nhở nhịp tim cao, thấpGửi thông báo khi có tai nạnƯớc tính ngày rụng trứng\r\nHãng\r\n\r\nApple",
                Quantity = 20,
                Price = 22000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 19800000,
                CateId = "AP"
            },
            new Products
            {
                ProductId = 15,
                ProductName = " iPad Air 5 M1",
                Description = "Màn hình:\r\n\r\n10.9\"Retina IPS LCD\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nKết nối:\r\n\r\nNghe gọi qua FaceTime\r\nCamera sau:\r\n\r\n12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.6 Wh (~ 7587 mAh)20 W",
                Quantity = 20,
                Price = 16000000,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 14400000,
                CateId = "IPA"
            },
            new Products
            {
                ProductId = 16,
                ProductName = " iPad Pro M2 ",
                Description = "Màn hình:\r\n\r\n11\"Liquid Retina\r\nHệ điều hành:\r\n\r\niPadOS 16\r\nChip:\r\n\r\nApple M2 8 nhân\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n128 GB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM hoặc 1 eSIM\r\nCamera sau:\r\n\r\nChính 12 MP & Phụ 10 MP, TOF 3D LiDAR\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.65 Wh (~ 7538 mAh)20 W",
                Quantity = 20,
                Price = 26000000 ,
                IsDeleted = true,
                Discount = 10,
                SoldPrice = 23400000,
                CateId = "IPA"
            },
            new Products
            {
                ProductId = 17,
                ProductName = "iPad Pro M1",
                Description = "Màn hình:\r\n\r\n11\"Liquid Retina\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n16 GB\r\nDung lượng lưu trữ:\r\n\r\n2 TB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM hoặc 1 eSIM\r\nCamera sau:\r\n\r\nChính 12 MP & Phụ 10 MP, TOF 3D LiDAR\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.65 Wh (~ 7538 mAh)20 W",
                Quantity = 20,
                Price =70000000 ,
                IsDeleted = true,
                Discount = 20,
                SoldPrice = 56000000,
                CateId = "IPA"
            },
            new Products
            {
                ProductId = 18,
                ProductName = "iPad Air 5",
                Description = "Màn hình:\r\n\r\n10.9\"Retina IPS LCD\r\nHệ điều hành:\r\n\r\niPadOS 15\r\nChip:\r\n\r\nApple M1\r\nRAM:\r\n\r\n8 GB\r\nDung lượng lưu trữ:\r\n\r\n64 GB\r\nKết nối:\r\n\r\n5GNghe gọi qua FaceTime\r\nSIM:\r\n\r\n1 Nano SIM & 1 eSIM\r\nCamera sau:\r\n\r\n12 MP\r\nCamera trước:\r\n\r\n12 MP\r\nPin, Sạc:\r\n\r\n28.6 Wh (~ 7587 mAh)20 W",
                Quantity = 20,
                Price = 20000000,
                IsDeleted = true,
                Discount = 15,
                SoldPrice = 17000000,
                CateId = "IPA"
            }
            


            );;
            modelBuilder.Entity<ImageProduct>().HasData(
                new ImageProduct
                {
                    ImageId = 1,
                    Color = "Trắng",
                    Image = "https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-hh-600x600.jpg",
                    ProductId = 1,
                },
                  new ImageProduct
                  {
                      ImageId = 2,
                      Color = "Đen",
                      Image = "https://cellbuddy.in/buddy/wp-content/uploads/2022/09/X-Space-grey-2.png",
                      ProductId = 1,
                  }, new ImageProduct
                  {
                      ImageId = 3,
                      Color = "Trắng",
                      Image = "https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-hh-600x600.jpg",
                      ProductId = 2,
                  }, new ImageProduct
                  {
                      ImageId = 4,
                      Color = "Đen",
                      Image = "https://cellbuddy.in/buddy/wp-content/uploads/2022/09/X-Space-grey-2.png",
                      ProductId = 2,
                  }, new ImageProduct
                  {
                      ImageId = 5,
                      Color = "Gold",
                      Image = "https://p.ipricegroup.com/uploaded_9613fe97543343dafd8307992bf3526f.jpg",
                      ProductId = 2,
                  }, new ImageProduct
                  {
                      ImageId = 6,
                      Color = "Trắng",
                      Image = "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-200x200.jpg",
                      ProductId = 3,
                  }, new ImageProduct
                  {
                      ImageId = 7,
                      Color = "Tím",
                      Image = "https://i.insider.com/5df10d81fd9db229ba736a77?width=700",
                      ProductId = 3,
                  }, new ImageProduct
                  {
                      ImageId = 8,
                      Color = "Trắng",
                      Image = "https://product.hstatic.net/200000571041/product/iphone-11-pro-bac-600x600-200x200-1_5583b7a21a5643798a9761d18dfba888.jpeg",
                      ProductId = 4,
                  }, new ImageProduct
                  {
                      ImageId = 9,
                      Color = "Xanh Rêu",
                      Image = "https://cdn.tgdd.vn/Products/Images/42/200533/iphone-11-pro-max-green-600x600.jpg",
                      ProductId = 4,
                  }, new ImageProduct
                  {
                      ImageId = 10,
                      Color = "Gold",
                      Image = "https://cdn.mobilecity.vn/mobilecity-vn/images/2021/07/iphone-11-pro-max-vang.jpg.webp",
                      ProductId = 4,
                  }, new ImageProduct
                  {
                      ImageId = 11,
                      Color = "Gold",
                      Image = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone-12-pro-gold-2020?wid=2000&hei=1897&fmt=jpeg&qlt=95&.v=1635202844000",
                      ProductId = 5,
                  }, new ImageProduct
                  {
                      ImageId = 12,
                      Color = "Trắng",
                      Image = "https://media.solotodo.com/media/products/1249252_picture_1602843842.png",
                      ProductId = 5,
                  }, new ImageProduct
                  {
                      ImageId = 13,
                      Color = "Xanh",
                      Image = "https://bizweb.dktcdn.net/thumb/1024x1024/100/398/430/products/iphone-12-pro-family-hero-f7dab161-d654-4f74-8959-ddfeb48ef397.jpg?v=1660804901257",
                      ProductId = 5,
                  }, new ImageProduct
                  {
                      ImageId = 14,
                      Color = "Xanh",
                      Image = "https://cdn.tgdd.vn/Products/Images/42/213033/iphone-12-pro-max-xanh-duong-new-600x600-600x600.jpg",
                      ProductId = 6,
                  }, new ImageProduct
                  {
                      ImageId = 15,
                      Color = "Gold",
                      Image = "https://huydungmobile.com/wp-content/uploads/2023/01/refurb-iphone-12-pro-max-gold-2020.jpeg",
                      ProductId = 6,
                  }, new ImageProduct
                  {
                      ImageId = 16,
                      Color = "Trắng",
                      Image = "https://cdnphoto.dantri.com.vn/EGz2fNvNzX9yTEmcRkcsss4JO-Q=/thumb_w/1020/2023/05/04/iphone-12-pro-max-1683213868319.jpg",
                      ProductId = 6,
                  }, new ImageProduct
                  {
                      ImageId = 17,
                      Color = "Hồng",
                      Image = "https://techland.com.vn/wp-content/uploads/2021/09/iphone-13-pink-select-2021.png",
                      ProductId = 7,
                  }, new ImageProduct
                  {
                      ImageId = 18,
                      Color = "Trắng",
                      Image = "https://cdn.viettelstore.vn/Images/Product/ProductImage/452166194.jpeg",
                      ProductId = 7,
                  }, new ImageProduct
                  {
                      ImageId = 19,
                      Color = "Xanh",
                      Image = "https://cdn.tgdd.vn/Products/Images/42/223602/s16/iphone-13-blue-thumbtz-650x650.png",
                      ProductId = 7,
                  }, new ImageProduct
                  {
                      ImageId = 20,
                      Color = "Xanh",
                      Image = "https://cdn2.cellphones.com.vn/x/media/catalog/product/3/_/3_51_1_7.jpg",
                      ProductId = 8,
                  }, new ImageProduct
                  {
                      ImageId = 21,
                      Color = "Trắng",
                      Image = "https://cdn2.cellphones.com.vn/x358,webp,q100/media/catalog/product/4/_/4_36_3_2_1_9.jpg",
                      ProductId = 8,
                  }, new ImageProduct
                  {
                      ImageId = 22,
                      Color = "Đen",
                      Image = "https://cdn.viettelstore.vn/Images/Product/ProductImage/1191787513.jpeg",
                      ProductId = 8,
                  }
                  , new ImageProduct
                  {
                      ImageId = 29,
                      Color = "Trắng",
                      Image = "https://cdn.hoanghamobile.com/i/preview/Uploads/2022/12/20/whatsapp-image-2022-12-20-at-14-37-24-1.jpeg",
                      ProductId = 11,
                  }, new ImageProduct
                  {
                      ImageId = 30,
                      Color = "Đen",
                      Image = "https://bizweb.dktcdn.net/100/031/560/products/mpln3ref-vw-34fr-plus-watch-40-alum-midnight-nc-se-broshop.jpg?v=1663311761107",
                      ProductId = 11,
                  }, new ImageProduct
                  {
                      ImageId = 31,
                      Color = "Đen",
                      Image = "https://cdn2.cellphones.com.vn/x/media/catalog/product/i/p/ipad-pro-13-select-wifi-spacegray-202210-02.jpg",
                      ProductId = 16,
                  }, new ImageProduct
                  {
                      ImageId = 32,
                      Color = "Trắng",
                      Image = "https://newtechshop.vn/wp-content/uploads/2023/03/Danh-gia-Ipad-Pro-M2-9.png",
                      ProductId = 16,
                  }, new ImageProduct
                  {
                      ImageId = 33,
                      Color = "Đen",
                      Image = "https://cdn.tgdd.vn/Products/Images/522/269328/ipad-pro-m1-11-inch-wifi-2tb-2021-xam-thumb-600x600.jpeg",
                      ProductId = 17,
                  }, new ImageProduct
                  {
                      ImageId = 34,
                      Color = "Trắng",
                      Image = "https://cdn.tgdd.vn/Products/Images/522/269328/ipad-pro-m1-11-inch-wifi-2tb-2021-bac-thumb-600x600.jpeg",
                      ProductId = 17,
                  }, new ImageProduct
                  {
                      ImageId = 35,
                      Color = "Tím",
                      Image = "https://futureworld.com.vn/media/catalog/product/cache/4dbf4504e0d2fdef53ffcd9886d02b04/s/c/screen_shot_2022-06-23_at_10.21.59.png",
                      ProductId = 18,
                  }, new ImageProduct
                  {
                      ImageId = 36,
                      Color = "Xanh",
                      Image = "https://laptopvang.com/wp-content/uploads/2022/03/Apple-iPad-Air-5-Blue-laptopvang1.png",
                      ProductId = 18,
                  }, new ImageProduct
                  {
                      ImageId = 37,
                      Color = "Trắng",
                      Image = "https://i.blogs.es/a4dfe7/apple_ipad_air_4/450_1000.webp",
                      ProductId = 18,
                  }
                );


            modelBuilder.Entity<ProductOption>().HasData(
            new ProductOption
            {
                productOptionId = 1,
                productOptionName = "64GB",
                Price = 5000000,
                ProductId = 1
            },
            new ProductOption
            {

                productOptionId = 2,
                productOptionName = "256GB",
                Price = 5500000,
                ProductId = 1
            }, new ProductOption
            {
                productOptionId = 3,
                productOptionName = "512GB",
                Price = 6000000,
                ProductId = 1
            }, new ProductOption
            {
                productOptionId = 4,
                productOptionName = "64GB",
                Price = 6000000,
                ProductId = 2
            },
            new ProductOption
            {

                productOptionId = 5,
                productOptionName = "256GB",
                Price = 6300000,
                ProductId = 2
            }, new ProductOption
            {
                productOptionId = 6,
                productOptionName = "512GB",
                Price = 7000000,
                ProductId = 2
            }
            , new ProductOption
            {
                productOptionId = 7,
                productOptionName = "64GB",
                Price = 6500000,
                ProductId = 3
            },
            new ProductOption
            {

                productOptionId = 8,
                productOptionName = "256GB",
                Price = 6800000,
                ProductId = 3
            }, new ProductOption
            {
                productOptionId = 9,
                productOptionName = "512GB",
                Price = 7500000,
                ProductId = 3
            }, new ProductOption
            {
                productOptionId = 10,
                productOptionName = "64GB",
                Price = 12000000,
                ProductId = 4
            },
            new ProductOption
            {

                productOptionId = 11,
                productOptionName = "256GB",
                Price = 13000000,
                ProductId = 4
            }, new ProductOption
            {
                productOptionId = 12,
                productOptionName = "512GB",
                Price = 14000000,
                ProductId = 4
            }, new ProductOption
            {
                productOptionId = 13,
                productOptionName = "64GB",
                Price = 12500000,
                ProductId = 5
            },
            new ProductOption
            {

                productOptionId = 14,
                productOptionName = "256GB",
                Price = 13000000,
                ProductId = 5
            }, new ProductOption
            {
                productOptionId = 15,
                productOptionName = "512GB",
                Price = 13500000,
                ProductId = 5
            }, new ProductOption
            {
                productOptionId = 16,
                productOptionName = "64GB",
                Price = 15000000,
                ProductId = 6
            },
            new ProductOption
            {

                productOptionId = 17,
                productOptionName = "256GB",
                Price = 15500000,
                ProductId = 6
            }, new ProductOption
            {
                productOptionId = 18,
                productOptionName = "512GB",
                Price = 16000000,
                ProductId = 6
            }, new ProductOption
            {
                productOptionId = 19,
                productOptionName = "64GB",
                Price = 15500000,
                ProductId = 7
            },
            new ProductOption
            {

                productOptionId = 20,
                productOptionName = "256GB",
                Price = 16500000,
                ProductId = 7
            }, new ProductOption
            {
                productOptionId = 21,
                productOptionName = "512GB",
                Price = 17500000,
                ProductId = 7
            }
             ,
            new ProductOption
             {
                 productOptionId = 22,
                 productOptionName = "64GB",
                 Price = 19000000,
                 ProductId = 8
             },
            new ProductOption
            {

                productOptionId = 23,
                productOptionName = "256GB",
                Price = 19500000,
                ProductId = 8
            }, new ProductOption
            {
                productOptionId = 24,
                productOptionName = "512GB",
                Price = 20000000,
                ProductId = 8
            }
            





             , new ProductOption
             {
                 productOptionId = 25,
                 productOptionName = "40mm",
                 Price = 5000000,
                 ProductId = 11
             },
            new ProductOption
            {

                productOptionId = 26,
                productOptionName = "44mm",
                Price = 6000000,
                ProductId = 11
            },



           
           
            new ProductOption
            {

                productOptionId = 27,
                productOptionName = "128GB",
                Price = 23900000,
                ProductId = 16
            }
            , new ProductOption
            {
                productOptionId = 28,
                productOptionName = "256GB",
                Price = 26900000,
                ProductId = 16
            },
            new ProductOption
            {

                productOptionId = 29,
                productOptionName = "1T",
                Price = 51000000,
                ProductId = 17
            }
            , new ProductOption
            {
                productOptionId = 30,
                productOptionName = "2T",
                Price = 62000000,
                ProductId = 17
            }
            ,
            new ProductOption
            {

                productOptionId = 31,
                productOptionName = "64GB",
                Price = 17490000,
                ProductId = 18
            }
            , new ProductOption
            {
                productOptionId = 32,
                productOptionName = "256GB",
                Price = 19490000,
                ProductId = 18
            }

            );

        }
        
    }
}

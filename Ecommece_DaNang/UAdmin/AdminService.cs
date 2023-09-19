using AutoMapper;
using Azure.Core;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommece_DaNang.UAdmin
{
    public class AdminService : IAdminService
    {
        private AppDbcontext _context;
        private IMapper _mapper;

        public AdminService(AppDbcontext context,IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddProduct(AddProduct model)
        {
            // Thêm sản phẩm chính
            var product = _mapper.Map<Products>(model);
            _context.Products.Add(product);
            _context.SaveChanges();

            // Lấy ID của sản phẩm đã thêm
            int productId = product.ProductId;

            // Thêm tùy chọn sản phẩm
            foreach (var option in model.updateProductOptions)
            {
                var productOption = new ProductOption
                {
                    ProductId = productId,
                    productOptionName = option.productOptionName,
                    Price = option.Price
                };
                _context.productoptions.Add(productOption);
            }

            // Thêm hình ảnh sản phẩm
            foreach (var image in model.ImageProducts)
            {
                var imageProduct = new ImageProduct
                {
                    ProductId = productId,
                    Color = image.Color,
                    Image = image.Image
                };
                _context.ImageProducts.Add(imageProduct);
            }

            _context.SaveChanges();
        }

        public async Task<decimal> argMoney1day()
        {

            DateTime now = DateTime.Now;
            var money = _context.Orders.Where(x => x.CreateOrder.Month == now.Month && x.CreateOrder.Year == now.Year).ToList();
            var totalmoney = money.GroupBy(x => x.CreateOrder.Day)
                .Select(a => new 
                {
                    Day = a.Key,
                    TotalPrice = a.Sum(x => x.TotalPrice)
                }).ToList() ;
            var totalmoney1day = totalmoney.Average(x => x.TotalPrice);
            return totalmoney1day;
        }

        public void DeleteProduct(int ProductId)
        {
            var product = _context.Products.Find(ProductId);
            if(product != null)
            {
                product.IsDeleted = false;
                _context.SaveChanges();
            }
           
        }

        public async Task<decimal> GettotalMoney()
        {
            var money = await _context.Orders.SumAsync(x => x.TotalPrice);
            return money;
        }

        public async Task<decimal> GettotalMoney1Month()
        {
            DateTime now = DateTime.Now;
            var money = _context.Orders.Where(x => x.CreateOrder.Month == now.Month && x.CreateOrder.Year == now.Year).ToList();
            var totalmoney = money.Sum(x => x.TotalPrice);
            return totalmoney;
        }

        public async Task<bool> UpdateProduct(UpdateProduct model, int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                // Xóa tất cả hình ảnh sản phẩm hiện tại của sản phẩm
                var existingImages = _context.ImageProducts.Where(o => o.ProductId == productId);
                _context.ImageProducts.RemoveRange(existingImages);

                // Xóa tất cả các tùy chọn sản phẩm hiện tại của sản phẩm
                var existingOptions = _context.productoptions.Where(o => o.ProductId == productId);
                _context.productoptions.RemoveRange(existingOptions);

                // Cập nhật thông tin sản phẩm chính
                _mapper.Map(model, product);

                // Thêm các tùy chọn sản phẩm mới từ model
                foreach (var option in model.updateProductOptions)
                {
                    var productOption = new ProductOption
                    {
                        ProductId = productId,
                        productOptionName = option.productOptionName,
                        Price = option.Price
                    };
                    _context.productoptions.Add(productOption);
                }

                // Thêm các hình ảnh sản phẩm mới từ model (đảm bảo kiểm tra sự tồn tại trước khi thêm)
                foreach (var option in model.ImageProducts)
                {
                    var existingImage = _context.ImageProducts.Any(img => img.ProductId == productId && img.Image == option.Image);

                    if (existingImage == null)
                    {
                        var image = new ImageProduct
                        {
                            ProductId = productId,
                            Color = option.Color,
                            Image = option.Image,
                        };
                        _context.ImageProducts.Add(image);
                    }
                }

                _context.SaveChanges();
                return true;
            }
            return false;
        }



    }
}

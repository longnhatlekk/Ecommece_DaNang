using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommece_DaNang.UCustomer
{
    public class CustomerService : ICustomerService
    {
        private IMapper _mapper;
        private AppDbcontext _context;

        public CustomerService(AppDbcontext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<CustomerModel>> GetOrdersByUserId(int userId)
        {
            var orders = await _context.Orders
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Products)
                        .ThenInclude(p => p.ProductOptions)
                        .ThenInclude(x => x.products.ImageProducts)
                .ToListAsync();

            var customerModels = new List<CustomerModel>();

            foreach (var order in orders)
            {
                foreach (var orderDetail in order.OrderDetails)
                {
                    var customerModel = new CustomerModel
                    {
                        orderID = order.OrderId,
                        ProductName = orderDetail.Products.ProductName,
                        Price = orderDetail.Products.Price,
                        SoldPrice = orderDetail.Products.SoldPrice,
                        Discount = orderDetail.Products.Discount,
                        productOptionName = orderDetail.Products.ProductOptions.FirstOrDefault()?.productOptionName,
                        // Lấy hình ảnh sản phẩm, nếu có
                        Image = orderDetail.Products.ProductOptions
                            .SelectMany(po => po.products.ImageProducts)
                            .FirstOrDefault()?.Image
                    };

                    customerModels.Add(customerModel);
                }
            }

            return customerModels;
        }


    }
}

using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Ecommece_DaNang.Payment;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ecommece_DaNang.Order
{
    public class OrderService : IOrderService
    {
        private AppDbcontext _context;
        private IMapper _mapper;
        private IConfiguration _config;
        private IHttpContextAccessor _contextAccessor;

        public OrderService(AppDbcontext context, IMapper mapper,IConfiguration config , IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _mapper = mapper;
            _config = config;
            _contextAccessor = contextAccessor;
        }
        public async Task<OrderResponse> CreateOrder(int userId, OrderModel model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            
            var items = new List<OrderDetail>();
            decimal totalPrice = 0;
            
            foreach (var option in model.Items)
            {
                var quantity = option.Quantity;
                var productId = option.ProductId;
                var productoptionid = option.ProductOptionID;
                var imageID = option.ImageId;
                var product = await _context.Products.Include(x => x.ProductOptions).FirstOrDefaultAsync(x => x.ProductId == productId);
                var selectoption = product.ProductOptions.FirstOrDefault(x => x.productOptionId == productoptionid);
                var selectImageID = product.ImageProducts.FirstOrDefault(x => x.ImageId == imageID);
                if (product == null)
                {
                    throw new Exception("Product not found");
                }

                if (product.Quantity < quantity)
                {
                    throw new Exception("Not enough product in stock");
                }

                var orderDetailModel = new OrderDetail
                {
                    ProductId = productId,
                    Quantity = quantity,
                    Orderdat = DateTime.UtcNow,
                    PriceProduct = selectoption.Price,
                    Tofeedback = "Good",
                    Total = quantity * selectoption.Price,
                    ProductOptionID = productoptionid,
                    ImageId = imageID
                };

               
                items.Add(orderDetailModel);
                totalPrice += orderDetailModel.Total;

                // Giảm số lượng sản phẩm trong kho sau khi đặt hàng
                //product.Quantity -= quantity;
            }

            var orderModel = new Orders
            {
                UserId = userId,
                Status = false,
                OrderDetails = items,
                TotalPrice = totalPrice,
                Note = model.Note,
                CreateOrder = DateTime.UtcNow,
                
            };

            

           _context.Orders.Add(orderModel);
            await _context.SaveChangesAsync();
            var mapper = _mapper.Map<OrderResponse>(orderModel);
            return mapper;
        }

        public async Task<Orders> GetOrder(int orderId)
        {
            var order =await _context.Orders
                
                .Include(x => x.OrderDetails)
                .ThenInclude(x => x.Products)
                .Include(x => x.Payments)
                .Include(x => x.Userss)
                .FirstOrDefaultAsync(x => x.OrderId == orderId);
            return order;
        }

        public async Task<List<OrderSuccess>> GetOrderSuccess(int userId)
        {
            var orderDetails = await _context.OrderDetails
         .Where(od => od.Orders.UserId == userId && od.Orders.Status == true)
         .Include(od => od.Orders)
             .ThenInclude(order => order.Userss)
         .Include(od => od.imageProduct)
             .ThenInclude(ip => ip.Products)
         .Include(od => od.productOption)
         .ToListAsync();

            var orderSuccessList = orderDetails.Select(orderDetail => new OrderSuccess
            {
                OrderId = orderDetail.Orders.OrderId,
                Note = orderDetail.Orders.Note,
                TotalPrice = orderDetail.Orders.TotalPrice,
                CreateOrder = orderDetail.Orders.CreateOrder,
                Image = orderDetail.imageProduct.Image, // Thay 'Image' bằng tên thuộc tính ảnh của sản phẩm
                ProductOptionName = orderDetail.productOption.productOptionName,
                ProductOption = orderDetail.PriceProduct, // Sử dụng thuộc tính 'PriceProduct' của OrderDetail
                ProductName = orderDetail.Products.ProductName
            }).ToList();

            return orderSuccessList;
        }


        public async Task<OrderResponse> Payment(PaymentModel model)

        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.OrderId == model.OrderId);
            if (order == null) throw new Exception("no order");

            var payment = new Paymentt
            {
                userID = order.UserId,
                paymentdate = DateTime.UtcNow,
                Method = model.Method,
                Status = true,
                Amount = order.TotalPrice,
            };

            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            order.Status = true;
            order.PaymentId = payment.PaymentId;
            await _context.SaveChangesAsync();

            if (model.Method == "Cash")
            {
               
                var mapper = _mapper.Map<OrderResponse>(order);
                return mapper;
            }else if(model.Method == "Vnpay")
            {
              
                var vnPayService = new VnPayService(_config, _contextAccessor);
                var paymentUrl = vnPayService.CreatePaymentUrl(payment);
                
                return new OrderResponse { 
                    OrderId = order.OrderId,
                    PaymentId = payment.PaymentId,
                    TotalPrice = order.TotalPrice,

                PaymentUrl = paymentUrl
                };

            }
            else
            {
                throw new Exception("No order");
            }
            
            
        }
    }
}

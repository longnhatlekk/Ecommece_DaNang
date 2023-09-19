using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommece_DaNang.Order
{
    public class OrderService : IOrderService
    {
        private AppDbcontext _context;
        private IMapper _mapper;

        public OrderService(AppDbcontext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
                var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == productId);

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
                    PriceProduct = product.SoldPrice,
                    Tofeedback = "Good",
                    Total = quantity * product.SoldPrice
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

            var mapper = _mapper.Map<OrderResponse>(order);
            return mapper;
        }
    }
}

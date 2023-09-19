using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;

namespace Ecommece_DaNang.Order
{
    public interface IOrderService
    {
        public Task<OrderResponse> CreateOrder(int userId, OrderModel model);
        public Task<OrderResponse> Payment(PaymentModel model);
        public Task<Orders> GetOrder(int orderId);
    }
}

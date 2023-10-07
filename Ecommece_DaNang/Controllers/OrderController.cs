using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Ecommece_DaNang.Order;
using Ecommece_DaNang.Payments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommece_DaNang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderservice;
        private IMapper _mapper;
        private AppDbcontext _context;
        private IConfiguration _config;

        public OrderController(IOrderService orderService, IMapper mapper, AppDbcontext context,IConfiguration config)
        {
            _orderservice = orderService;
            _mapper = mapper;
            _context = context;
            _config = config;
        }
        [HttpPost("Payment-callBack")]
        public async Task<IActionResult> Callback([FromBody] VnpayPaymentCallback vnpayPaymentCallback)
        {
            try
            {
               
                if (vnpayPaymentCallback == null || string.IsNullOrEmpty(vnpayPaymentCallback.TransactionCode) || string.IsNullOrEmpty(vnpayPaymentCallback.TransactionStatus))
                {
                    
                    return BadRequest("Dữ liệu callback không hợp lệ.");
                }               
                var orderIdToUpdate = vnpayPaymentCallback.TransactionCode;
                var newOrderStatus = vnpayPaymentCallback.Success ? true : false;
                if (!int.TryParse(orderIdToUpdate, out int orderIdAsInt))
                {
                    return BadRequest("Mã giao dịch không hợp lệ.");
                }               
                var order = await _context.Orders.FirstOrDefaultAsync(x => x.OrderId == orderIdAsInt);
                if (order == null)
                {
                    return NotFound("Không tìm thấy đơn hàng tương ứng.");
                }
                order.Status = newOrderStatus;             
                await _context.SaveChangesAsync();
                var successurl = _config["Payment:SuccessUrl"];
                return Redirect(successurl);
            }
            catch (Exception ex)
            {               
                return StatusCode(StatusCodes.Status500InternalServerError, $"Lỗi xử lý callback: {ex.Message}");
            }
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder(OrderModel model)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            if (user == null) return BadRequest("invalid user");
            int userId = int.Parse(user.Value);
            var order = await _orderservice.CreateOrder(userId, model);

            return Ok(order);
        }
        [HttpPost("Payment")]
        public async Task<IActionResult> Payment(PaymentModel model)
        {
            var order = await _orderservice.Payment(model);
            return Ok(order);

        }
        [HttpGet("get-order-success")]
        public async Task<IActionResult> getordersuccess()
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            if (user == null) return BadRequest("invalid user");
            int userId = int.Parse(user.Value);
            var getorder = await _orderservice.GetOrderSuccess(userId);
            return Ok(getorder);
        }
        
    }
}

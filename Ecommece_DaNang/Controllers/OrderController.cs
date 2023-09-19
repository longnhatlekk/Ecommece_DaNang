using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Ecommece_DaNang.Order;
using Ecommece_DaNang.Payments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommece_DaNang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderservice;
        private IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderservice = orderService;
            _mapper = mapper;
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
    }
}

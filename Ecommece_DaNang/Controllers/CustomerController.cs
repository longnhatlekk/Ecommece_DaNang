using Ecommece_DaNang.Order;
using Ecommece_DaNang.UCustomer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommece_DaNang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _service;
        private IOrderService _orderService;

        public CustomerController(ICustomerService customerService, IOrderService orderService) 
        {
        _service = customerService;
            _orderService = orderService;
        }
        [HttpGet("getOrderCus")]
        public async Task<IActionResult> getorder()
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            if (user == null) return BadRequest("Invalid token");
            int userid = int.Parse(user.Value);
            var cus = await _orderService.GetOrderSuccess(userid);
            return Ok(cus);
        }

    }

}

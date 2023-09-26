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

        public CustomerController(ICustomerService customerService) 
        {
        _service = customerService;
        }
        [HttpGet("getOrderCus")]
        public async Task<IActionResult> getorder(int userid)
        {
            var cus = await _service.GetOrdersByUserId(userid);
            return Ok(cus);
        }
    }

}

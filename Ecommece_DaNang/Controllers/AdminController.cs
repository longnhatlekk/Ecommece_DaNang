using Ecommece_DaNang.Model;
using Ecommece_DaNang.UAdmin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommece_DaNang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles ="AD")]
    public class AdminController : ControllerBase
    {
        private IAdminService _adminservice;

        public AdminController(IAdminService adminService)
        {
            _adminservice = adminService;
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> Addproducts( AddProduct model)
        {
            _adminservice.AddProduct(model);
            return Ok(model);
        }
        [HttpPost("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            _adminservice.DeleteProduct(productId);
            return Ok("Delete Sucess");
        }
        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(UpdateProduct model, int ProductId)
        {
           var product = await _adminservice.UpdateProduct(model, ProductId);
            return Ok(product);
        }
        [HttpGet("GettotalMoney")]
        public async Task<IActionResult> gettotalMoney()
        {
            var money =await _adminservice.GettotalMoney();
            return Ok(money);
        }
        [HttpGet("GettotalMoney1month")]
        public async Task<IActionResult> GettotalMoney1month()
        {
            var money = await _adminservice.GettotalMoney1Month();
            return Ok(money);
        }
        [HttpGet("gettotalmoney1day")]
        public async Task<IActionResult > gettotalmoney1day()
        {
            var money = await _adminservice.argMoney1day();
            return Ok(money);
        }
        [HttpGet("get-totalmoney-year")]
        public async Task<IActionResult> GettotalMoneyYear()
        {
            var money = await _adminservice.ageMoney1year();
            return Ok(money);
        }
        [HttpGet("get-totalmoney-oneweek")]
        public async Task<IActionResult> GetTotalMoneyoneWeek()
        {
            var money = await _adminservice.ageMoney1week();
            return Ok(money);
        }
    }
}

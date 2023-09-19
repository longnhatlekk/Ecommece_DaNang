using Ecommece_DaNang.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommece_DaNang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> getallProduct()
        {
            var product = await _service.getallProduct();
            return Ok(product);
        }
        [HttpGet("getCateproduct")]
        public async Task<IActionResult> getcateProduct(string cateid)
        {
            var product =await _service.GetCateProducts(cateid);
            return Ok(product);
        }
        [HttpGet("getproductbyID")]
        public async Task<IActionResult> getproductbyID(int productId)
        {
            var product = await _service.getProducts(productId);
            return Ok(product);
        }
        [HttpPost("Searchproduct")]
        public async Task<IActionResult> SearchProduct(string ProductName)
        {
            var product = await _service.SearchProduct(ProductName);
            return Ok(product);
        }
        [HttpGet("HotProduct")]
        public async Task<IActionResult> gethotProduct()
        {
            var product = await _service.getHotProduct();
            return Ok(product);
        }

    }
}

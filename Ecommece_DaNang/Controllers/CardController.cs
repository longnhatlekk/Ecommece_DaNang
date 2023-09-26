using Ecommece_DaNang.Model;
using Ecommece_DaNang.UCard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommece_DaNang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private ICardService _service;

        public CardController(ICardService service )
        {
            _service = service;

        }
        [HttpPost("Addtocard")]
        public async Task<IActionResult> Addtocard(CardModel model)
        {
            try
            {
                var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
                if (user == null) return BadRequest("Invalid token");
                int userId = int.Parse(user.Value);
                _service.Addtocard(model, userId);
                return Ok("Add to card sucess");
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
                
        }
        [HttpPost("UpdateCard")]
        public async Task<IActionResult> updatecard(Updatequantity update)
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            if (user == null) return BadRequest("Invalid token");
            int userId = int.Parse(user.Value);
            _service.updateCard(update, userId);
            return Ok("Update success");
        }
        [HttpGet("ViewCard")]
        public async Task<IActionResult> viewcard()
        {
            var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
            if (user == null) return BadRequest("Invalid token");
            int userId = int.Parse(user.Value);
            var card = await _service.ViewCard(userId);
            return Ok(card);
        }
    }
}

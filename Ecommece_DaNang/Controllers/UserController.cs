using Ecommece_DaNang.Model;
using Ecommece_DaNang.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommece_DaNang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;

        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel login)
        {
            var user = await _service.Login(login);
            return Ok(user);
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
             _service.Logout(User);
            return Ok("Logout sucess");
        }
        [HttpPost("RegisterUser")]
        public async Task<IActionResult> Register(RegisterModel register)
        {
            _service.Register(register);
            return Ok(register);
        }
            
    }
}

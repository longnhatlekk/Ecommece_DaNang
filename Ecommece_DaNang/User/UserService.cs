using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Ecommece_DaNang.User.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ecommece_DaNang.User
{
    public class UserService : IUserService
    {
        private AppDbcontext _context;
        private IMapper _mapper;
        private IConfiguration _config;

        public UserService( AppDbcontext context, IMapper mapper,IConfiguration config )
        {
            _context = context;
            _mapper = mapper;
            _config = config;
        }
        public async Task<Token> Login(LoginModel login)
        {
           var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == login.Email && x.Password == login.Password);
            if(user == null) { throw new Exception("No user"); };
            var mapper = _mapper.Map<Users>(login);
            var token = await GenarateToken(user);
            return token;
        }
        private async Task<Token> GenarateToken(Users user)
        {


            var jwttokenHandler = new JwtSecurityTokenHandler();
            var secretkey = Encoding.UTF8.GetBytes(_config["JWT:Key"]);

            var claims = new List<Claim>
    {
         new Claim(ClaimTypes.Name, user.UserName),
         new Claim("UserId", user.UserId.ToString()),
         new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
         new Claim("Email", user.Email),       
         new Claim(ClaimTypes.Role, user.RoleId),
    };
            var tokendescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = _config["JWT:Issuer"],
                Audience = _config["JWT:Audience"],
                Expires = DateTime.UtcNow.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretkey), SecurityAlgorithms.HmacSha512),
                Claims = new Dictionary<string, object>
                {

                }
            };
            
            var token = jwttokenHandler.CreateToken(tokendescription);
            var accessToken = jwttokenHandler.WriteToken(token);
           
            return new Token
            {
                Tokens = accessToken,
              
            };

        }
        public void Logout(ClaimsPrincipal user)
        {
            var users = user.Claims.ToList();
            var tokenClaim = users.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti);
            if (tokenClaim != null)
            {
                users.Remove(tokenClaim);
            }
        }

        public void Register(RegisterModel model)
        {
            var mapper = _mapper.Map<Users>(model);
            _context.Users.Add(mapper);
            _context.SaveChanges();
        }
    }
}

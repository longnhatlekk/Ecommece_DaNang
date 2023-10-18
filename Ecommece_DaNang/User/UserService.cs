using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Ecommece_DaNang.User.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
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
                Expires = DateTime.UtcNow.AddSeconds(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretkey), SecurityAlgorithms.HmacSha512),
                Claims = new Dictionary<string, object>
                {

                }
            };
            
            var token = jwttokenHandler.CreateToken(tokendescription);
            var accessToken = jwttokenHandler.WriteToken(token);
            var refreshtoken = GenarateToken();
            var newrefreshtoken = new RefreshToken()
            {
                Id = Guid.NewGuid(),
                JwtId = token.Id,
                Token = refreshtoken,
                IsUsed = false,
                IsRevoked = false,
                IssuedAt = DateTime.UtcNow,
                ExpiredAt = DateTime.UtcNow.AddMinutes(1),
                UserId = user.UserId

            };
            _context.RefreshTokens.Add(newrefreshtoken);
            _context.SaveChanges();
            return new Token
            {
                accessTokens = accessToken,
                refreshToken = refreshtoken
            };

        }
        private string GenarateToken()
        {
            var random = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);

                return Convert.ToBase64String(random);
            }
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

        public async Task<List<GetAllUser>> getallUser()
        {
            var users = await _context.Users.ToListAsync();
            var user = _mapper.Map<List<GetAllUser>>(users);
            return user;
        }

        public  Task RenewToken(RenewToken tokenmodel)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var secretKeyBytes = Encoding.ASCII.GetBytes(_config["JWT:Key"]);
            var tokenValidateparam = new TokenValidationParameters
            {
                //tự cấp token
                ValidateIssuer = false,
                ValidateAudience = false,

                //ký vào token
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

                ClockSkew = TimeSpan.Zero,

                ValidateLifetime = false // ko kiểm tra token hết hạn
            };
            try
            {

                //check 1: AccessToken valid format
                var tokenInVerification = jwtTokenHandler.ValidateToken(tokenmodel.accessTokens.ToString(), tokenValidateparam,
                    out var validateToken);

                //check 2: check alg
                if (validateToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512, StringComparison.InvariantCultureIgnoreCase);
                    if (!result)//false
                    {
                        throw new Exception("Invalid token");
                    }
                }

                //check 3: check accessToken expire?
                var utcExxpireDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x =>
                x.Type == JwtRegisteredClaimNames.Exp).Value);

                var expireDate = DateTimeOffset.FromUnixTimeSeconds(utcExxpireDate).DateTime;
                if (expireDate > DateTime.UtcNow)
                {
                    throw new Exception("Access token has not yet expired");
                 
                }

                //Check 4: Check refreshtoken exist in DB
                var storedToken = _context.RefreshTokens.FirstOrDefault(x => x.Token ==
                 tokenmodel.refreshToken);
                if (storedToken == null)
                {
                    throw new Exception("refresh Token dose not exist");
                  
                }

                //Check 5: check refreshToken is used/revoked?
                if (storedToken.IsUsed)
                {
                    throw new Exception("refresh Token is used");
                  
                }
                if (storedToken.IsRevoked)
                {
                    throw new Exception("refresh Token is revoked");
              
                }
                //Check 6: AccessToken id == JwtId in refreshToken
                var jti = tokenInVerification.Claims.FirstOrDefault(x => x.Type
                 == JwtRegisteredClaimNames.Jti).Value;
                if (storedToken.JwtId != jti)
                {
                    throw new Exception("Token doesn't match");
                 
                }
                //Update token is used
                storedToken.IsRevoked = true;
                storedToken.IsUsed = true;
                _context.Update(storedToken);
                _context.SaveChanges();

                //create new token
                var user =  _context.Users.SingleOrDefault(u => u.UserId ==
                 storedToken.UserId);
                var token = GenarateToken(user);

                return token;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}

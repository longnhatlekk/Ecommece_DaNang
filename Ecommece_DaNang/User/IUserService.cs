using Ecommece_DaNang.Model;
using Ecommece_DaNang.User.Response;
using System.Security.Claims;

namespace Ecommece_DaNang.User
{
    public interface IUserService
    {
        public Task<Token> Login(LoginModel login);
        public void Logout(ClaimsPrincipal user);
        public void Register(RegisterModel model);
        public Task<List<GetAllUser>> getallUser();
        public Task RenewToken(RenewToken tokenmodel);

    }
}

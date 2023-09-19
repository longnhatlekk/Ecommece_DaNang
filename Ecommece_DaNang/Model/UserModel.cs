namespace Ecommece_DaNang.Model
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class RegisterModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string RoleId = "US";
    }
    public class ResetPassword
    {
        public string Email { get; set; }
    }
    public class ChangedPassword
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}

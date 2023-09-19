using System.Text.Json.Serialization;

namespace Ecommece_DaNang.Entity
{
    public class Users
    {
       public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string RoleId { get; set; }
        public Role role { get; set; }
        public ICollection<Card> card { get; set; }
        public ICollection<Paymentt> Payments { get; set; } = new List<Paymentt>();
        public List<Orders> Orders { get; set; } = new List<Orders>();
    }
}

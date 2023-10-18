using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommece_DaNang.Entity
{
    public class RefreshToken
    {
        [Key]
        public Guid Id { get; set; }

        public int UserId { get; set; }
        
        public Users User { get; set; }

        public string Token { get; set; }
        public string JwtId { get; set; }
        public bool IsRevoked { get; set; }
        public bool IsUsed { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}

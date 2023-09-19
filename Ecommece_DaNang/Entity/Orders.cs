using System.Text.Json.Serialization;

namespace Ecommece_DaNang.Entity
{
    public class Orders
    {
        public int OrderId { get; set; }
        public bool Status { get; set; }        
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreateOrder { get; set; }
        public int UserId { get; set; }
        public int? PaymentId { get; set; }
        public Users Userss { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public virtual Paymentt? Payments { get; set; }
        
    }
}

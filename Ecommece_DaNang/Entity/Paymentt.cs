namespace Ecommece_DaNang.Entity
{
    public class Paymentt
    {
        public int PaymentId { get; set; }
        public bool Status { get; set; }
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public DateTime paymentdate { get; set; }
        public int userID { get; set; }
        
        public Users Users { get; set; }
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
    }
}

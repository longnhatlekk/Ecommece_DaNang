namespace Ecommece_DaNang.Entity
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceProduct { get; set; }
        public decimal Total { get; set; }
        public DateTime Orderdat { get; set; }
        public string Tofeedback { get; set; }
        public int ProductId { get; set; }
        public int productOptionId { get; set; }
        public int OrderId { get; set; }
        public Products Products { get; set; }
        public Orders Orders { get; set; }  
    }
}

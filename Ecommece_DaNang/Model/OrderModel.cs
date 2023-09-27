namespace Ecommece_DaNang.Model
{
    public class OrderModel
    {
        public List<OrderdetailModel> Items { get; set; } = new List<OrderdetailModel>();  
        public string Note { get; set; }
    }
    public class OrderdetailModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int ImageId { get; set; }
        public int ProductOptionID { get; set; }
    }
    public class OrderResponse
    {
        public int OrderId { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreateOrder { get; set; }
        public int? PaymentId { get; set; }
        public int UserId { get; set; }
        public string PaymentUrl { get; set; }
        public  List<OrderDetailRespone> Itemss { get; set; } = new List<OrderDetailRespone>();
    }
    public class OrderDetailRespone
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceProduct { get; set; }
        public decimal Total { get; set; }
        public DateTime Orderdat { get; set; }
        public string Tofeedback { get; set; }
        public int ImageId { get; set; }
        public int ProductOptionID { get; set; }
    }
    public class PaymentUrls
    {
        public string PaymentUrl { get; set; }
    }
    public class OrderSuccess
    {
        public int OrderId { get; set; }
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreateOrder { get; set; }
        public string Image { get; set; }
        public string ProductOptionName { get; set; }
        public decimal ProductOption { get; set; }
        public string ProductName { get; set; }                
    }
}

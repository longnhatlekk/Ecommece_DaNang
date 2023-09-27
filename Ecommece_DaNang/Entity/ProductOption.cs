namespace Ecommece_DaNang.Entity
{
    public class ProductOption
    {
        public int productOptionId { get; set; }
        public string productOptionName { get; set;}
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public Products products { get; set; }
        public ICollection<Card> cards { get; set; } = new List<Card>();
        public ICollection<OrderDetail> orderDetails { get; set; } = new List<OrderDetail>();
    }
}

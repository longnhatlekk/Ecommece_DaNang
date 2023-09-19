namespace Ecommece_DaNang.Entity
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } 
       public bool IsDeleted { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        public string CateId { get; set; }
        public CateProduct cateProduct { get; set; }
        public ICollection<Card> card { get; set; }
        public List<ProductOption> ProductOptions { get; set; } = new List<ProductOption>();
        public List<ImageProduct> ImageProducts { get; set; } = new List<ImageProduct>();
        public ICollection<OrderDetail> OrderDetails { get; set; }  
    }
}

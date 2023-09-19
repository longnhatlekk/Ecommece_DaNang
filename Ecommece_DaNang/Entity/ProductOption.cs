namespace Ecommece_DaNang.Entity
{
    public class ProductOption
    {
        public int productOptionId { get; set; }
        public string productOptionName { get; set;}
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public Products products { get; set; }
    }
}

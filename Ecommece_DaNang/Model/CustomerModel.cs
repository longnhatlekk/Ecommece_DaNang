namespace Ecommece_DaNang.Model
{
    public class CustomerModel
    {
        public int orderID { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        public string Image { get; set; }
        public string productOptionName { get; set; }
    }
    public class ImageOrder
    {
        public string Color { get; set; }
        public string Image { get; set; }
    }
    public class OptionsOrder
    {
        public string productOptionName { get; set; }
        public decimal Price { get; set; }
    }
}

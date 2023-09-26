namespace Ecommece_DaNang.Entity
{
    public class Card
    {
        public int CardId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int ProductOptionID { get; set; }
        public int ImageId { get; set; }
       public ImageProduct ImageProducts { get; set; }
        public ProductOption ProductOptions { get; set; }
        public Products product { get; set; }
        public Users user { get; set; }
    }
}

namespace Ecommece_DaNang.Entity
{
    public class ImageProduct
    {
        public int ImageId { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
    }
}

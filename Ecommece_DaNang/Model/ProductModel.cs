namespace Ecommece_DaNang.Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        public List<ImageProducts> ImageProducts { get; set; } = new List<ImageProducts>();


    }
    public class SearchProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        public List<ImageProducts> ImageProducts { get; set; } = new List<ImageProducts>();
        public List<ProductOptions> ProductOptions { get; set; } = new List<ProductOptions>();

    }
    public class ProductOptions
    {
        public int productOptionId { get; set; }
        public string productOptionName { get; set; }
        public decimal Price { get; set; }
    }
    public class AllProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }

        public List<ProductOptions> ProductOptions { get; set; } = new List<ProductOptions>();
        public List<ImageProducts> ImageProducts { get; set; } = new List<ImageProducts>();

    }
    public class CateProducts
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        
        public string CateId { get; set; }
        public List<ImageProducts> ImageProducts { get; set; } = new List<ImageProducts>();
        public List<ProductOptions> ProductOptions { get; set; } = new List<ProductOptions>();
    }
    public class ImageProducts
    {
        public int ImageId { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
    }
    public class AddProduct
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        public string CateId { get; set; }
        public List<AddImageProduct> ImageProducts { get; set; } = new List<AddImageProduct>();
        public List<UpdateProductOption> updateProductOptions { get; set; } = new List<UpdateProductOption>();

    }

    public class AddImageProduct
    {
        public string Color { get; set; }
        public string Image { get; set; }
    }
    public class UpdateProductOption
    {
        public string productOptionName { get; set; }
        public decimal Price { get; set; }
    }
    public class UpdateProduct
    {
        
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } 
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        public string CateId { get; set; }
        public List<AddImageProduct> ImageProducts { get; set; } = new List<AddImageProduct>();
        public List<UpdateProductOption> updateProductOptions { get; set; } = new List<UpdateProductOption>();
    }
    public class HotProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal SoldPrice { get; set; }
        public List<AddImageProduct> ImageProducts { get; set; } = new List<AddImageProduct>();
        
    }
}

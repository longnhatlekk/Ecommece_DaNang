namespace Ecommece_DaNang.Entity
{
    public class CateProduct
    {
        public string CateID { get; set; }
        public string CateName { get; set; }
        public ICollection<Products> products { get; set; }
    }
}

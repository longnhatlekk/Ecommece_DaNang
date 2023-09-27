using Ecommece_DaNang.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommece_DaNang.Product
{
    public interface IProductService
    {
        public Task<List<ProductModel>> getallProduct();
        public Task<List<CateProducts>> GetCateProducts(string CateId);
        public Task<AllProductModel> getProducts(int productId);
        public Task<List<SearchProduct>> SearchProduct(string ProductName);
        public Task<List<HotProduct>> getHotProduct();
    }
}

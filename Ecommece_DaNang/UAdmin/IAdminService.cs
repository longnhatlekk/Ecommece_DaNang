using Ecommece_DaNang.Model;

namespace Ecommece_DaNang.UAdmin
{
    public interface IAdminService
    {
        public void AddProduct(AddProduct model);
        public void DeleteProduct(int ProductId);
        public Task<bool> UpdateProduct(UpdateProduct model,int productId);
        public Task<decimal> GettotalMoney();
        public Task<decimal> GettotalMoney1Month();
        public Task<decimal> argMoney1day();
    }
}

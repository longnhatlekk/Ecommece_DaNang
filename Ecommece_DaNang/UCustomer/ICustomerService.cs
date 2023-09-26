using Ecommece_DaNang.Model;

namespace Ecommece_DaNang.UCustomer
{
    public interface ICustomerService
    {
        public Task<List<CustomerModel>> GetOrdersByUserId(int userId);
    }
}

using CustomerManagament.Core.Models.DataBase;
using CustomerManagament.Core.Models.Response;

namespace CustomerManagament.Core.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<CustomerUpdateResponseModelNotify> UpsertCustomer(Customer customer);
    }
}

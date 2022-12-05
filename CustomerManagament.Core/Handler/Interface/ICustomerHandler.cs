using CustomerManagament.Core.Models.DataBase;
using CustomerManagament.Core.Models.Request;
using CustomerManagament.Core.Models.Response;

namespace CustomerManagament.Core.Handler.Interface
{
    public interface ICustomerHandler
    {
        Task<CustomerUpdateResponseModelNotify> UpsertCustomer(CustomerRequest customerRequest);
    }
}
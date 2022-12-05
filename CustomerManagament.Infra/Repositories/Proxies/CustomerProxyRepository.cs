using CustomerManagament.Core.Models.DataBase;
using CustomerManagament.Core.Models.Response;
using CustomerManagament.Core.Repositories.Interfaces;
using CustomerManagament.Core.Services.Interfaces;

namespace CustomerManagament.Infra.Repositories.Proxies
{
    public class CustomerProxyRepository : ICustomerRepository
    {
        private ICustomerRepository _customerRepository;

        private INotifiyCustomerUpdate _notifiyCustomerUpdate;
        public CustomerProxyRepository(ICustomerRepository customerRepository,
            INotifiyCustomerUpdate notifiyCustomerUpdate)
        {
            _customerRepository = customerRepository.ThrowIfNull();
            _notifiyCustomerUpdate = notifiyCustomerUpdate.ThrowIfNull();
        }

        public async Task<CustomerUpdateResponseModelNotify> UpsertCustomer(Customer customer)
        {
            CustomerUpdateResponseModelNotify customerNotifiy = await _customerRepository.UpsertCustomer(customer);

            if (customerNotifiy == null)
                throw new Exception($"Could not upsert Customer: {customer}");

            if (customerNotifiy.IsUpdated)
                await _notifiyCustomerUpdate.PushCustomerNotification();

            return customerNotifiy;
        }
    }
}

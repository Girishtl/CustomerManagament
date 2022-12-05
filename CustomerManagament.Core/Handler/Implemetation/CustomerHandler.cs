using CustomerManagament.Core.Handler.Interface;
using CustomerManagament.Core.Models.DataBase;
using CustomerManagament.Core.Models.Request;
using CustomerManagament.Core.Models.Response;
using CustomerManagament.Core.Repositories.Interfaces;
using CustomerManagament.Core.Utils.Mappers.Interfaces;

namespace CustomerManagament.Core.Handler.Implemetation
{
    public class CustomerHandler : ICustomerHandler
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper<CustomerRequest, Customer> _mapper;

        public CustomerHandler(ICustomerRepository customerRepository, IMapper<CustomerRequest, Customer> mapper)
        {
            _customerRepository = customerRepository.ThrowIfNull();
            _mapper = mapper.ThrowIfNull();
        }

  
        public async Task<CustomerUpdateResponseModelNotify> UpsertCustomer(CustomerRequest customerRequest)
        => await _customerRepository.UpsertCustomer(_mapper.Map(customerRequest));
    }
}

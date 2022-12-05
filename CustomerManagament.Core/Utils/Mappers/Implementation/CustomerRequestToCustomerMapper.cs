using CustomerManagament.Core.Models.DataBase;
using CustomerManagament.Core.Models.Request;
using CustomerManagament.Core.Utils.Mappers.Interfaces;


namespace CustomerManagament.Core.Utils.Mappers.Implementation
{
    public class CustomerRequestToCustomerMapper : IMapper<CustomerRequest, Customer>
    {
        public Customer Map(CustomerRequest customerRequest) => new Customer
        {
            Id = customerRequest.Id == 0 ? null : customerRequest.Id,
            CompanyName = customerRequest.CompanyName,
            FirstName = customerRequest.FirstName,
            LastName = customerRequest.LastName,
            Address = customerRequest.Address,
            Email = customerRequest.Email,
            Phonenumber = customerRequest.Phonenumber,
            CreateDate = customerRequest.Id == null ? DateTime.UtcNow : null,
            UpdateDate = DateTime.UtcNow
        };
    }
}

using CustomerManagament.Core.Models.DataBase;
using CustomerManagament.Core.Models.Response;
using CustomerManagament.Core.Repositories.Interfaces;
using CustomerManagament.Infra.EntityFramework;


namespace CustomerManagament.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerInformationContext _customerInformationContext;

        public CustomerRepository(CustomerInformationContext customerInformationContext)
        {
            _customerInformationContext = customerInformationContext.ThrowIfNull();
        }

       
        public async Task<CustomerUpdateResponseModelNotify> UpsertCustomer(Customer customer)
        {
            try
            {
                if (customer.Id == null)
                {
                    _customerInformationContext.Customers.Add(customer);
                }
                else
                {

                   var _customer =  _customerInformationContext.Customers.Where(x => x.Id == customer.Id).First();
                    _customer.CompanyName = customer.CompanyName;
                    _customer.UpdateDate = customer.UpdateDate;
                    _customer.Email = customer.Email;
                    _customer.Address = customer.Address;
                    _customer.FirstName = customer.FirstName;
                    _customer.LastName =   customer.LastName;
                    _customer.Phonenumber = customer.Phonenumber;
           
                }
                await _customerInformationContext.SaveChangesAsync();
                return new CustomerUpdateResponseModelNotify { IsUpdated = true,Customer = customer };
            }
            catch (Exception ex)
            {
                return new CustomerUpdateResponseModelNotify { IsUpdated = false, Customer = customer };
            }

        }
    }
}

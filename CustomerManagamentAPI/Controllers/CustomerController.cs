using CustomerManagament.Core.Handler.Interface;
using CustomerManagament.Core.Models.Request;
using CustomerManagament.Core.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagamentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerHandler _customerHandler;
        public CustomerController(ICustomerHandler customerHandler)
        => _customerHandler = customerHandler.ThrowIfNull();
      
        [HttpPost("UpsertCustomer")]
        public async Task<IActionResult> UpsertCustomer(CustomerRequest customerRequest)
        => Ok(await _customerHandler.UpsertCustomer(customerRequest));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagament.Core.Models.Request
{
    public class CustomerRequest
    {
        public long? Id { get; set; }

        public string? CompanyName { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Phonenumber { get; set; }

        public string? Address { get; set; }
    }
}

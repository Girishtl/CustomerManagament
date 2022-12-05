using CustomerManagament.Core.Models.DataBase;

namespace CustomerManagament.Core.Models.Response
{

    public class CustomerUpdateResponseModelNotify
    {
        public bool IsUpdated { get; set; }

        public Customer Customer { get; set; }


    }
}

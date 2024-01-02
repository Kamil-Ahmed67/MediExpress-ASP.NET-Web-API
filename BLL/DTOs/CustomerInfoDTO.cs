using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CustomerInfoDTO: CustomerDTO
    {
        public List<CustomerAddressDTO> CustomerAddresses { get; set; }
        public CustomerInfoDTO()
        {
            CustomerAddresses = new List<CustomerAddressDTO>();
        }
    }
}

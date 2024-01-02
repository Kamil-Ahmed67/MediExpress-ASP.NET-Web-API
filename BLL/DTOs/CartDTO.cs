using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CartDTO
    {
       
            public int CartID { get; set; }
            public string UserName { get; set; }
            public int ProductID { get; set; }
            public int Quantity { get; set; }
       
    }
}

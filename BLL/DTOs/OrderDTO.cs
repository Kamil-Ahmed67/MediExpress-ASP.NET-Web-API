using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string OrderedBy { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        
    }
}

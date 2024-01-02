using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        [ForeignKey("Customer")]
        public string UserName { get; set; }

        public virtual Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [ForeignKey("Customer")]
        public string UserName { get; set; }

        public virtual Customer Customer { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        public virtual Order Order { get; set; }

        public decimal PaymentAmount { get; set; }

        public DateTime PaymentDate { get; set; }

        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public Payment()
        {
            Carts = new List<Cart>();
        }

    }
}

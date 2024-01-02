using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        public string ReviewText { get; set; }

        [ForeignKey("Customer")]
        public string ReviewedBy { get; set; } //username inherited from User (FK)

        public DateTime Date { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; } // product id inherited from Product (FK)
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}

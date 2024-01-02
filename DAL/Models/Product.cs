using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public Product()

        {
            OrderDetails = new List<OrderDetails>();
            Carts = new List<Cart>();
            ProductReviews = new List<ProductReview>();
        }
    }
}

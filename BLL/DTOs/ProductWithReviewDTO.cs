using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductWithReviewDTO :  ProductDTO
    {
        public List<ProductReviewDTO> ProductReviews { get; set; }
        public ProductWithReviewDTO() 
        {
            ProductReviews = new List<ProductReviewDTO>();
        }
    }
}

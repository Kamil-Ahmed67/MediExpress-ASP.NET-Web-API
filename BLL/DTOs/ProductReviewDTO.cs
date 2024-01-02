using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductReviewDTO
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
    }
}

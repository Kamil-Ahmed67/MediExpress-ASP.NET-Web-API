using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CustomerAddress
    {

        [Key]
        public int Id { get; set; }


        [ForeignKey("Customer")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string DeliveryAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string State { get; set; }
        [Required]
        [StringLength(50)]
        public string PostalCode { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

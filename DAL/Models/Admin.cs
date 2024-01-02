using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }


        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Pharmacist> Pharmacists { get; set; }
        public Admin()
        {
            Customer = new List<Customer>();

            Pharmacists = new List<Pharmacist>();

        }
    }
}

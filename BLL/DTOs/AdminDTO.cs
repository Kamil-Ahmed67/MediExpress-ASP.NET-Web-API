using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminDTO
    {
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
    }
}

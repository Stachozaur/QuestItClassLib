using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_ClassLib.Data.DTO
{
    public class CreateUpdateUserDTO
    {
        public string FirstName { get; set; }
        [Required]
        [StringLength(70)]
        public string LastName { get; set; }
        [Required]
        [StringLength(70)]
        [MinLength(6)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [StringLength(30)]
        public string City { get; set; }
    }
}

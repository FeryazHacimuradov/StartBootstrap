using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.Models
{
    public class CustomUser : IdentityUser
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

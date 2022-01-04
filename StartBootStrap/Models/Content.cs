using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.Models
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string FirstText { get; set; }
        [MaxLength(200)]
        public string SecondText { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Logo { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(250)]
        public string AboutText { get; set; }
        [MaxLength(100)]
        public string EndText { get; set; }

    }
}

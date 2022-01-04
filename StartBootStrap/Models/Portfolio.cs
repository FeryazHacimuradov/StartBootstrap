using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.Models
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
    }
}

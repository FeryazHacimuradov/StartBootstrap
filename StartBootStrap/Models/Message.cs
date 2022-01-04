using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [Column(TypeName="ntext")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
    }
}

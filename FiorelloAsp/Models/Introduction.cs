using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.Models
{
    public class Introduction
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}

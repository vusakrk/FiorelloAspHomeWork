using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.ViewModels
{
    public class BasketViewModel
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public double Price { get; set; }
        [Required,StringLength(100)]
        public string Image { get; set; }
        public int Count { get; set; }
        public string UserName { get; set; }

    }
}

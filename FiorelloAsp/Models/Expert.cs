﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

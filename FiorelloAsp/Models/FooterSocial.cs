﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.Models
{
    public class FooterSocial
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
    }
}

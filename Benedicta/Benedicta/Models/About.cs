﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Benedicta.Models
{
    public class About
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Word { get; set; }

        [StringLength(200)]
        public string Word2 { get; set; }

        [StringLength(350)]
        public string Photo { get; set; }
    }
}
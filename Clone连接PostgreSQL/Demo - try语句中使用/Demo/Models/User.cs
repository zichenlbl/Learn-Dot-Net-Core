﻿using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    //[Table("user")]
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Order
    {

        public int Id { get; set; }

        public string Name { get; set; }

        //public User Owner { get; set; } // Burada Tam Emin Değilim

        public float TotalPrice { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWeb1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public int  UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
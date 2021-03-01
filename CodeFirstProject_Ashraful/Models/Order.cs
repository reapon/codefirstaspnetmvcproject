﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstProject_Ashraful.Models
{
    public class Order
    {
        public Guid OrderID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public Guid CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
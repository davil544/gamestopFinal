using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestopFinal.DataModels
{
    public class CartItem
    {
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
        public int Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
    }
}
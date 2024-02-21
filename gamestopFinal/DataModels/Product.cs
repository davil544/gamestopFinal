using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestopFinal.DataModels
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public float productCost { get; set; }
        public byte[] productImage { get; set; }
        public bool inCart { get; set; }
    }
    
}
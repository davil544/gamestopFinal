using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestopFinal.DataModels
{
    public class Status
    {
        public int statNum { get; set; }
        ///0 = null, 1 = deleted, 2 = added, 3 = failed ---> Admin Page,
        ///0 = Normal, 1 = Missing Forms ---> Checkout form
        public bool cartEmpty { get; set; }
        public double tax { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public string cartProductIDs { get; set; }
    }
}
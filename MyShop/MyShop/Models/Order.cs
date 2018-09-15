using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; } 
        public string Address { get; set; } 
        public string ContactPhone { get; set; } 

        public int ProductId { get; set; } 
        public Product Product { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models
{
    public class OrderDetails

    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int itemId { get; set; }
        public int Quantity { get; set; }
        public decimal unitPrice { get; set; }
       

        public virtual Item Item { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
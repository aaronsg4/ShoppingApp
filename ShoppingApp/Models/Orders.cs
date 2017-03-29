using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public bool Completed { get; set; }
        public string CustomerId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public decimal Total { get; set; }
        public DateTime orderDate { get; set; }
       

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ApplicationUser Customer { get; set; }
    }
}
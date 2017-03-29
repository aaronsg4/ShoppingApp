using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset creationDate { get; set; }
        public DateTimeOffset? updatedDate { get; set; }
        public string Description { get; set; }
        public string mediaURL { get; set; }

       

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
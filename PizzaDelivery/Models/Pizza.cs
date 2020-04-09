using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaDelivery.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Size { get; set; }

        public string Topping { get; set; }

        public decimal Price { get; set; }
    }
}
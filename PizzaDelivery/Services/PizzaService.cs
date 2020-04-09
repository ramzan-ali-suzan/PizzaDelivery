using PizzaDelivery.Models;
using System;
using System.Collections.Generic;

namespace PizzaDelivery.Services
{
    public class PizzaService
    {
        private readonly ApplicationDbContext _context;

        public PizzaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pizza> GetPizzas()
        {
            try
            {
                return _context.Pizzas;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
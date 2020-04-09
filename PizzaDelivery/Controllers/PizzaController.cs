using PizzaDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaDelivery.Controllers
{
    [RoutePrefix("api/pizza")]
    public class PizzaController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public PizzaController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Pizza> Get()
        {
            return _context.Pizzas;
        }
    }
}

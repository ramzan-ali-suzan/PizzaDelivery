using PizzaDelivery.Models;
using PizzaDelivery.Services;
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
        private readonly PizzaService _service;

        public PizzaController(PizzaService service)
        {
            _service = service;
        }

        public IEnumerable<Pizza> Get()
        {
            return _service.GetPizzas();
        }
    }
}

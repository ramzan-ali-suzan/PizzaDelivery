using PizzaDelivery.Models;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace PizzaDelivery
{
    public class UnityConfig
    {
        internal static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<ApplicationDbContext>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
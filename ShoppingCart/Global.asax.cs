using Ninject;
using Ninject.Web.Common.WebHost;
using RestSharp;
using ShoppingCart.Services;
using ShoppingCart.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShoppingCart
{
    public class MvcApplication : NinjectHttpApplication
    {        
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected override IKernel CreateKernel()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            AddBindings(kernel);
            return kernel;
        }

        private void AddBindings(IKernel kernel)
        {
            kernel.Bind<IProductsService>().To<ProductsService>();            
            kernel.Bind<IRestClient>().ToConstructor(x => new RestClient(ConfigurationManager.AppSettings["ProductsApiUrl"]));
        }
    }
}

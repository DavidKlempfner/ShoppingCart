using Ninject;
using Ninject.Parameters;
using RestSharp;
using ShoppingCart.Services;
using ShoppingCart.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace ShoppingCart.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            _kernel.Bind<IProductsService>().To<ProductsService>();

            //Works:
            string productsApiUrl = ConfigurationManager.AppSettings["ProductsApiUrl"];
            _kernel.Bind<IRestClient>().ToConstructor(x => new RestClient(productsApiUrl));

            //Fails:
            //_kernel.Bind<IRestClient>().ToConstructor(x => new RestClient(ConfigurationManager.AppSettings["ProductsApiUrl"]));
        }
    }
}

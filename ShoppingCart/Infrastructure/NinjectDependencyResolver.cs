﻿using Ninject;
using ShoppingCart.Services;
using ShoppingCart.Services.Abstract;
using System;
using System.Collections.Generic;
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
        }
    }
}

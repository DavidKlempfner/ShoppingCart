using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AutoMapper;
using Entities;
using ShoppingCart.API.DataAccess;

namespace ShoppingCart.API
{
    [ExcludeFromCodeCoverage]
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            CreateMappings();
        }

        private void CreateMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>();
            });
        }
    }
}

using Entities;
using Newtonsoft.Json;
using RestSharp;
using ShoppingCart.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class ProductsService : IProductsService
    {
        private IRestClient _restClient;
        public ProductsService(IRestClient restClient)
        {
            _restClient = restClient;
        }
        public List<ProductDto> GetProductsFromEndpoint()
        {
            IRestResponse response = _restClient.Execute(new RestRequest());
            var products = JsonConvert.DeserializeObject<List<ProductDto>>(response.Content);
            return products;
        }
    }
}

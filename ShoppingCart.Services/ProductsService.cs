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
        public List<ProductDto> GetProductsFromEndpoint(string productsApiUrl)
        {
            RestClient client = new RestClient(productsApiUrl);

            IRestResponse response = client.Execute(new RestRequest());
            var products = JsonConvert.DeserializeObject<List<ProductDto>>(response.Content);
            return products;
        }
    }
}

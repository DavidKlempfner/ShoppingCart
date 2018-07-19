using Entities;
using ShoppingCart.API.Services.Abstract;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Text;

namespace ShoppingCart.API.Controllers
{
    public class ProductApiController : ApiController
    {
        private IProductsApiService _productsService;
        public ProductApiController(IProductsApiService productsService)
        {
            _productsService = productsService;
        }       

        // GET: api/Product
        public HttpResponseMessage Get()
        {
            List<ProductDto> products = _productsService.GetProducts();
            string productsAsJsonStr = JsonConvert.SerializeObject(products);
            if (!string.IsNullOrEmpty(productsAsJsonStr))
            {
                var response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(productsAsJsonStr, Encoding.UTF8, "application/json");
                return response;
            }
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}
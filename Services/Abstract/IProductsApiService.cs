using Entities;
using System.Collections.Generic;

namespace ShoppingCart.API.Services.Abstract
{
    public interface IProductsApiService
    {
        List<ProductDto> GetProducts();
    }
}

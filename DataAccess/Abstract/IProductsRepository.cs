using System.Collections.Generic;

namespace ShoppingCart.API.DataAccess.Abstract
{
    public interface IProductsRepository
    {
        List<Product> GetProducts();
    }
}

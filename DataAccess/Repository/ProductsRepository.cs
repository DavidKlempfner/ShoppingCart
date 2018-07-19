using ShoppingCart.API.DataAccess.Abstract;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ShoppingCart.API.DataAccess.Repository
{
    [ExcludeFromCodeCoverage]
    public class ProductsRepository : IProductsRepository
    {        
        private ProductsEntities _productsEntities = new ProductsEntities();

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            
            foreach (var result in _productsEntities.Products)
            {
                Product product = new Product
                {
                    ID = result.ID,
                    Name = result.Name,
                    Description = result.Description,
                    Price = result.Price
                };

                products.Add(product);
            }

            return products;
        }
    }
}

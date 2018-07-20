using ShoppingCart.API.DataAccess.Abstract;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ShoppingCart.API.DataAccess.Repository
{
    [ExcludeFromCodeCoverage]
    public class ProductsRepository : IProductsRepository
    {        
        //private ProductsEntities _productsEntities = new ProductsEntities();

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product() { ID = 1, Name = "Product 1", Description = "Description 1", Price = 1 });
            products.Add(new Product() { ID = 2, Name = "Product 2", Description = "Description 2", Price = 2 });
            products.Add(new Product() { ID = 3, Name = "Product 3", Description = "Description 3", Price = 3 });
            products.Add(new Product() { ID = 4, Name = "Product 4", Description = "Description 4", Price = 4 });
            products.Add(new Product() { ID = 5, Name = "Product 5", Description = "Description 5", Price = 5 });

            //foreach (var result in _productsEntities.Products)
            //{
            //    Product product = new Product
            //    {
            //        ID = result.ID,
            //        Name = result.Name,
            //        Description = result.Description,
            //        Price = result.Price
            //    };

            //    products.Add(product);
            //}

            return products;
        }
    }
}

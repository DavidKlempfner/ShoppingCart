using System.Collections.Generic;
using ShoppingCart.API.DataAccess;
using ShoppingCart.API.DataAccess.Abstract;
using Entities;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace ShoppingCart.API.Services.Tests
{
    [TestFixture]
    public class ShoppingCartApiServicesTests
    {
        //[Test]
        //public void WhenProductsAreRetrievedExpectCorrectlyMappedProducts()
        //{
        //    //Arrange            
        //    List<Product> products = new List<Product>()
        //    {
        //        new Product { ID = 1, Name = "Name1", Description = "desc1", Price = 1.1M },
        //        new Product { ID = 2, Name = "Name2", Description = "desc2", Price = 2.2M }
        //    };
        //    Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
        //    mock.Setup(m => m.GetProducts()).Returns(products);

        //    ProductsApiService productsService = new ProductsApiService(mock.Object);

        //    //Act
        //    List<ProductDto> productDtos = productsService.GetProducts();

        //    //Assert
        //    Assert.IsNotNull(productDtos);
        //    Assert.IsNotEmpty(productDtos);
        //    Assert.IsTrue(productDtos.Count == products.Count);
        //    Assert.IsTrue(productDtos.First().ID == products.First().ID);
        //}
    }
}

using System.Collections.Generic;
using ShoppingCart.API.DataAccess.Repository;
using Moq;
using NUnit.Framework;

namespace ShoppingCart.API.DataAccess.Tests
{
    [TestFixture]
    public class DataAccessTests
    {
        [Test]
        public void WhenGetProductsIsCalledExpectListOfProduct()
        {
            //Arrange
            ProductsRepository productsRepository = new ProductsRepository();

            //Act
            List<Product> products = productsRepository.GetProducts();

            //Assert
            Assert.IsNotNull(products);
            Assert.IsTrue(products.Count > 0);            
        }
    }
}

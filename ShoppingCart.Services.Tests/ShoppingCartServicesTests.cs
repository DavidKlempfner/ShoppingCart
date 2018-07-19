using System;
using System.Collections.Generic;
using Entities;
using Moq;
using NUnit.Framework;
using RestSharp;
using System.Linq;

namespace ShoppingCart.Services.Tests
{
    [TestFixture]
    public class ShoppingCartServicesTests
    {
        [Test]
        public void WhenApiIsCalledExpectProductsReturned()
        {
            //Arrange
            string json = "[{\"ID\":1,\"Name\":\"Cranks\",\"Description\":\"Best cranks for trials riding\",\"Price\":10.0000},{\"ID\":2,\"Name\":\"Tyre\",\"Description\":\"Pimp gusset tyre\",\"Price\":14.5000},{\"ID\":3,\"Name\":\"Sadel\",\"Description\":\"Bike sadel\",\"Price\":22.1000}]";
            Mock <IRestResponse> restResponseMock = new Mock<IRestResponse>();
            restResponseMock.Setup(m => m.Content).Returns(json);

            Mock<IRestClient> restClientMock = new Mock<IRestClient>();
            restClientMock.Setup(m => m.Execute(It.IsAny<IRestRequest>())).Returns(restResponseMock.Object);

            ProductsService productsService = new ProductsService(restClientMock.Object);

            //Act
            List<ProductDto> products = productsService.GetProductsFromEndpoint();

            //Assert
            Assert.IsNotNull(products);
            Assert.AreEqual(3, products.Count);
            Assert.AreEqual(1, products.First().ID);
        }
    }
}

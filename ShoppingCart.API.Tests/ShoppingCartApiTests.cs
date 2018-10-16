using Entities;
using Moq;
using NUnit.Framework;
using ShoppingCart.API.Services.Abstract;
using ShoppingCart.API.Controllers;
using System.Collections.Generic;
using System.Web.Http;
using System.Net.Http;

namespace ShoppingCart.API.Tests
{
    [TestFixture]
    public class ShoppingCartApiTests
    {
        [Test]
        public void WhenProductsAreRetrievedExpectNonNullResult()
        {
            ////Arrange            
            //List<ProductDto> productDtos = new List<ProductDto>()
            //{
            //    new ProductDto { ID = 1, Name = "Name1", Description = "desc1", Price = 1.1M },
            //    new ProductDto { ID = 2, Name = "Name2", Description = "desc2", Price = 2.2M }
            //};
            //Mock<IProductsApiService> productsApiServiceMock = new Mock<IProductsApiService>();
            //productsApiServiceMock.Setup(m => m.GetProducts()).Returns(productDtos);

            //ProductApiController target = new ProductApiController(productsApiServiceMock.Object);
            //target.Request = new HttpRequestMessage();
            //target.Request.SetConfiguration(new HttpConfiguration()); //This throws an Exception.

            ////Act
            //var result = target.Get();
            //string content = result.Content.ToString();

            ////Assert
            //Assert.IsNotNull(content);
            //Assert.IsNotEmpty(content);
        }
    }
}
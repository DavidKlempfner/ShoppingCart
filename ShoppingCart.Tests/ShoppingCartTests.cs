using System;
using System.Collections.Generic;
using Entities;
using Moq;
using ShoppingCart.Controllers;
using ShoppingCart.Services.Abstract;
using System.Web.Mvc;
using NUnit.Framework;

namespace ShoppingCart.Tests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void WhenProductControllerIsCalledExpectProducts()
        {
            //Arrange
            List<ProductDto> productDtos = new List<ProductDto>()
            {
                new ProductDto { ID = 1, Name = "Name1", Description = "desc1", Price = 1.1M },
                new ProductDto { ID = 2, Name = "Name2", Description = "desc2", Price = 2.2M }
            };
            Mock<IProductsService> mock = new Mock<IProductsService>();
            mock.Setup(m => m.GetProductsFromEndpoint()).Returns(productDtos);
            ProductController productController = new ProductController(mock.Object);

            //Act
            ViewResult result = (ViewResult)productController.Index();
            List<ProductDto> model = (List<ProductDto>)result.Model;

            //Assert
            Assert.AreEqual(model.Count, productDtos.Count);
        }
    }
}

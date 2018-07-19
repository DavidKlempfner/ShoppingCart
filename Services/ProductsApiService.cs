using AutoMapper;
using ShoppingCart.API.DataAccess;
using ShoppingCart.API.DataAccess.Abstract;
using Entities;
using ShoppingCart.API.Services.Abstract;
using System.Collections.Generic;

namespace ShoppingCart.API.Services
{
    public class ProductsApiService : IProductsApiService
    {
        private IProductsRepository _productsRepository;
        public ProductsApiService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public List<ProductDto> GetProducts()
        {
            List<Product> products = _productsRepository.GetProducts();

            var productDtos = Mapper.Map<List<Product>, List<ProductDto>>(products);

            return productDtos;
        }
    }
}

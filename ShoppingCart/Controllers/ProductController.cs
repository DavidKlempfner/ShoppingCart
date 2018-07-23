using Entities;
using ShoppingCart.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        private IProductsService _productsService;
        public ProductController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public ActionResult Index()
        {
            List<ProductDto> products = _productsService.GetProductsFromEndpoint();
            return View(products);
        }
    }
}
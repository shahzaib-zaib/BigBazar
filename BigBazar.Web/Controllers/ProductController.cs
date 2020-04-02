using BigBazar.Entities;
using BigBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigBazar.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable()
        {
            var products = productsService.GetProducts();
            return View(products);
        }
         [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }

    }
}
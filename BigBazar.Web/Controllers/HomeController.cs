using BigBazar.Services;
using BigBazar.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigBazar.Web.Controllers
{
    public class HomeController : Controller
    {
        CategoriesService categoriesService = new CategoriesService();
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();

            models.FeaturedCategories = categoriesService.GetFeaturedCategories();
            return View(models);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
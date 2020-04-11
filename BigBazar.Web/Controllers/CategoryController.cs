using BigBazar.Entities;
using BigBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigBazar.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoryService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }

        public ActionResult CategoryTable()
        {
            return HttpNotFound();
        }

        #region Creation

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryService.SaveCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryService.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        #endregion

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            categoryService.DeleteCategory(category.ID);
            return RedirectToAction("CategoryTable");
        }
    }
}
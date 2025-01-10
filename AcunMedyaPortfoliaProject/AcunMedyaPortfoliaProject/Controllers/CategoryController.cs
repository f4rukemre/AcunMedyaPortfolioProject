using AcunMedyaPortfoliaProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        DbPortfolioEntities1 db = new DbPortfolioEntities1();


        public ActionResult CategoryList()
        {
            var categorylist = db.Categories.ToList();
            return View(categorylist);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Categories category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = db.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Categories category)
        {
            var updatedCategory=db.Categories.Find(category.Id);
            updatedCategory.Name=category.Name;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}
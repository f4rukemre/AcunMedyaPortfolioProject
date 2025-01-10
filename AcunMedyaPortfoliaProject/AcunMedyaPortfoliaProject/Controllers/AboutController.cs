using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;

namespace AcunMedyaPortfoliaProject.Controllers
{

    public class AboutController : Controller
    {
        DbPortfolioEntities1 db = new DbPortfolioEntities1();

        public ActionResult AboutList()
        {
            var aboutList = db.About.ToList();
            return View(aboutList);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            db.About.Add(about);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public ActionResult DeleteAbout(int id)
        {
            var about = db.About.Find(id);
            db.About.Remove(about);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = db.About.Find(id);
            return View(about);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var updatedAbout=db.About.Find(about.AboutID);
            updatedAbout.Title = about.Title;
            updatedAbout.Description = about.Description;
            updatedAbout.ImageUrl=about.Description;
            updatedAbout.CVLink=about.CVLink;
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
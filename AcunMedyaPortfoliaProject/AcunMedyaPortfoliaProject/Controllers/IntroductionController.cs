using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class IntroductionController : Controller
    {
        DbPortfolioEntities1 db = new DbPortfolioEntities1();  
      
        public ActionResult IntroductionList()
        {
            var introduction = db.Introduction.ToList();
            return View(introduction);
        }
        [HttpGet]
        public ActionResult CreateIntroduction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateIntroduction(Introduction introduction)
        {
            db.Introduction.Add(introduction);
            db.SaveChanges();
            return RedirectToAction("IntroductionList");
        }
        public ActionResult DeleteIntroduction(int id)
        {
            var introduction=db.Introduction.Find(id);
            db.Introduction.Remove(introduction);
            db.SaveChanges();
            return RedirectToAction("IntroductionList");
        }
        [HttpGet]
        public ActionResult UpdateIntroduction(int id)
        {
            var introduction = db.Introduction.Find(id);
            return View(introduction);
        }
        [HttpPost]
        public ActionResult UpdateIntroduction(Introduction introduction)
        {
            var updatedIntroduction = db.Introduction.Find(introduction.ID);
            updatedIntroduction.Title = introduction.Title;
            updatedIntroduction.Description = introduction.Description;
            db.SaveChanges();
            return RedirectToAction("IntroductionList");
            
        }

    }
}
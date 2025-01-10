using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class ExpertiseController : Controller
    {
        DbPortfolioEntities1 db=new DbPortfolioEntities1();
        public ActionResult ExpertiseList()
        {
            var expertiseList=db.Expertise.ToList();
            return View(expertiseList);
        }
        [HttpGet]
        public ActionResult CreateExpertise()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExpertise(Expertise expertise)
        {
            db.Expertise.Add(expertise);
            db.SaveChanges();
            return RedirectToAction("ExpertiseList");
        }
        public ActionResult DeleteExpertise(int id)
        {
            var expertise=db.Expertise.Find(id);
            db.Expertise.Remove(expertise);
            db.SaveChanges();
            return RedirectToAction("ExpertiseList");
        }
        [HttpGet]
        public ActionResult UpdateExpertise(int id)
        {
            var expertise=db.Expertise.Find(id);
            return View(expertise);
        }
        [HttpPost]
        public ActionResult UpdateExpertise(Expertise expertise)
        {
            var updatedExpertise=db.Expertise.Find(expertise.ExpertiseId);
            updatedExpertise.Title = expertise.Title;
            db.SaveChanges();
            return RedirectToAction("ExpertiseList");
        }
    }
}
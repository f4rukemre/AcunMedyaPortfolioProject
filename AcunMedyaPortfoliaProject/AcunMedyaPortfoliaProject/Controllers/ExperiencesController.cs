using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class ExperiencesController : Controller
    {
        DbPortfolioEntities1 db=new DbPortfolioEntities1();
        public ActionResult ExperienceList()
        {
            var experienceList=db.Experiences.ToList();
            return View(experienceList);
        }
        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(Experiences experiences)
        {
            db.Experiences.Add(experiences);
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public ActionResult DeleteExperience(int id)
        {
            var experience=db.Experiences.Find(id);
            db.Experiences.Remove(experience);
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var experience= db.Experiences.Find(id);
            return View(experience);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Experiences experiences)
        {
            var updatedExperience=db.Experiences.Find(experiences.ID);
            updatedExperience.Title = experiences.Title;
            updatedExperience.CompanyName = experiences.CompanyName;
            updatedExperience.StartDate = experiences.StartDate;
            updatedExperience.EndDate = experiences.EndDate;
            updatedExperience.Description = experiences.Description;
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
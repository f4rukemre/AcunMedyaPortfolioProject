using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class EducationsController : Controller
    {
        DbPortfolioEntities1 db = new DbPortfolioEntities1();
        public ActionResult EducationList()
        {
            var educationList = db.Educations.ToList();
            return View(educationList);
        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(Educations educations)
        {
            db.Educations.Add(educations);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public ActionResult DeleteEducation(int id)
        {
            var education = db.Educations.Find(id);
            db.Educations.Remove(education);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var education = db.Educations.Find(id);
            return View(education);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Educations education)
        {
            var updatedEducation = db.Educations.Find(education.Id);
            updatedEducation.Title = education.Title;
            updatedEducation.InstutionName = education.InstutionName;
            updatedEducation.StartDate = education.StartDate;
            updatedEducation.EndDate = education.EndDate;
            updatedEducation.Description = education.Description;
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;
namespace AcunMedyaPortfoliaProject.Views
{
    public class StatisticsController : Controller
    {
        DbPortfolioEntities1 db=new DbPortfolioEntities1();
        public ActionResult Statistics()
        {
            var totalProjects=db.Projects.Count();
            var totalCategories=db.Categories.Count();
            var totalExperiences=db.Experiences.Count();

            ViewBag.Totalprojects = totalProjects;
            ViewBag.TotalCategories = totalProjects;
            ViewBag.TotalExperiences = totalExperiences;

            return View();
        }
    }
}
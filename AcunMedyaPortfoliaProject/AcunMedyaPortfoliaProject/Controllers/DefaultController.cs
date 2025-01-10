using AcunMedyaPortfoliaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class DefaultController : Controller
    {
        DbPortfolioEntities1 db=new DbPortfolioEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSiteHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialIntro()
        {
            var ıntro = db.Introduction.FirstOrDefault();
            return PartialView(ıntro);
        }
        public PartialViewResult PartialAbout()
        {
            var about=db.About.FirstOrDefault();
            return PartialView(about);
        }
        public PartialViewResult PartialExperience()
        {
            var experiences=db.Experiences.ToList();
            return PartialView(experiences);
        }
        public PartialViewResult PartialEducation()
        {
            var educations=db.Educations.ToList();
            return PartialView(educations);
        }
        public PartialViewResult PartialProject()
        {
            var project=db.Projects.ToList();
            return PartialView(project);
        }
        public PartialViewResult PartialTestimonial()
        {
            var testimoniols=db.Testimonials.ToList();  
            return PartialView(testimoniols);
        }
        public PartialViewResult PartialExpertise()
        {
            var expertise=db.Expertise.FirstOrDefault();
            return PartialView(expertise);
        }
        public PartialViewResult PartialContact()
        {
            var contact=db.Contact.ToList();
            return PartialView(contact);
        }
        public PartialViewResult SocialMedia()
        {
            var socialMedia = db.SocialMedia.ToList();
            return PartialView(socialMedia);
        }
        public PartialViewResult LowerSocialMedia()
        {
            var lowerSocialMedia=db.SocialMedia.ToList();
            return PartialView(lowerSocialMedia);
        }
        public PartialViewResult PartialFooter()
        {
            var categories=db.Categories.ToList();
            ViewBag.Categories = categories;
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}
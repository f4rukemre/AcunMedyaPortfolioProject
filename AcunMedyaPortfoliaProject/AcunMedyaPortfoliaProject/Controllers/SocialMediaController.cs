using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class SocialMediaController : Controller
    {
        DbPortfolioEntities1 db=new DbPortfolioEntities1();
        public ActionResult SocialMediaList()
        {
            var socialMedia=db.SocialMedia.ToList();
            return View(socialMedia);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            db.SocialMedia.Add(socialMedia);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var socialMedia = db.SocialMedia.Find(id);
            db.SocialMedia.Remove(socialMedia);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var socialMedia=db.SocialMedia.Find(id);
            return View(socialMedia);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var updatedSocial=db.SocialMedia.Find(socialMedia.SocialMediaId);
            updatedSocial.Platform = socialMedia.Platform;
            updatedSocial.Link = socialMedia.Link;
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
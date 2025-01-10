using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfoliaProject.Models;

namespace AcunMedyaPortfoliaProject.Controllers
{
    public class ContactController : Controller
    {
        DbPortfolioEntities1 db = new DbPortfolioEntities1();

        public ActionResult ContactList()
        {
            var concactList = db.Contact.ToList();
            return View(concactList);
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        public ActionResult DeleteContact(int id)
        {
            var contact = db.Contact.Find(id);
            db.Contact.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var contact =db.Contact.Find(id);
            return View(contact);
        }
        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            var updatedContact=db.Contact.Find(contact.ContactID);
            updatedContact.Phone = contact.Phone;
            updatedContact.MailAdress = contact.MailAdress;
            updatedContact.Adress = contact.Adress;
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }

    }
}
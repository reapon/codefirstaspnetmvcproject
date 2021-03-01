using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CodeFirstProject_Ashraful.Models;

namespace CodeFirstProject_Ashraful.Controllers
{
    public class CustomerRegistrationController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();


        // GET: CustomerRegistration
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerRegistration customer)
        {
            if (ModelState.IsValid)
            {
                db.CustomerRegistrations.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Success");
            }
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
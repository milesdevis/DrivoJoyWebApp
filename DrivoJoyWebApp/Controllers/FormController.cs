using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrivoJoyWebApp.Models;

namespace DrivoJoyWebApp.Controllers

{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form_29(RTOFormDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
           

            return View(model);
        }

        [HttpPost]
        public ActionResult Form_28(RTOFormDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
           
            return View(model);
        }

        [HttpPost]
        public ActionResult Form_30(RTOFormDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
            

            return View(model);
        }


        [HttpPost]
        public ActionResult Submit(RTOFormDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
           

            return View();
        }
    }
}
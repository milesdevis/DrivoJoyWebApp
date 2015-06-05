using DrivoJoyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrivoJoyWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new HomeViewModel();
            model.LocationFilter = GetLocations();
            model.MakeFilter = GetMakes();
            model.BodyTypeFilter = GetBodyTypes();
            model.ModelFilter = GetModels();

            return View(model);
        }

        /// <summary>
        /// Fetch the locations from the backend
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SelectListItem> GetLocations()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="Bangalore"},
                new SelectListItem(){ Value="2", Text="Chennai"},
                new SelectListItem(){ Value="3", Text="Hyderabad"},
                new SelectListItem(){ Value="4", Text="Mumbai"},
                new SelectListItem(){ Value="5", Text="Pune"},
                new SelectListItem(){ Value="6", Text="Chennai"},
                new SelectListItem(){ Value="7", Text="Hyderabad"},
                new SelectListItem(){ Value="8", Text="Mumbai"},
                new SelectListItem(){ Value="9", Text="Bangalore"},
                new SelectListItem(){ Value="10", Text="Chennai"},
                new SelectListItem(){ Value="11", Text="Hyderabad"},
                new SelectListItem(){ Value="12", Text="Mumbai"}
            };

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SelectListItem> GetMakes()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="BMW"},
                new SelectListItem(){ Value="2", Text="AUDI"},
                new SelectListItem(){ Value="3", Text="JAGUAR"},
                new SelectListItem(){ Value="4", Text="BENTLY"},
            };

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SelectListItem> GetBodyTypes()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="SUV"},
                new SelectListItem(){ Value="2", Text="Convertible"},
                new SelectListItem(){ Value="3", Text="Sports"},
                new SelectListItem(){ Value="4", Text="Automatic"},
            };

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SelectListItem> GetModels()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="Blah"},
                new SelectListItem(){ Value="2", Text="Bloop"},
                new SelectListItem(){ Value="3", Text="Bleep"},
                new SelectListItem(){ Value="4", Text="BadumTish"},
            };

            return list;
        }

        [HttpPost]
        public ActionResult BrowseCars(HomeViewModel model)
        {
            if (ModelState.IsValid)
            { 
                // Send thequery to DB
            }
            return RedirectToAction("Index", "Buy", new {
                LocationID = model.SelectedLocationId,
                MakeID = model.SelectedMakeId,
                BodyTypeID = model.SelectedBodyTypeId,
                ModelID = model.SelectedModelId

            });
        }
    }
}
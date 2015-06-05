using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrivoJoyWebApp.Models
{
    public class HomeViewModel
    {
        //public FiltersViewModel Filters { get; set; }

        [Display(Name = "Location")]
        public int SelectedLocationId { get; set; }
        public IEnumerable<SelectListItem> LocationFilter { get; set; }

        [Display(Name = "Make")]
        public int SelectedMakeId { get; set; }
        public IEnumerable<SelectListItem> MakeFilter { get; set; }

        [Display(Name = "Model")]
        public int SelectedModelId { get; set; }
        public IEnumerable<SelectListItem> ModelFilter { get; set; }

        [Display(Name = "BodyType")]
        public int SelectedBodyTypeId { get; set; }
        public IEnumerable<SelectListItem> BodyTypeFilter { get; set; }

        //public IList<string> Testimonials { get; set; }
        
        
        public HomeViewModel()
        {
            //LocationFilter = new List<Location>();
            //MakeFilter = new List<Make>();
            //ModelFilter = new List<Model>();
            //BodyTypeFilter = new List<BodyType>();
            //Testimonials = new List<String>();
        }
    }
}
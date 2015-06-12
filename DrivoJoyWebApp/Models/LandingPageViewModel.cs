using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrivoJoyWebApp.Models.FormDetailsFolder;

namespace DrivoJoyWebApp.Models
{
    public class LandingPageViewModel
    {
        public FormSelected form_selected {get; set;}
        public SellerRTO seller_rto {get; set;}
        public BuyerRTO buyer_rto {get; set; }
    }
}  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrivoJoyWebApp.Models.FormDetailsFolder;

namespace DrivoJoyWebApp.Models
{
    public class BuyFormViewModel
    {
        public SellerFullName seller_full_name{ set; get;}
        public Seller_Son_Wife_Daughter_Of seller_son_wife_daughter_of {set; get;}
        public BuyerFullName buyer_full_name {get; set;}
        public DateOfTransfer date_of_tranfser {set; get;}
        public RegistrationMark registration_mark {set; get;}
        public Buyer_Son_Wife_Daughter_Of  buyer_son_wife_daughter_of {set; get;}
        public BuyerAddress buyer_address {set; get;}
    }
}
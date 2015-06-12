using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrivoJoyWebApp.Models.FormDetailsFolder;


namespace DrivoJoyWebApp.Models
{
    public class SellFormViewModel
    {
        public SellerFullName seller_full_name { set; get; }
        public Buyer_Son_Wife_Daughter_Of buyer_son_wife_daughter_of { set; get; }
        public BuyerFullName buyer_full_name { set; get; }
        public DateOfTransfer date_of_tranfer { set; get; }
        public VehicleNumber vehicle_number { set; get; }
        public ChassisNumber chassis_number { set; get; }
        public EngineNumber engine_number { set; get; }
        public SellerAddress seller_address { set; get; }
        public BuyerAddress buyer_address { set; get; }
    }
}
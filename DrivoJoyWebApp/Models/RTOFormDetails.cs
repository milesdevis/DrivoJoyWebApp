using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrivoJoyWebApp.Models
{
    public class RTOFormDetails
    {
        public int TransactionID { get; set; } 
        public string FormSelected {get; set;}
 public string SellerRTO {get; set;}
public string BuyerRTO {get; set;}
 public string SellerFullName {get; set;}
public string  Seller_Son_Wife_Duaghter_Of {get; set;}
public string Buyer_Son_Wife_Duaghter_Of {get; set;}
public string  BuyerFullName {get; set;}
public string DateOfTransfer {get; set;}
 public string VehicleNumber {get; set;}
public string ChassisNumber {get; set;}
 public string RegistrationMark {get; set;}
 public string EngineNumber {get; set;}      //Is this string?
 public string SellerAddress {get; set;}
 public string BuyerAddress {get; set;}
 public string Make {get; set;}

    }
}
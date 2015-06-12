using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrivoJoyWebApp.Models.FormDetailsFolder;

namespace DrivoJoyWebApp.Models
{
    public class ExtraFormViewModel
    {
        public BuyerFullName BuyerFullName { get; set; }
        public SellerFullName SellerFullName { get; set; }
        public Seller_Son_Wife_Daughter_Of Seller_Son_Wife_Daughter_Of { get; set; }
        public VehicleNumber VehicleNumber { get; set; }
        public EngineNumber EngineNumber { get; set; }
        public ChassisNumber ChassisNumber { get; set; }
        public PeriodOfStayInState PeriodOfStayInState { get; set; }
        public PeriodUptoWhichVehicleTaxPaid PeriodUptoWhichVehicleTaxPaid { get; set; }
        public PendingTaxDetails PendingTaxDetails { get; set; }
        public IsInvolvedInTheft IsInvolvedInTheft { get; set; }
        public IsSection53_54_55Pending IsSection53_54_55Pending { get; set; }
        public IsInvolvedInProhibitedGoods IsInvolvedInProhibitedGoods { get; set; }
        public IsUnderAgreement IsUnderAgreement { get; set; }

    }
}
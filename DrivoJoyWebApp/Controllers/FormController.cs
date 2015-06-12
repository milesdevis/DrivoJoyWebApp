using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrivoJoyWebApp.Models;
using DrivoJoyWebApp.Models.FormDetailsFolder;

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
        public ActionResult Form_29(string [] model)
        {
            LandingPageViewModel a = new LandingPageViewModel();
            BuyerRTO b = new BuyerRTO();
            b.buyer_RTO = model[2];

            SellerRTO c = new SellerRTO();
            c.seller_RTO = model[1];

            FormSelected d = new FormSelected();
            d.form_selected = model[0];

            a.buyer_rto = b;
            a.form_selected = d;
            a.seller_rto = c;

            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
           

            return View(a);
        }

        [HttpPost]
        public ActionResult Form_28(string[] model)
        {
            LandingPageViewModel a = new LandingPageViewModel();
            BuyerRTO b = new BuyerRTO();
            b.buyer_RTO = model[2];

            SellerRTO c = new SellerRTO();
            c.seller_RTO = model[1];

            FormSelected d = new FormSelected();
            d.form_selected = model[0];

            a.buyer_rto = b;
            a.form_selected = d;
            a.seller_rto = c;

            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
           
            return View(model);
        }

        [HttpPost]
        public ActionResult Form_30(string[] model)
        {
            LandingPageViewModel a = new LandingPageViewModel();
            BuyerRTO b = new BuyerRTO();
            b.buyer_RTO = model[2];

            SellerRTO c = new SellerRTO();
            c.seller_RTO = model[1];

            FormSelected d = new FormSelected();
            d.form_selected = model[0];

            a.buyer_rto = b;
            a.form_selected = d;
            a.seller_rto = c;

            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
            

            return View(model);
        }


        [HttpPost]
        public ActionResult SellSubmit(string[] model)
        {
            SellFormViewModel a = new SellFormViewModel();
            SellerFullName b = new SellerFullName();
            b.seller_full_name = model[0];

            Buyer_Son_Wife_Daughter_Of c = new Buyer_Son_Wife_Daughter_Of();
            c.buyer_son_wife_daughter_of = model[1];

            BuyerFullName d = new BuyerFullName();
            d.buyer_full_name = model[2];

            DateOfTransfer e = new DateOfTransfer();
            e.date_of_transfer = model[3];

            VehicleNumber f = new VehicleNumber();
            f.vehicle_number = model[4];

            ChassisNumber g = new ChassisNumber();
            g.chassis_number = model[5];

            EngineNumber h = new EngineNumber();
            h.engine_number = model[6];

            SellerAddress i = new SellerAddress();
            i.seller_address = model[7];

            BuyerAddress j = new BuyerAddress();
            j.buyer_address = model[8];

            a.buyer_address = j;
            a.buyer_full_name = d;
            a.buyer_son_wife_daughter_of = c;
            a.chassis_number = g;
            a.date_of_tranfer = e;
            a.engine_number = h;
            a.seller_address = i;
            a.seller_full_name = b;
            a.vehicle_number = f;
            
           
            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
           

            return View();
        }

        [HttpPost]
        public ActionResult BuySubmit(string[] model)
        {
            BuyFormViewModel a = new BuyFormViewModel();
            SellerFullName b = new SellerFullName();
            b.seller_full_name = model[0];

            Seller_Son_Wife_Daughter_Of c = new Seller_Son_Wife_Daughter_Of();
            c.seller_son_wife_daughter_of = model[1];

            BuyerFullName d = new BuyerFullName();
            d.buyer_full_name = model[2];

            DateOfTransfer e = new DateOfTransfer();
            e.date_of_transfer = model[3];

            RegistrationMark f = new RegistrationMark();
            f.registration_mark = model[4];

            Buyer_Son_Wife_Daughter_Of g = new Buyer_Son_Wife_Daughter_Of();
            g.buyer_son_wife_daughter_of = model[5];

            BuyerAddress h = new BuyerAddress();
            h.buyer_address = model[6];


            a.seller_full_name = b;
            a.seller_son_wife_daughter_of = c;
            a.buyer_full_name = d;
            a.date_of_tranfser = e;
            a.registration_mark = f;
            a.buyer_son_wife_daughter_of = g;
            a.buyer_address = h;

            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }


            return View();
        }

        [HttpPost]
        public ActionResult ExtraSubmit(string[] model)
        {
            ExtraFormViewModel a = new ExtraFormViewModel(); //Continue from here
            BuyerFullName b = new BuyerFullName();
            b.buyer_full_name = model[0];

            SellerFullName c = new SellerFullName();
            c.seller_full_name = model[1];

            Seller_Son_Wife_Daughter_Of d = new Seller_Son_Wife_Daughter_Of();
            d.seller_son_wife_daughter_of = model[2];

            VehicleNumber e = new VehicleNumber();
            e.vehicle_number = model[3];

            EngineNumber f = new EngineNumber();
            f.engine_number = model[4];

            ChassisNumber g = new ChassisNumber();
            g.chassis_number = model[5];

            PeriodOfStayInState h = new PeriodOfStayInState();
            h.period_of_stay_in_state = model[6];

            PeriodUptoWhichVehicleTaxPaid i = new PeriodUptoWhichVehicleTaxPaid();
            i.period_upto_which_vehicle_tax_paid = model[7];

            PendingTaxDetails j = new PendingTaxDetails();
            j.pending_tax_details = model[8];

            IsInvolvedInTheft k = new IsInvolvedInTheft();
            k.is_involved_in_theft = model[9];

            IsSection53_54_55Pending l = new IsSection53_54_55Pending();
            l.is_section53_54_55pending = model[10];

            IsInvolvedInProhibitedGoods m = new IsInvolvedInProhibitedGoods();
            m.is_involved_in_prohibited_goods = model[11];


            a.BuyerFullName = b;
            a.SellerFullName = c;
            a.Seller_Son_Wife_Daughter_Of = d;
            a.VehicleNumber = e;
            a.EngineNumber = f;
            a.ChassisNumber = g;
            a.PeriodOfStayInState = h;
            a.PeriodUptoWhichVehicleTaxPaid = i;
            a.PendingTaxDetails = j;
            a.IsInvolvedInTheft = k;
            a.IsSection53_54_55Pending = l;
            a.IsInvolvedInProhibitedGoods = m;


            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }


            return View();
        }
    }
}
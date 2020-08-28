using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BussinessCardManagement.Entities;
using BussinessCardManagement.BL;
using System.Web.Mvc;
using System.Dynamic;

namespace BussinessCardManagement.PL.Controllers
{
    public class BussinessController : Controller
    {
        BussinessCardBO bo = new BussinessCardBO();
        // GET: Bussiness
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBussinessCard()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.locationList = bo.DisplayLocationDetails();
            return View(mymodel);
        }
        public ActionResult AddBussinessCardDetails(string Name, long Phone_no, string Email_Id, int Location_Id, string Bussiness_Type, string Competency, string Designation, int No_of_cards)
        {
            //try
            //{
                BussinessCard bussinessCard = new BussinessCard();
                bussinessCard.Name = Name;
                bussinessCard.Phone_no = Phone_no;
                bussinessCard.Email_Id = Email_Id;
                bussinessCard.Location_Id = Location_Id;
                bussinessCard.Bussiness_Type = Bussiness_Type;
                bussinessCard.Competency = Competency;
                bussinessCard.Designation = Designation;
                bussinessCard.No_of_cards = No_of_cards;

                bo.AddBussinessCardDetails(bussinessCard);
                return View("success");
            }
        //    catch (Exception e)
        //    {
        //        ViewBag.Message = e.Message;
        //        return View("Error");

        //    }
        //}

        public ActionResult Preview()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.locationList = bo.DisplayLocationDetails();
            return View(mymodel);

           
        }
        public ActionResult Preview1(string Name, long Phone_no, string Email_Id, int Location_Id, string Bussiness_Type, string Competency, string Designation, int No_of_cards)
        {
            BussinessCard bussinessCard = new BussinessCard();
            bussinessCard.Name = Name;
            bussinessCard.Phone_no = Phone_no;
            bussinessCard.Email_Id = Email_Id;
            bussinessCard.Location_Id = Location_Id;
            bussinessCard.Bussiness_Type = Bussiness_Type;
            bussinessCard.Competency = Competency;
            bussinessCard.Designation = Designation;
            bussinessCard.No_of_cards = No_of_cards;
            return View(bussinessCard);
        }

        //public ActionResult GettingoldRequests()
        //{
        //    List<BussinessCard> list = bo.GettingoldRequests();
        //    return View(list)
        //}

      



        public ActionResult AddLocation()
        {
            return View();
        }
        public ActionResult AddLocationDetails(int Location_Id, string LocationName, string Address)
        {
            //try
            //{
              Location location = new Location();
                location.Location_Id = Location_Id;
                location.LocationName = LocationName;
                location.Address = Address;
                bo.AddLocationDetails(location);
                return View("success");
            }
            //catch (Exception e)
            //{
            //    ViewBag.Message = e.Message;
            //    return View("Error");

            //}

        //}
    

        //public ActionResult DisplayLocationDetails()
        //{
        //    List<Location> list = new List<Location>();
        //   list= bo.DisplayLocationDetails();
        //    return View(list);
        //}

        public ActionResult DisplayBussinessCardDetails()
        {
            List<BussinessCard> list = new List<BussinessCard>();
            list = bo.DisplayBussinessCardDetails();
            return View(list);
        }
    }
    }

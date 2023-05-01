using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace addingFieldsLogin.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult MainHome() //The main home page goes in this view 
        {

            return View();
        }
        public ActionResult CalculatorHome() //Calculator home page goes here in this view 
        {

            return View(); 
        }
        public ActionResult Index() // This is the route config view that it always loads to Home/Index
        {
            if (User.IsInRole("AdminRole"))
            {
                return View("AdminHome"); 

            }else if (User.IsInRole("TrainerRole"))
            {
                return View("TrainerHome"); 
            }
            else {

                return View();
            }

        }
        public ActionResult Result() // This is the view for the message box in the calculator home page 
        {

            return View(); 
        }
        public ActionResult testing()
        {
            return View(); 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using addingFieldsLogin.Models;
using Microsoft.AspNet.Identity;
using addingFieldsLogin.Controllers;
using addingFieldsLogin.ViewModels; 

namespace addingFieldsLogin.Controllers
{
    public class GymController : Controller
    {
        private ApplicationDbContext context; 
        public GymController()
        {
            context = new ApplicationDbContext(); 
        }
        
        public ActionResult FormData()
        {
            double weight = 0;
            double height = 0;
            int age = 0;
            string gender = "";

            var vm = new weightheightViewModel
            {
                weight = weight,
                height = height,
                age = age,
                gender = gender
            };

            return View(vm);
        }

        public ActionResult Index(double weight , double height , int age , string gender)
        {
            double BMR;
            string message; 
            if(gender == "Male")
            {
                BMR = 88.362 + (13.38 * weight) + (4.8 * height) - (5.67 * age);
                message = "This is specifically calculated for men "; 
            }
            else
            {
                BMR = 447.59 + (9.24 * weight) + (3.09 * height) - (4.33 * age);
                message = "This is specifically calculated for women ";

            }
            List<string> list = new List<string>();
            list.Add("superperson@gmail.com");
            list.Add("Kylan111@gmail.com");
            list.Add("Trevlinnaicker11@gmail.com");
            list.Add("Kylan111@gmail.com");
            list.Add("superperson@gmail.com"); 
            list.Add("Kylan111@gmail.com"); 

           

            var vm = new CalcSumViewModel
            {
                BMR = BMR,
                message = message,
                em = list
               
            };

            return View(vm);
        }
       
    }
}
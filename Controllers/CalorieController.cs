using addingFieldsLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using addingFieldsLogin.ViewModels; 

namespace addingFieldsLogin.Controllers
{
  
    public class CalorieController : Controller
    {

        private ApplicationDbContext context;
        public CalorieController()
        {
            context = new ApplicationDbContext();
        } 
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        public ActionResult ListCUsers()
        {
            var list = context.calorieDatabase.Where(ee => ee.EmailLogin == User.Identity.Name).Include(cc => cc.gender).Include(dd => dd.useractivity).ToList();

            return View(list);
        }
        public ActionResult CalcCform()
        {
            var vm = new CalorieGenderActivityViewModel
            {
                genderList = context.genderDatabase.ToList(),
                activitylist = context.activityDatabase.ToList()
            };

            return View(vm);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult formsubmit(CalorieUser calorieuser)
        {

            if (!ModelState.IsValid)
            {
                var vm = new CalorieGenderActivityViewModel
                {
                    genderList = context.genderDatabase.ToList(),
                    calorieuser = calorieuser,
                    activitylist = context.activityDatabase.ToList()
                };
                return View("CalcCform", vm);
            }
            calorieuser.log = DateTime.Now;
            calorieuser.EmailLogin = User.Identity.Name;
            
            /*
            var userid = calorieuser.id;

            var userfromdb = context.calorieDatabase.SingleOrDefault(c => c.id == userid); */
            var userfromdb = calorieuser; 

            if (userfromdb == null)
            {
                return HttpNotFound();
            }

            double BMR; 
            double calorieNeeded; 
            string message;

            if (userfromdb.GenderId == 1)

            {
                BMR = 88.362 + (13.38 * userfromdb.weight) + (4.8 * userfromdb.height) - (5.67 * userfromdb.age);
               

                if(userfromdb.UserActivityId == 1)
                {
                    calorieNeeded = BMR; 
                } else if(userfromdb.UserActivityId == 2)
                {
                    calorieNeeded = BMR + 150; 
                }
                else if (userfromdb.UserActivityId == 3)
                {
                    calorieNeeded = BMR + 250; 
                }
                else if (userfromdb.UserActivityId == 4)
                {
                    calorieNeeded = BMR + 350;

                }
                else if (userfromdb.UserActivityId == 5)
                {
                    calorieNeeded = BMR + 450;

                }
                else if (userfromdb.UserActivityId == 6)
                {
                    calorieNeeded = BMR + 550;

                }
                else
                {
                    return HttpNotFound(); 
                }

            }
            else
            {
              BMR = 447.59 + (9.24 * userfromdb.weight) + (3.09 * userfromdb.height) - (4.33 * userfromdb.age);

                if (userfromdb.UserActivityId == 1)
                {
                    calorieNeeded = BMR;

                }
                else if (userfromdb.UserActivityId == 2)
                {
                    calorieNeeded = BMR + 100;
                }
                else if (userfromdb.UserActivityId == 3)
                {
                    calorieNeeded = BMR + 200;
                }
                else if (userfromdb.UserActivityId == 4)
                {
                    calorieNeeded = BMR + 300;

                }
                else if (userfromdb.UserActivityId == 5)
                {
                    calorieNeeded = BMR + 400;

                }
                else if (userfromdb.UserActivityId == 6)
                {
                    calorieNeeded = BMR + 500;

                }
                else
                {
                    return HttpNotFound();
                }

            }
            calorieuser.caloriessum = calorieNeeded; 

            context.calorieDatabase.Add(calorieuser);
            context.SaveChanges();

            var Vm = new CalorieValuesViewModel
            {
                calorieuser = userfromdb,
                caloriesNeeded = calorieNeeded
            };

            return View("CalorieView", Vm);

            // return RedirectToAction("ListUsers", "Users");  
        }
        /*
         1	BMR
2	Sedentary : little or no exercise
3	Light : exercise 1-3 times/week
4	Moderate : exercise 3-5 times/week
5	Active : exercise everyday/intense exercise 3-4 times/week
6	Very Active : intense exercise 6-7 times/week
         */
        public ActionResult delete(int id)
        {
            var fromdb = context.calorieDatabase.SingleOrDefault(c => c.id == id); 
            if(fromdb == null)
            {
                return HttpNotFound(); 
            }
            context.calorieDatabase.Remove(fromdb);
            context.SaveChanges();

            return RedirectToAction("ListCUsers","Calorie"); 
        }
    }
}
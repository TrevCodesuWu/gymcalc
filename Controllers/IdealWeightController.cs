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
    public class IdealWeightController : Controller
    {
        // GET: IdealWeight
        private ApplicationDbContext context; 
        public IdealWeightController()
        {
            context = new ApplicationDbContext(); 
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }
     
        public ActionResult ListIdealWeight()
        {
            var dblist = context.idealweightDatabase.Where(ee => ee.EmailLogin == User.Identity.Name).Include(c => c.gender).ToList(); 

            return View(dblist); 
        }

        public ActionResult IdealWeightform()
        {
            var vm = new GenderIdealWeightViewModel
            {
                genderlistvm = context.genderDatabase.ToList(),

            }; 

            return View(vm);
        }

        [HttpPost]
        public ActionResult formsubmit(IdealWeight idealweightvm)
        {
            if (!ModelState.IsValid)
            {
                var vm = new GenderIdealWeightViewModel
                {
                    genderlistvm = context.genderDatabase.ToList(),
                    idealweightvm = idealweightvm
                }; 

                return View("IdealWeightform",vm); 
            }

            idealweightvm.log = DateTime.Now;
            idealweightvm.EmailLogin = User.Identity.Name;
            
            if(idealweightvm.GenderId == 1)
            {
                idealweightvm.weightsum = idealweightvm.height - 100 - ((idealweightvm.height - 150) / 4); 
            } else
            {
                idealweightvm.weightsum = idealweightvm.height - 100 - ((idealweightvm.height - 150) / 2);
            }

            context.idealweightDatabase.Add(idealweightvm);
            context.SaveChanges();

            var Vm = new IdealWeightSumViewModel
            {
                idealweight = idealweightvm,
                Sum = idealweightvm.weightsum
            }; 
            return View("IdealWeightView",Vm); 
        }

        public ActionResult delete(int id)
        {
            var fromdb = context.idealweightDatabase.SingleOrDefault(c => c.id == id);
            if (fromdb == null)
            {
                return HttpNotFound();
            }
            context.idealweightDatabase.Remove(fromdb);
            context.SaveChanges();

            return RedirectToAction("ListIdealWeight", "IdealWeight");
        }

    }
}
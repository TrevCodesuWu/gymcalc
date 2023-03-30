using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using addingFieldsLogin.Models; 

namespace addingFieldsLogin.ViewModels
{
    public class CalorieGenderActivityViewModel
    {
        public CalorieUser calorieuser { get; set; }
        public IEnumerable<UserActivity> activitylist { get; set; }
        public IEnumerable<Gender> genderList { get; set; }

    }
}
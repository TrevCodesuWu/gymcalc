using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using addingFieldsLogin.Models; 

namespace addingFieldsLogin.ViewModels
{
    public class CalorieValuesViewModel
    {
        public CalorieUser calorieuser { get; set; }

        public double caloriesNeeded { get; set; }

    }
}
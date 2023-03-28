using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using addingFieldsLogin.Models; 

namespace addingFieldsLogin.ViewModels
{
    public class BMIuserViewModel
    {
        public User user_vm { get; set; }
        public double bmi_vm { get; set; }
        public string message_vm { get; set; }

    }
}
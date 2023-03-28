using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using addingFieldsLogin.Models; 


namespace addingFieldsLogin.ViewModels
{
    public class UserGenderViewModel
    {
        public User user { get; set; }
        public IEnumerable<Gender> genderList { get; set; }

    }
}
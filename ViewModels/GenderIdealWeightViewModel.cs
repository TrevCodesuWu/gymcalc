using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using addingFieldsLogin.Models; 

namespace addingFieldsLogin.ViewModels
{
    public class GenderIdealWeightViewModel
    {
        public IEnumerable<Gender> genderlistvm { get; set; }

        public IdealWeight idealweightvm { get; set; }

    }
}
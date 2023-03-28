using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using addingFieldsLogin.Models; 

namespace addingFieldsLogin.ViewModels
{
    public class CalcSumViewModel
    {
        public double BMR { get; set; }
        public string message { get; set; }

        public List<string> em {get; set; } 

    }
    public class weightheightViewModel
    {
        public double weight { get; set; }
        public double height { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
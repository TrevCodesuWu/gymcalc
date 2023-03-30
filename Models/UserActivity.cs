using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace addingFieldsLogin.Models
{
    public class UserActivity
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name ="Activity")]
        public string Activity { get; set; }

    }
}
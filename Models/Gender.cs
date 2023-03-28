using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace addingFieldsLogin.Models
{
    public class Gender
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name ="Gender")]
        public string gender { get; set; }

    }
}
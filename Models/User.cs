using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace addingFieldsLogin.Models
{
    public class User
    {
        [Key] //29  - 300 400 150 150
        public int id { get; set; }
        public string EmailLogin { get; set; } // stores it using login email in the database , hidden in form view displays in logs 

        public DateTime log { get; set; } // done auto , hidden in form view , display in list of logs 
        [Required]
        [Display(Name ="Weight(kg)")]
        public double weight { get; set; } // asking user 
        [Required]
        [Display(Name ="Height(cm)")]
        public double height { get; set; } // asking user 
        [Required]
        [Display(Name ="Age")]
        [Range(1,120,ErrorMessage ="Please choose a realistic age")]
        public int age { get; set; } //asking user 
        public Gender gender { get; set; } // nav prop
        [Required]
        public int GenderId { get; set; } // foreign key 


    }
}
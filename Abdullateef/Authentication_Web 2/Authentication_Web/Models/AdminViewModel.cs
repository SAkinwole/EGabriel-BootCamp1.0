using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Authentication_Web.Models
{
    public class AdminViewModel
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }
        public string Photo { get; set; }

        [Display(Name ="Registered Date")]
        public DateTime CreatedAt { get; set; }
    }
}
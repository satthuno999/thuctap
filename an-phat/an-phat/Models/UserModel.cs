using an_phat.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace an_phat.Models
{
    public  class UserModel
    {
        public int ID { get; set; }

        
        public String UserName { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage = "Vui long nhap email")]
        public String UserEmail { get; set; }
     
        [Required]
        [RegularExpression("^.*(?=.{10,})(?=.*d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$",
            ErrorMessage = "Vui long nhap password")]
        public String UserPassword { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("UserPassword", ErrorMessage = "Confirm password is not correct")]
        public String ConfirmPassword { get; set; }

        public int UserRole { get; set; }

        public int Gender  { get; set; }

        public String Provice { get; set; }
    
        public List<DistrictModel> DistrictList { get; set; }
    }
    
}
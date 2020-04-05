using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blood_Analysis.Models
{
    public class User
    {
        [Key]
       public int UserId { get; set; }
       public string Fname { get; set; }
       public string Lname { get; set; }
        public int age { get; set; }
        public string address { get; set; }
    }
}
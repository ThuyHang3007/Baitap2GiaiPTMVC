using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Baitap2MVC.Models
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }

        public string StudentName { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstProject_Ashraful.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Salary { get; set; }
        public string ImagePath { get; set; }
        [CustomDate(ErrorMessage = "Date must be date after today.")]
        [Display(Name ="Join Date")]
        public string Date { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public Employee()
        {
            ImagePath = "~/AppFiles/Images/noImageUploaded.png";

        }
    }
}
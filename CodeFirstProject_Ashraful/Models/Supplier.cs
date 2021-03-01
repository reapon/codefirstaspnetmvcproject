using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstProject_Ashraful.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }

        [Required(ErrorMessage ="Required")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Required")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]

        public DateTime BirthDate { get; set; }

        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
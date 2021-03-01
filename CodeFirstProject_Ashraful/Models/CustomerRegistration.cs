using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstProject_Ashraful.Models
{
    public partial class CustomerRegistration
    {
        public int CustomerRegistrationID { get; set; }

        [Required(ErrorMessage = "This Field Is Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name should be in between 3-30")]
        [Display(Name ="Full Name")]

        public string CustomerName { get; set; }


        [Required(ErrorMessage = "This Field Is Required")]

        public string Gender { get; set; }


        [Required(ErrorMessage = "This Field Is Required")]
        [EmailAddress]


        public string Email { get; set; }


        [Required(ErrorMessage = "This Field Is Required")]
        [DataType(DataType.PhoneNumber)]

        public int Phone { get; set; }


        [Required(ErrorMessage = "This Field Is Required")]
        [Range(18, 90, ErrorMessage = "Age should be in between 18-90")]


        public int Age { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [RegularExpression(@"[^\s]+",ErrorMessage ="White Space are not allowed")]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
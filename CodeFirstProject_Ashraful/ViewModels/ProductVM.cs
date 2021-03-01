using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstProject_Ashraful.ViewModels
{
    public class ProductVM
    {
        public int ProductID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        
        
        public DateTime EntryDate { get; set; }


        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
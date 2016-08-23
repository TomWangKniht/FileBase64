using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace File64.Models
{
    public class UploadFileViewModel
    {
        [Required]
        public HttpPostedFileBase uploadFile { get; set; }

        //public String fileName { get; set; }
    }
}
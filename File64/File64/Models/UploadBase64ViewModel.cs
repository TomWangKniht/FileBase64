using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace File64.Models
{
    public class UploadBase64ViewModel
    {
        [Required]
        public String base64Code { get; set; }
        [Required]
        public String fileName { get; set; }
    }
}
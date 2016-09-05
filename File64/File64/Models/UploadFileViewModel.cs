using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace File64.Models
{
    public class UploadFileViewModel
    {
        [DisplayName("上傳檔案")]
        [Required]
        public HttpPostedFileBase uploadFile { get; set; }

        //public String fileName { get; set; }
    }
}
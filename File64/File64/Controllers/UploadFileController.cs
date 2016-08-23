using File64.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace File64.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(UploadFileViewModel model)
        {
            return Content("尚未實作");
        }
        //參考
        //http://stackoverflow.com/questions/15680629/mvc-4-razor-file-upload
        public ActionResult GetBase64(UploadFileViewModel model)
        {
            if (ModelState.IsValid)
            {
                byte[] byteData = new byte[model.uploadFile.ContentLength];
                model.uploadFile.InputStream.Read(byteData, 0, byteData.Length);
                var convertString = Convert.ToBase64String(byteData);
                //return Content(convertString);
                var result = new Base64ResultViewModel() { base64Code = convertString };
                return View("Result", result);
            }
                return View("Index",model);
        }
    }
}
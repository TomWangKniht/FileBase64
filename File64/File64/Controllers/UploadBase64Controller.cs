using File64.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace File64.Controllers
{
    public class UploadBase64Controller : Controller
    {
        // GET: UploadBase64
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetFile(UploadBase64ViewModel model)
        {
            if (ModelState.IsValid)
            {
                var contents = Convert.FromBase64String(model.base64Code);
                return File(contents, "application/pdf",model.fileName);
               
            }
            return View("Index", model);
        }
    }
}
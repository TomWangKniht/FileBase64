using File64.Models;
using File64.Service.api;
using File64.Service.impl;
using File64.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace File64.Controllers
{
    public class UploadFileController : Controller
    {
        private IBase64Service service;

        public UploadFileController()
        {
            service = new Base64ServiceImpl();
        }
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
                var convertString = service.getBase64Str(model.uploadFile);
                var result = new Base64ResultViewModel() { base64Code = convertString };
                return View("Result", result);
            }
                return View("Index",model);
        }
        public ActionResult GetBase64Ajax(UploadFileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var convertString = service.getBase64Str(model.uploadFile);
                var result = new Base64ResultViewModel() { base64Code = convertString };
                return Json(result);
            }
            return Json(new { msg="false"});
        }
        //text/plain
        public ActionResult GetBase64File(UploadFileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var convertString = service.getBase64Str(model.uploadFile);
                var fileName = CommonUtil.getDefalutFileName() + ".txt";
                var byteData = CommonUtil.getBytes(convertString);
                return File(byteData, "text/plain", fileName);
            }
            return Json(new { msg = "false" });
        }
    }
}
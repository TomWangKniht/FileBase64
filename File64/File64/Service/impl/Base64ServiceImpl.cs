using File64.Service.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace File64.Service.impl
{
    public class Base64ServiceImpl : IBase64Service
    {
        public string getBase64Str(HttpPostedFileBase uploadFile)
        {
            byte[] byteData = new byte[uploadFile.ContentLength];
            uploadFile.InputStream.Read(byteData, 0, byteData.Length);
            return Convert.ToBase64String(byteData);
        }
    }
}
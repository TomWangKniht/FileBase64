using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace File64.Util
{
    public static class CommonUtil
    {
        public static String getDefalutFileName(){
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public static byte[] getBytes(String str)
        {
            //return Encoding.ASCII.GetBytes(str);
            return Encoding.Default.GetBytes(str);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace File64.Service.api
{
    interface IBase64Service
    {
        String getBase64Str(HttpPostedFileBase uploadFile);
    }
}

using Microsoft.AspNetCore.Mvc;
using SJTech.Core.Models.VD;
using SJTech.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Mvc.Controllers
{
    public class ErrorController : BaseController
    {
        public ActionResult Error()
        {
            Error_ExceptionVD vd = new Error_ExceptionVD()
            {
                //COCONET 暂时隐藏
                //HandleErrorInfo = new HandleErrorInfo(new Exception("发生未知错误，请联系客服！"), "Error", "Error")
            };
            return View(vd);
        }

        public ActionResult Error404(string aspxerrorpath)
        {
            Error_Error404VD vd = new Error_Error404VD()
            {
                Url = aspxerrorpath
            };
            return View(vd);
        }
    }
}

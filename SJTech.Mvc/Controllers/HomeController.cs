using Microsoft.AspNetCore.Mvc;
using SJTech.Mvc.Filter;
using SJTech.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Mvc.Controllers
{
    [MenuFilter("Home")]
    public class HomeController : BaseFrontController
    {

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            var vd = new Home_IndexVD()
            {
            };

            return View(vd);
        }

        public ActionResult Detail(int id)
        {
            var vd = new Home_DetailVD()
            {
            };
            return View(vd);
        }
        public ActionResult List()
        {
            return View();
        }
    }
}

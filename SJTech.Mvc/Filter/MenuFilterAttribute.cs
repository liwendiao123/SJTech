using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SJTech.Core.Models.VD;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Mvc.Filter
{
    public class MenuFilterAttribute : ActionFilterAttribute
    {
        public string CurrentMenu { get; set; }
        public MenuFilterAttribute(string currentMenu)
        {
            CurrentMenu = currentMenu;
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if ((filterContext.Controller as Controller).ViewData.Model is IBaseUiVD model)
            {
                //model.CurrentMenu = model.CurrentMenu ?? CurrentMenu;
                model.CurrentMenu = CurrentMenu;
            }
            base.OnResultExecuting(filterContext);
        }
    }
}

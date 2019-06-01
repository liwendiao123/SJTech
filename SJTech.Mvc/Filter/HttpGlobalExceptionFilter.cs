﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using SJTech.Core.Models.VD;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SJTech.Mvc.Filter
{
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            //context.Result = new ObjectResult(context.Exception);
            //context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //context.ExceptionHandled = true;
            context.HttpContext.Response.ContentType = "text/html";
            var result = new ViewResult
            {
                ViewName = "Error",
                ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = new Error_ExceptionVD()
                    {
                        Message = context.Exception.Message,
                    }
                }
            };
            context.Result = result;
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.ExceptionHandled = true;
        }
    }
}

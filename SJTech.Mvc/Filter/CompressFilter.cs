using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace SJTech.Mvc.Filter
{
    public class CompressFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            HttpRequest request = filterContext.HttpContext.Request;

            string acceptEncoding = request.Headers["Accept-Encoding"];

            if (string.IsNullOrEmpty(acceptEncoding)) return;

            acceptEncoding = acceptEncoding.ToUpperInvariant();

            HttpResponse response = filterContext.HttpContext.Response;

            if (acceptEncoding.Contains("GZIP"))
            {
                response.Headers["Content-encoding"] = "gzip";
                response.Body = new GZipStream(response.Body, CompressionMode.Compress);
            }
            else if (acceptEncoding.Contains("DEFLATE"))
            {
                response.Headers["Content-encoding"] = "deflate";
                response.Body = new DeflateStream(response.Body, CompressionMode.Compress);
            }
        }
    }
}

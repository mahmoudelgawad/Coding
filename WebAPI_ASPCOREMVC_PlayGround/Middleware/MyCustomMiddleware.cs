using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Globalization;
using System.Threading.Tasks;

namespace WebAPI_ASPCOREMVC_PlayGround.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyCustomMiddleware
    {
        private readonly RequestDelegate _next;

        public MyCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            // write/excute your pre-processing logic, before the controller/endpoint excecute
            // for both http requests or responses
      
            var cultureQuery = httpContext.Request.Query["culture"];
            if (string.IsNullOrWhiteSpace(cultureQuery)) 
            {
               var culture = new CultureInfo(cultureQuery);
               CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }


            // Call the next delegate/middleware in the pipeline.
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleware>();
        }
    }
}

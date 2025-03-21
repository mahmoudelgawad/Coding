using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebAPI_ASPCOREMVC_PlayGround.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public MyAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyAuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyAuthenticationMiddleware>();
        }
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MiddlewarePractice.Middleware
{
    public class CustomErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync("ooooops, something went wrong..."); 
            }
        }
    }
}
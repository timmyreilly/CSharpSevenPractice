using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MiddlewarePractice.Middleware;

namespace MiddlewarePractice
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.Use(async (context, next) => {
            //     try 
            //     {
            //         await next(); 
            //     }
            //     catch (Exception e)
            //     {
            //         await context.Response.WriteAsync("Oops, something went wrong"); 
            //     }
            // }); 

            app.UseMiddleware<CustomErrorHandlingMiddleware>(); 

            app.Use((context, next) => {
                Random randomizer = new Random(); 
                int chance = randomizer.Next(); 
                if(chance % 2 == 0) 
                {
                    throw new Exception("Invalid Operation"); 
                }
                else 
                {
                    return next(); 
                }
            });

            app.Map("/about", appBuilder => {
                appBuilder.Run(async (context) => {
                    await context.Response.WriteAsync("About Page"); 
                }); 
            }); 

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

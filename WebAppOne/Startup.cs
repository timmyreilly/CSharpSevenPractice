using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAppOne.Services;

namespace WebAppOne
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            // Configuration.GetValue<string>("HOLA");
            Console.WriteLine(Configuration.GetValue<string>("Author"));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddTransient<FooService>();
            services.AddTransient<IEntertainmentService, EntertainmentServiceDefault>(); 
            services.AddTransient<IAnnouncementsService, AnnouncementService>(); 

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, FooService service)
        {
            if (env.IsDevelopment())
            {
                Console.WriteLine("We're in dev mode"); 
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "AllGames",
                    template: "games/all",
                    defaults: new { Controller = "Pages", Action = "Games"} 
                );

                routes.MapRoute(
                    name: "AllMovies",
                    template: "movies/all",
                    defaults: new { Controller = "Pages", Action = "Movies"}
                );  
            });

            // app.Run(async (context) =>
            // {
            //     var names = service.GetNames();
            //     StringBuilder builder = new StringBuilder();
            //     foreach (var name in names)
            //     {
            //         if (Configuration.GetValue<bool>("CapitalizedWords"))
            //         {
            //             builder.Append(name.ToUpper() + " "); 
            //         }
            //         else
            //         {
            //             builder.Append(name + " ");

            //         }
            //     }
            //     await context.Response.WriteAsync(builder.ToString());
            // });

            
        }
    }
}

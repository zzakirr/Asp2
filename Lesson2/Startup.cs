using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); 
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                       "default",
                       "{controller=home}/{action=index}"
                    );
                endpoints.MapControllerRoute(
                        "about",
                        "about.html",
                        defaults: new { controller = "home",action = "about"}
                    );
                endpoints.MapControllerRoute(
                        "services",
                        "services.html",
                        defaults: new { controller = "home", action = "services" }
                    );
            });
        }
    }
}

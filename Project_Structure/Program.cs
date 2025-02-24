using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Project_Structure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var WebApplicationBuilder = WebApplication.CreateBuilder();

            #region Configure Service
            WebApplicationBuilder.Services.AddControllersWithViews();
            #endregion

            #region Build
            var app = WebApplicationBuilder.Build();
            #endregion

            #region Configure
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

        
            app.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            //Static
            app.MapGet("/index", async context =>
            {
                await context.Response.WriteAsync("Hello Route!");
            });

            ////Dynamic / Variable  
            //endpoints.MapGet("/{id:int}", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Route!");
            //});
            ////Mixed
            //endpoints.MapGet("/Hello{id:alpha}", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Route!");
            //});

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id:int?}"
                //defaults: new { Action = "Index" },
                //constraints: new { id = new IntRouteConstraint() }
                );
            #endregion

            #region Run
            app.Run();
            #endregion
        }

     
    }
}

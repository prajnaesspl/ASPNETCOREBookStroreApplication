using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from 1st middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello response from 1st middleware");
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from 2nd middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello response from 2nd middleware");
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from 3rd middleware");
            //    await next();
            //});

            //before writing endpoints middle ware we have to write userouting()
            app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello world !! from end points");
            //    });
            //});


            app.UseEndpoints(endpoints =>
            {
                //endpoints.Map("/", async context =>
                //{
                //    //await context.Response.WriteAsync("Hello world !! i can handle only get request");
                //    //if(env.IsDevelopment())
                //    //{
                //    //    await context.Response.WriteAsync("I am from developement");
                //    //}
                //    //else if(env.IsProduction())
                //    //{
                //    //    await context.Response.WriteAsync("I am Production");
                //    //}

                //    //if (env.IsEnvironment("Dev"))
                //    //{
                //    //    await context.Response.WriteAsync("I am from custom");
                //    //}
                //});
                endpoints.MapDefaultControllerRoute();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/prajna", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello world !! I can handle all request including customize routing");
            //    });
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace queteIntergiciels
{
    public class Startup
    {

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection(); // Harden the security with HTTPS enforcing
            // Adding a custom middleware
            app.Use(async (context, next) =>
            {
                // Here goes the custom middleware post-reception behavior
                var allowString = context.Request.Query["allow"];
                if ((allowString==""))
                {
                    await next();
                }
                else
                {
                    throw new Exception();
                }
                // Here goes the custom middleware post-treatment behavior
            });
            
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello, World !");
            });
        }
    }
}

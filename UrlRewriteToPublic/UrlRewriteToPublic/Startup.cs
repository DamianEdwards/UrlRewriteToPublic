using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(UrlRewriteToPublic.Startup))]

namespace UrlRewriteToPublic
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/owin", map =>
            {
                map.Run(async context =>
                {
                    context.Response.ContentType = "text/plain";
                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync("Hello from OWIN handler! p1=" + context.Request.Query["p1"]);
                });
            });
        }
    }
}

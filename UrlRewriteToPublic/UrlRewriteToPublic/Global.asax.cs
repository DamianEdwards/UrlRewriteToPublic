using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace UrlRewriteToPublic
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add("My Route", new Route("routing", new MyRoute()));
        }
    }

    public class MyRoute : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new HttpHandler();
        }

        private class HttpHandler : IHttpHandler
        {
            public bool IsReusable
            {
                get { return false; }
            }

            public void ProcessRequest(HttpContext context)
            {
                context.Response.ContentType = "text/html";
                context.Response.StatusCode = 200;
                context.Response.Write("Hello from routing!! p1=" + context.Request.QueryString["p1"]);
                context.Response.Flush();
            }
        }
    }
}
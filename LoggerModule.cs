using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace namespce_of_project
{
    public class LoggerModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(BeginRequest);
            context.PreSendRequestHeaders += new EventHandler(PreSendRequestHeaders);
            context.PreSendRequestContent += new EventHandler(PreSendRequestContent);
            context.PreRequestHandlerExecute += new EventHandler(PreRequestHandlerExecute);
            context.EndRequest += new EventHandler(context_EndRequest);
        }

        private void BeginRequest(object o, EventArgs e)
        {


        }

        private void PreSendRequestHeaders(object o, EventArgs e)
        {
            HttpApplication httpApplication = o as HttpApplication;
            HttpContext ctx = httpApplication.Context;
            var collection = new NameValueCollection();
            collection.Add("key1", "LoggerModule");
            ctx.Request.Headers.Add(collection);
        }

        private void PreRequestHandlerExecute(object o, EventArgs e)
        {
            HttpApplication httpApplication = o as HttpApplication;
            HttpContext ctx = httpApplication.Context;
            var msg = ctx.Request.RawUrl ;
            //MessageHandler2.PrintData(msg);
        }


        private void context_EndRequest(object o, EventArgs e)
        {

        }

        private void PreSendRequestContent(object o, EventArgs e)
        {
            HttpApplication httpApplication = o as HttpApplication;
            HttpContext ctx = httpApplication.Context;
            if (ctx.Request.FilePath.Contains(".css"))
            {
                var path = ctx.Request.FilePath;
            }
        }


        public void Dispose()
        {

        }


    }
}

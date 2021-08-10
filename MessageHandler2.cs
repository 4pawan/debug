using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace namespce_of_project
{
    public class MessageHandler2 : DelegatingHandler
    {
        readonly string _comment = null;
        public MessageHandler2(string comment = null)
        {
            InnerHandler = new HttpClientHandler();
            _comment = comment;
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            PrintData("calling :" + request.RequestUri.AbsolutePath);
            var response = base.SendAsync(request, cancellationToken);
            PrintData("response received for" + request.RequestUri.AbsolutePath);
            return response;
        }

        public static void PrintData(string logMessage)
        {

            using (StreamWriter w = File.AppendText(@"C:\Projects\handler.txt"))
            {
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.WriteLine($"  :{logMessage}");
                w.WriteLine("-------------------------------");
            }


        }
    }
}

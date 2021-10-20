# debug

https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-configure-network-tracing

https://www.jondjones.com/learn-episerver-cms/episerver-developers-tutorials/episerver-logging/log4net-best-practices-to-use-with-an-episerver-website/

https://support.optimizely.com/hc/en-us/articles/360021035391-Using-Fiddler-to-capture-Find-requests

https://docs.telerik.com/fiddler/knowledge-base/quickexec

https://docs.telerik.com/fiddler/knowledge-base/fiddlerscript/customizesessionslist

https://www.c-sharpcorner.com/UploadFile/dacca2/http-message-handler-in-web-api-implement-server-side-messa/

https://www.stevejgordon.co.uk/httpclientfactory-aspnetcore-outgoing-request-middleware-pipeline-delegatinghandlers

https://github.com/david-risney/CSP-Fiddler-Extension

http://www.chadsowald.com/software/fiddler-extension-request-to-code

https://stackoverflow.com/questions/255669/how-to-enable-assembly-bind-failure-logging-fusion-in-net

https://developers.de/2018/08/30/fiddler-tls-issues/

  static function OnBeforeRequest(oSession: Session) {
        
         if (oSession.uriContains("test")) {	oSession["ui-color"] = "orange";	}
         if (oSession.host.ToLower().Contains("test")) {	oSession["ui-color"] = "orange";	}
         if (oSession.uriContains("access_token") &&
             oSession.host.ToLower().Contains("test123")) {	oSession["ui-color"] = "brown";	}
             
         if (oSession.oRequest.headers.Exists("Cookie")) 
           {
              oSession["ui-color"]="red";
              oSession["ui-customcolumn"] = oSession.oRequest["Cookie"];
           }   
  }


 static function OnBeforeResponse(oSession: Session) {

        if (oSession.responseCode == 401 ||
        oSession.responseCode ==403) {	oSession["ui-color"] = "red";	}
        
        oSession["ui-customcolumn"] = oSession.oResponse["Set-Cookie"];
        
    }

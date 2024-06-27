using Microsoft.AspNetCore.Http;

namespace JsxClassLibrary
{

    /// <summary>
    /// Custom jSilvestri.com 2024 Web API Demo Root URL Helper class. This class handles getting and/or setting the Root URL (absolute or relative) 
    /// based on the server and whether the URL is a localhost URL, and can be leveraged across all projects in the jSilvestri 2024 Web API 
    /// Demo Collection.
    /// </summary>
    public static class JsxRootUrlHelper
    {

        /// <summary>
        /// A custom jSilvestri.com BETA v 2024 Get method used to construct the segments of the URL and then converts them into a valid, string-based value 
        /// to be stored as the Server Environment (Host) Absolute URL. This is particularly useful for 
        /// storing the current Absolute URL.
        /// </summary>
        /// <param name="jsxHttpContext">The Http Context.</param>
        public static string AddReturnJsxAbsoluteServerEnvRootUrl(HttpContext jsxHttpContext)
        {
            if (jsxHttpContext != null)
            {
                //This is the full manufactured Absolute URL. 
                //var localAbsoluteRootUrl = $"{jsxHttpContext.Request.Scheme}://{jsxHttpContext.Request.Host.Host}{(jsxHttpContext.Request.Host.Port != 80 && jsxHttpContext.Request.Host.Port != 443 ? $":{jsxHttpContext.Request.Host.Port.ToString()}" : "")}" ?? $"{JsxConstants.JsxWebApp.Root.Slugs.DefaultJsxRoot}";

                // Now, we simply add it to its unique, View Data Object. 
                //This is the full manufactured Absolute URL. 

                //This is the full manufactured Absolute URL. 
                var rootUrlSchemaHttpOrHttps = jsxHttpContext.Request.Scheme ?? JsxConstants.JsxWebApiDemoSettings.Protocol.HttpsNoColonsSlashes;
                var rootUrlHostLocalHostOrJsilvestri = jsxHttpContext.Request.Host.Host ?? JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipeline;
                var rootUrlPort = (jsxHttpContext.Request.Host.Port != JsxConstants.JsxWebApiDemoSettings.Ports.Slugs.port80 && jsxHttpContext.Request.Host.Port != JsxConstants.JsxWebApiDemoSettings.Ports.Slugs.port443) ? $":{jsxHttpContext.Request.Host.Port}" : "";
                var finalHost = "";

                // If the Host is the same as Prouction, we don't even want to entertain a Port
                if (string.Equals(rootUrlHostLocalHostOrJsilvestri, JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipeline, StringComparison.OrdinalIgnoreCase) || string.Equals(rootUrlHostLocalHostOrJsilvestri, JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipelineWWW, StringComparison.OrdinalIgnoreCase))
                {
                    //if (rootUrlHostLocalHostOrJsilvestri == JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipeline) { 
                    finalHost = $"{rootUrlHostLocalHostOrJsilvestri}";
                }
                else
                {
                    finalHost = $"{rootUrlHostLocalHostOrJsilvestri}{rootUrlPort}";
                }

                var localAbsoluteRootUrl = $"{rootUrlSchemaHttpOrHttps}://{finalHost}";
                return localAbsoluteRootUrl;
            }
            else
            {


                // Update Full Absolute URL View Data Object
                string finalUrlReturn = $"{JsxConstants.JsxWebApiDemoSettings.Protocol.HttpsNoColonsSlashes}://{JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipeline}";
                return finalUrlReturn;
            }
        }

        /// <summary>
        /// A custom jSilvestri.com BETA v 2024 Get method used to construct the segments of the URL and then converts them into a valid, string-based value 
        /// to be stored as the Server Environment (Host) Absolute URL. This is particularly useful for 
        /// storing the current Absolute URL.
        /// </summary>
        /// <param name="jsxHttpContext">The Http Context.</param>
        public static string AddReturnJsxRelativeServerEnvRootUrl(HttpContext jsxHttpContext)
        {
            if (jsxHttpContext != null)
            {
                //This is the full manufactured Relative URL. 
                //var localRelativeRootUrl = $"{jsxHttpContext.Request.Scheme}://{jsxHttpContext.Request.Host.Host}{(jsxHttpContext.Request.Host.Port != 80 && jsxHttpContext.Request.Host.Port != 443 ? $":{jsxHttpContext.Request.Host.Port.ToString()}" : "")}" ?? $"{JsxConstants.JsxWebApiDemoSettings.Root.Slugs.DotForwardSlash}";

                var rootUrlSchemaHttpOrHttps = jsxHttpContext.Request.Scheme ?? JsxConstants.JsxWebApiDemoSettings.Protocol.HttpsNoColonsSlashes;
                var rootUrlHostLocalHostOrJsilvestri = jsxHttpContext.Request.Host.Host ?? JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipeline;
                var rootUrlPort = (jsxHttpContext.Request.Host.Port != JsxConstants.JsxWebApiDemoSettings.Ports.Slugs.port80 && jsxHttpContext.Request.Host.Port != JsxConstants.JsxWebApiDemoSettings.Ports.Slugs.port443) ? $":{jsxHttpContext.Request.Host.Port}" : "";
                var finalHost = "";

                // If the Host is the same as Prod, we don't even want to entertain a Port
                if (string.Equals(rootUrlHostLocalHostOrJsilvestri, JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipeline, StringComparison.OrdinalIgnoreCase) || string.Equals(rootUrlHostLocalHostOrJsilvestri, JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipelineWWW, StringComparison.OrdinalIgnoreCase))
                {

                    finalHost = $"{rootUrlHostLocalHostOrJsilvestri}";
                }
                else
                {
                    finalHost = $"{rootUrlHostLocalHostOrJsilvestri}{rootUrlPort}";
                }

                var localRelativeRootUrl = $"{rootUrlSchemaHttpOrHttps}://{finalHost}";
                return localRelativeRootUrl;
            }
            else
            {

                // Update Full Relative URL View Data Object
                string finalUrlReturn = $"{JsxConstants.JsxWebApiDemoSettings.Protocol.HttpsNoColonsSlashes}://{JsxConstants.JsxWebApiDemoSettings.Root.Slugs.ProductionServerPipeline}";
                return finalUrlReturn;

            }
        }
    }
    
}

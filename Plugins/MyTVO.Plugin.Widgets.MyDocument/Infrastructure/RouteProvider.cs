using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using MyTVO.Core;
using Nop.Web.Framework.Mvc.Routing;
using Nop.Web.Infrastructure;

namespace MyTVO.Plugin.Widgets.MyDocument.Infrastructure
{
    public class RouteProvider : BaseRouteProvider, IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            var lang = GetLanguageRoutePattern();

            endpointRouteBuilder.MapControllerRoute(MyDocumentDefaults.MyDocumentRoute, $"{lang}/{MyTVOCoreDefaults.MyTVOSubPath}/mydocument",
               new { controller = $"{MyDocumentDefaults.ControllerName_WidgetsMyDocument}", action = "Index" });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;
using Nop.Web.Infrastructure;

namespace MyTVO.Plugin.Widgets.MyAccount.Infrastructure
{
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    public class RouteProvider : BaseRouteProvider, IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            var lang = GetLanguageRoutePattern();

            //endpointRouteBuilder.MapControllerRoute(MyAccountDefaults.MyProfileRoute, $"{lang}/mytvo/myprofile",
            //    new { controller = "WidgetsMyAccount", action = "MyProfile" });

            //endpointRouteBuilder.MapControllerRoute(MyAccountDefaults.MyVehicleRoute, $"{lang}/mytvo/myvehicle",
            //   new { controller = "WidgetsMyAccount", action = "MyVehicle" });

            //endpointRouteBuilder.MapControllerRoute(MyAccountDefaults.MyDocumentRoute, $"{lang}/mytvo/mydocument",
            //   new { controller = "WidgetsMyAccount", action = "MyDocument" });

            //endpointRouteBuilder.MapControllerRoute(MyAccountDefaults.MyWorkshopRoute, $"{lang}/mytvo/myworkshop",
            //   new { controller = "WidgetsMyAccount", action = "MyWorkshop" });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }
}

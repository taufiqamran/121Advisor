using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using MyTVO.Core;
using Nop.Web.Framework.Mvc.Routing;
using Nop.Web.Infrastructure;

namespace MyTVO.Plugin.Widgets.MyVehicle.Infrastructure
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

            endpointRouteBuilder.MapControllerRoute(MyVehicleDefaults.MyVehicleRoute, $"{lang}/{MyTVOCoreDefaults.MyVehicleSubPath}",
               new { controller = $"{MyVehicleDefaults.ControllerName_WidgetsMyVehicle}", action = "Index" });


            //get vehicle brand by vehicle type (AJAX)
            endpointRouteBuilder.MapControllerRoute(name: MyVehicleDefaults.GetBrandByVehicleType,
                pattern: $"{lang}/{MyTVOCoreDefaults.MyVehicleSubPath}/GetBrandByVehicleType",
                defaults: new { controller = $"{MyVehicleDefaults.ControllerName_WidgetsMyVehicle}", action = "GetBrandByVehicleType" });

            //get vehicle model by vehicle brand (AJAX)
            endpointRouteBuilder.MapControllerRoute(name: MyVehicleDefaults.GetModelByVehicleBrand,
                pattern: $"{lang}/{MyTVOCoreDefaults.MyVehicleSubPath}/GetModelByVehicleBrand",
                defaults: new { controller = $"{MyVehicleDefaults.ControllerName_WidgetsMyVehicle}", action = "GetModelByVehicleBrand" });

            //get vehicle model by vehicle brand (AJAX)
            endpointRouteBuilder.MapControllerRoute(name: MyVehicleDefaults.GetSeriesByVehicleModel,
                pattern: $"{lang}/{MyTVOCoreDefaults.MyVehicleSubPath}/GetSeriesByVehicleModel",
                defaults: new { controller = $"{MyVehicleDefaults.ControllerName_WidgetsMyVehicle}", action = "GetSeriesByVehicleModel" });

        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }
}

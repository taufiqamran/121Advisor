using Microsoft.AspNetCore.Mvc;
using MyTVO.Core.Services;
using MyTVO.Plugin.Widgets.MyVehicle.Factories;
using MyTVO.Plugin.Widgets.MyVehicle.Models;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyVehicle.Controllers
{
    public class WidgetsMyVehicleController : BasePluginController
    {
        #region Fields

        private readonly IMyVehicleModelFactory _myVehicleModelFactory;

        #endregion

        #region Ctor

        public WidgetsMyVehicleController(IMyVehicleModelFactory myVehicleModelFactory)
        {
            _myVehicleModelFactory = myVehicleModelFactory;
        }

        #endregion

        #region Methods

        public virtual async Task<IActionResult> Index()
        {
            var model = new MyVehicleModel();
            await _myVehicleModelFactory.PrepareMyVehicleModel(model);
            return View($"{MyVehicleDefaults.ViewPath}/MyVehicle.cshtml", model);
        }

        //available even when navigation is not allowed
        [CheckAccessPublicStore(true)]
        //ignore SEO friendly URLs checks
        [CheckLanguageSeoCode(true)]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> GetBrandByVehicleType(string vehicleType)
        {
            var model = await _myVehicleModelFactory.GetBrandByVehicleType(vehicleType);

            return Json(model);
        }

        //available even when navigation is not allowed
        [CheckAccessPublicStore(true)]
        //ignore SEO friendly URLs checks
        [CheckLanguageSeoCode(true)]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> GetModelByVehicleBrand(string vehicleType, string vehicleBrand)
        {
            var model = await _myVehicleModelFactory.GetModelByVehicleBrand(vehicleType, vehicleBrand);

            return Json(model);
        }

        //available even when navigation is not allowed
        [CheckAccessPublicStore(true)]
        //ignore SEO friendly URLs checks
        [CheckLanguageSeoCode(true)]
        /// <returns>A task that represents the asynchronous operation</returns>
        public virtual async Task<IActionResult> GetSeriesByVehicleModel(string vehicleType, string vehicleBrand, string vehicleModel)
        {
            var model = await _myVehicleModelFactory.GetSeriesByVehicleModel(vehicleType, vehicleBrand, vehicleModel);

            return Json(model);
        }

        #endregion
    }
}

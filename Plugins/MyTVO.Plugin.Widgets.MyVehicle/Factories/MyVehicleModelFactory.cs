using Microsoft.AspNetCore.Mvc.Rendering;
using MyTVO.Core.Services;
using MyTVO.Plugin.Widgets.MyVehicle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyVehicle.Factories
{
    public partial class MyVehicleModelFactory : IMyVehicleModelFactory
    {
        #region Fields

        private readonly IMyTVO_CarService _myTVO_carService;

        #endregion

        #region Ctor

        public MyVehicleModelFactory(IMyTVO_CarService myTVO_carService)
        {
            _myTVO_carService = myTVO_carService;
        }

        #endregion

        #region Methods

        public virtual async Task PrepareMyVehicleModel(MyVehicleModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            var vehicleTypes = await _myTVO_carService.GetVehicleTypes();

            foreach (var vehicleType in vehicleTypes)
            {
                model.VehicleTypes.Add(new SelectListItem
                {
                    Text = vehicleType,
                    Value = vehicleType,
                    Selected = false
                });
            }
        }

        public virtual async Task<IList<string>> GetBrandByVehicleType(string vehicleType)
        {
            if (string.IsNullOrEmpty(vehicleType))
                throw new ArgumentNullException(nameof(vehicleType));

            var vehicleBrands = await _myTVO_carService.GetVehicleBrands(vehicleType);

            return vehicleBrands;
        }

        public virtual async Task<IList<string>> GetModelByVehicleBrand(string vehicleType, string vehicleBrand)
        {
            if (string.IsNullOrEmpty(vehicleType))
                throw new ArgumentNullException(nameof(vehicleType));

            if (string.IsNullOrEmpty(vehicleBrand))
                throw new ArgumentNullException(nameof(vehicleBrand));

            var vehicleModels = await _myTVO_carService.GetVehicleModels(vehicleType, vehicleBrand);

            return vehicleModels;
        }

        public virtual async Task<IList<string>> GetSeriesByVehicleModel(string vehicleType, string vehicleBrand, string vehicleModel)
        {
            if (string.IsNullOrEmpty(vehicleType))
                throw new ArgumentNullException(nameof(vehicleType));

            if (string.IsNullOrEmpty(vehicleBrand))
                throw new ArgumentNullException(nameof(vehicleBrand));

            if (string.IsNullOrEmpty(vehicleModel))
                throw new ArgumentNullException(nameof(vehicleModel));

            var vehicleSerieses = await _myTVO_carService.GetVehicleSerieses(vehicleType, vehicleBrand, vehicleModel);

            return vehicleSerieses;
        }

        #endregion
    }
}

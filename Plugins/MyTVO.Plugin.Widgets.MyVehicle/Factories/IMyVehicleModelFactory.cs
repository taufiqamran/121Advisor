using MyTVO.Plugin.Widgets.MyVehicle.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyVehicle.Factories
{
    public partial interface IMyVehicleModelFactory
    {
        Task PrepareMyVehicleModel(MyVehicleModel model);

        Task<IList<string>> GetBrandByVehicleType(string vehicleType);

        Task<IList<string>> GetModelByVehicleBrand(string vehicleType, string vehicleBrand);

        Task<IList<string>> GetSeriesByVehicleModel(string vehicleType, string vehicleBrand, string vehicleModel);
    }
}

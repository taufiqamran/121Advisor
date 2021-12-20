using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTVO.Core.Services
{
    public partial interface IMyTVO_CarService
    {
        Task<IList<string>> GetVehicleTypes();

        Task<IList<string>> GetVehicleBrands(string vehicleType);

        Task<IList<string>> GetVehicleModels(string vehicleType, string vehicleBrand);

        Task<IList<string>> GetVehicleSerieses(string vehicleType, string vehicleBrand, string vehicleModel);
    }
}

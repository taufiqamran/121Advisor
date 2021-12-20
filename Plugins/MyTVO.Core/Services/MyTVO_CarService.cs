using MyTVO.Core.Domain;
using Nop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTVO.Core.Services
{
    public partial class MyTVO_CarService : IMyTVO_CarService
    {
        #region Fields

        private readonly IRepository<MyTVO_Car> _myTVO_CarRepository;

        #endregion

        #region Ctor

        public MyTVO_CarService(IRepository<MyTVO_Car> myTVO_CarRepository)
        {
            _myTVO_CarRepository = myTVO_CarRepository;
        }

        #endregion

        #region Methods
        public virtual async Task<IList<string>> GetVehicleTypes()
        {
            var query = from x in _myTVO_CarRepository.Table
                        select x.VehicleType;
            var result = await query.Distinct().ToListAsync();

            return result;
        }

        public virtual async Task<IList<string>> GetVehicleBrands(string vehicleType)
        {
            var query = from x in _myTVO_CarRepository.Table
                        where x.VehicleType == vehicleType
                        select x.Manufacture;
            var result = await query.Distinct().ToListAsync();

            return result;
        }

        public virtual async Task<IList<string>> GetVehicleModels(string vehicleType, string vehicleBrand)
        {
            var query = from x in _myTVO_CarRepository.Table
                        where x.VehicleType == vehicleType
                        && x.Manufacture == vehicleBrand
                        select x.Model;
            var result = await query.Distinct().ToListAsync();

            return result;
        }

        public virtual async Task<IList<string>> GetVehicleSerieses(string vehicleType, string vehicleBrand, string vehicleModel)
        {
            var query = from x in _myTVO_CarRepository.Table
                        where x.VehicleType == vehicleType
                        && x.Manufacture == vehicleBrand
                        && x.Model == vehicleModel
                        select x.TrimLevel;     // TODO: is it trimlevel?
            var result = await query.Distinct().ToListAsync();

            return result;
        }

        #endregion
    }
}

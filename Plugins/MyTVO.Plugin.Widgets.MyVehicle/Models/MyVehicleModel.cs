using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System.Collections.Generic;

namespace MyTVO.Plugin.Widgets.MyVehicle.Models
{
    public partial record MyVehicleModel: BaseNopEntityModel
    {
        public MyVehicleModel()
        {
            VehicleTypes = new List<SelectListItem>();
            VehicleBrands = new List<SelectListItem>();
            VehicleModels = new List<SelectListItem>();
            VehicleSerieses = new List<SelectListItem>();
        }

        [NopResourceDisplayName("mytvo.myvehicle.vehicletype")]
        public string VehicleType { get; set; }
        [NopResourceDisplayName("mytvo.myvehicle.vehiclebrand")]
        public string VehicleBrand { get; set; }
        [NopResourceDisplayName("mytvo.myvehicle.vehiclemodel")]
        public string VehicleModel { get; set; }
        [NopResourceDisplayName("mytvo.myvehicle.vehicleseries")]
        public string VehicleSeries { get; set; }

        public IList<SelectListItem> VehicleTypes { get; set; }
        public IList<SelectListItem> VehicleBrands { get; set; }
        public IList<SelectListItem> VehicleModels { get; set; }
        public IList<SelectListItem> VehicleSerieses { get; set; }



    }
}

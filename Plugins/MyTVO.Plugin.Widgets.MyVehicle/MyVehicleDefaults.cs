namespace MyTVO.Plugin.Widgets.MyVehicle
{
    public static class MyVehicleDefaults
    {
        #region Routes

        public static string MyVehicleRoute => "MyTVO.Plugin.Widgets.MyVehicle.MyVehicle";

        public static string GetBrandByVehicleType => "GetVehicleBrandByVehicleType";

        public static string GetModelByVehicleBrand => "GetModelByVehicleBrand";

        public static string GetSeriesByVehicleModel => "GetSeriesByVehicleModel";

        #endregion

        public const string ViewComponentName = "MyVehicleWidget";

        public static string ViewPath => "~/Plugins/MyTVO.Widgets.MyVehicle/Views";

        public static string CssPath => "~/Plugins/MyTVO.Widgets.MyVehicle/Content/css";

        public static string JsPath => "~/Plugins/MyTVO.Widgets.MyVehicle/Content/js";


        public static string ControllerName_WidgetsMyVehicle = "WidgetsMyVehicle";
    }
}

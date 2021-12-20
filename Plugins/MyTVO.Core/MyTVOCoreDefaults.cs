namespace MyTVO.Core
{
    public static class MyTVOCoreDefaults
    {
        #region Routes

        public static string RouteName_MyProfile => "MyTVO.Plugin.Widgets.MyAccount.MyProfile";

        public static string RouteName_MyVehicle => "MyTVO.Plugin.Widgets.MyAccount.MyVehicle";

        public static string RouteName_MyDocument => "MyTVO.Plugin.Widgets.MyAccount.MyDocument";

        public static string RouteName_MyWorkshop => "MyTVO.Plugin.Widgets.MyAccount.MyWorkshop";

        #endregion

        public const string ViewComponentName = "MyAccountWidget";

        public static string SchemaName = "dbo";

        public static string TableName_MyTVO_Car = "MyTVO_Car";

        public static string ScriptsViewPath = "Plugins/MyTVO.Core/Data/Scripts";

        public static string MyTVOSubPath = "mytvo";

        public static string MyVehicleSubPath = $"{MyTVOSubPath}/myvehicle";
    }
}

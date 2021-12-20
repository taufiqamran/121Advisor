namespace MyTVO.Plugin.Widgets.MyAccount
{
    public static class MyAccountDefaults
    {
        #region Routes

        public static string MyProfileRoute => "MyTVO.Plugin.Widgets.MyAccount.MyProfile";

        public static string MyVehicleRoute => "MyTVO.Plugin.Widgets.MyAccount.MyVehicle";

        public static string MyDocumentRoute => "MyTVO.Plugin.Widgets.MyAccount.MyDocument";

        public static string MyWorkshopRoute => "MyTVO.Plugin.Widgets.MyAccount.MyWorkshop";

        #endregion

        public const string ViewComponentName = "MyAccountWidget";

        public static string ViewPath = "~/Plugins/MyTVO.Widgets.MyAccount/Views";
    }
}

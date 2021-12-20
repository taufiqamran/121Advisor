namespace MyTVO.Plugin.Widgets.MyDocument
{
    public static class MyDocumentDefaults
    {
        #region Routes

        public static string MyProfileRoute => "MyTVO.Plugin.Widgets.MyAccount.MyProfile";

        public static string MyVehicleRoute => "MyTVO.Plugin.Widgets.MyAccount.MyVehicle";

        public static string MyDocumentRoute => "MyTVO.Plugin.Widgets.MyAccount.MyDocument";

        public static string MyWorkshopRoute => "MyTVO.Plugin.Widgets.MyAccount.MyWorkshop";

        #endregion

        public const string ViewComponentName = "MyDocumentWidget";

        public static string CssPath => "~/Plugins/MyTVO.Widgets.MyDocument/Content/css";

        public static string ViewPath = "~/Plugins/MyTVO.Widgets.MyDocument/Views";

        public static string ImagePath = "~/Plugins/MyTVO.Widgets.MyDocument/Content/images";

        public static string ControllerName_WidgetsMyDocument = "WidgetsMyDocument";

        public static string JsPath => "~/Plugins/MyTVO.Widgets.MyDocument/Content/js";
    }
}

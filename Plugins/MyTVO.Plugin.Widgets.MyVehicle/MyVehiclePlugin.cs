﻿using Nop.Services.Cms;
using Nop.Services.Plugins;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyVehicle
{
    public class MyVehiclePlugin : BasePlugin
        //, IWidgetPlugin
    {
        //#region Widget
        ///// <summary>
        ///// Gets a value indicating whether to hide this plugin on the widget list page in the admin area
        ///// </summary>
        //public bool HideInWidgetList => false;

        ///// <summary>
        ///// Gets a name of a view component for displaying widget
        ///// </summary>
        ///// <param name="widgetZone">Name of the widget zone</param>
        ///// <returns>View component name</returns>
        //public string GetWidgetViewComponentName(string widgetZone)
        //{
        //    return "MyVehicleWidget";
        //}

        ///// <summary>
        ///// Gets widget zones where this widget should be rendered
        ///// </summary>
        ///// <returns>
        ///// A task that represents the asynchronous operation
        ///// The task result contains the widget zones
        ///// </returns>
        //public Task<IList<string>> GetWidgetZonesAsync()
        //{
        //    return Task.FromResult<IList<string>>(new List<string> { "home_page_before_categories" });
        //}
        //#endregion

        #region Methods
        public override async Task InstallAsync()
        {
            //Logic during installation goes here...

            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
            //Logic during uninstallation goes here...

            await base.UninstallAsync();
        }
        #endregion
    }
}

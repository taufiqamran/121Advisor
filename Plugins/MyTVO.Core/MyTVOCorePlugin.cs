using Nop.Core;
using Nop.Services.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTVO.Core
{
    public class MyTVOCorePlugin : BasePlugin
    {

        private readonly IWebHelper _webHelper;

        public MyTVOCorePlugin(
            IWebHelper webHelper)
        {
            _webHelper = webHelper;
        }

        #region Methods

        /// <summary>
        /// Gets a configuration page URL
        /// </summary>
        //public override string GetConfigurationPageUrl()
        //{
        //    return $"{_webHelper.GetStoreLocation()}Admin/{MyAccountDefaults.ViewComponentName}/Configure";
        //}

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

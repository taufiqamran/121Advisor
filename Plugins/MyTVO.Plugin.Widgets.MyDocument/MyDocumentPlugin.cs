using Nop.Services.Cms;
using Nop.Services.Plugins;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyDocument
{
    public class MyDocumentPlugin : BasePlugin
    {
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
    }
}

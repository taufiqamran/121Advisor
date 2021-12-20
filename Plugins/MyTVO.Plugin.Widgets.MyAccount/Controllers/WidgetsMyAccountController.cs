using Microsoft.AspNetCore.Mvc;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyAccount.Controllers
{
    public class WidgetsMyAccountController : BasePluginController
    {
        #region Fields

        private readonly IPermissionService _permissionService;

        #endregion

        #region Ctor

        public WidgetsMyAccountController(
            IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        #endregion

        #region Methods 

        #region Admin
        [Area(AreaNames.Admin)]
        [AuthorizeAdmin]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Configure()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

           
            return View($"{MyAccountDefaults.ViewPath}/Configure.cshtml");
        }

        #endregion

        #endregion
    }
}

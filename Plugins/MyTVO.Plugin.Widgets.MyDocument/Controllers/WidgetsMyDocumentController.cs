using Microsoft.AspNetCore.Mvc;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyDocument.Controllers
{
    public class WidgetsMyDocumentController : BasePluginController
    {
        #region Fields

        private readonly IPermissionService _permissionService;

        #endregion
        public IActionResult Index()
        {
            return View($"{MyDocumentDefaults.ViewPath}/MyDocument.cshtml");
        }
    }
}

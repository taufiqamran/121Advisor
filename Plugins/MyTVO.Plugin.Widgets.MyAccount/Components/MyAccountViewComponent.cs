using Microsoft.AspNetCore.Mvc;
using MyTVO.Plugin.Widgets.MyAccount.Factories;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyAccount.Components
{
    [ViewComponent(Name = MyAccountDefaults.ViewComponentName)]
    public class MyAccountViewComponent : NopViewComponent
    {
        #region Fields

        private readonly ICustomerModelFactory _customerModelFactory;

        #endregion

        #region Ctor

        public MyAccountViewComponent(ICustomerModelFactory customerModelFactory)
        {
            _customerModelFactory = customerModelFactory;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Return custom view to display in chosen widget zone
        /// </summary>
        /// <param name="selectedTabId"></param>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync(int selectedTabId = 0)
        {
            var model = await _customerModelFactory.PrepareCustomerNavigationModelAsync(selectedTabId);

            return View($"{MyAccountDefaults.ViewPath}/MyAccount.cshtml", model);
        }

        #endregion
    }
}

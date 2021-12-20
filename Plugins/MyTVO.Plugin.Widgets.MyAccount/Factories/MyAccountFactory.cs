using MyTVO.Core;
using MyTVO.Plugin.Widgets.MyVehicle;
using Nop.Services.Localization;
using Nop.Web.Models.Customer;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyAccount.Factories
{
    public partial class MyAccountFactory : IMyAccountFactory
    {
        #region Fields

        private readonly ILocalizationService _localizationService;

        #endregion

        #region Ctor

        public MyAccountFactory(ILocalizationService localizationService) 
        {
            _localizationService = localizationService;
        }

        #endregion

        #region Method

        /// <summary>
        /// return MyTVO's custom submenu model
        /// </summary>
        /// <param name="selectedTabId"></param>
        /// <returns></returns>
        public virtual async Task<CustomerNavigationModel> PrepareCustomerNavigationModelAsync(int selectedTabId = 0)
        {
            var model = new CustomerNavigationModel();

            model.CustomerNavigationItems.Add(new CustomerNavigationItemModel
            {
                RouteName = MyAccountDefaults.MyProfileRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyProfile"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyProfile,
                ItemClass = "customer-myprofile"
            });

            model.CustomerNavigationItems.Add(new CustomerNavigationItemModel
            {
                RouteName = MyVehicleDefaults.MyVehicleRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyVehicle"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyVehicle,
                ItemClass = "customer-myvehicle"
            });

            model.CustomerNavigationItems.Add(new CustomerNavigationItemModel
            {
                RouteName = MyAccountDefaults.MyDocumentRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyDocument"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyDocument,
                ItemClass = "customer-mydocument"
            });

            model.CustomerNavigationItems.Add(new CustomerNavigationItemModel
            {
                RouteName = MyAccountDefaults.MyWorkshopRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyWorkshop"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyWorkshop,
                ItemClass = "customer-myworkshop"
            });

            model.SelectedTab = (CustomerNavigationEnum)selectedTabId;

            return model;
        }

        #endregion
    }
}

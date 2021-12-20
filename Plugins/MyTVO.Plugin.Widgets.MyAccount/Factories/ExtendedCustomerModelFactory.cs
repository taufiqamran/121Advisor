using MyTVO.Core;
using MyTVO.Plugin.Widgets.MyVehicle;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Forums;
using Nop.Core.Domain.Gdpr;
using Nop.Core.Domain.Media;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Security;
using Nop.Core.Domain.Tax;
using Nop.Core.Domain.Vendors;
using Nop.Services.Authentication.External;
using Nop.Services.Authentication.MultiFactor;
using Nop.Services.Catalog;
using Nop.Services.Common;
using Nop.Services.Customers;
using Nop.Services.Directory;
using Nop.Services.Gdpr;
using Nop.Services.Helpers;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Messages;
using Nop.Services.Orders;
using Nop.Services.Seo;
using Nop.Services.Stores;
using Nop.Web.Factories;
using Nop.Web.Models.Customer;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyAccount.Factories
{
    public partial class ExtendedCustomerModelFactory : CustomerModelFactory
    {
        #region Fields

        private readonly AddressSettings _addressSettings;
        private readonly CaptchaSettings _captchaSettings;
        private readonly CatalogSettings _catalogSettings;
        private readonly CommonSettings _commonSettings;
        private readonly CustomerSettings _customerSettings;
        private readonly DateTimeSettings _dateTimeSettings;
        private readonly ExternalAuthenticationSettings _externalAuthenticationSettings;
        private readonly ForumSettings _forumSettings;
        private readonly GdprSettings _gdprSettings;
        private readonly IAddressModelFactory _addressModelFactory;
        private readonly IAuthenticationPluginManager _authenticationPluginManager;
        private readonly ICountryService _countryService;
        private readonly ICustomerAttributeParser _customerAttributeParser;
        private readonly ICustomerAttributeService _customerAttributeService;
        private readonly ICustomerService _customerService;
        private readonly IDateTimeHelper _dateTimeHelper;
        private readonly IExternalAuthenticationService _externalAuthenticationService;
        private readonly IGdprService _gdprService;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly ILocalizationService _localizationService;
        private readonly IMultiFactorAuthenticationPluginManager _multiFactorAuthenticationPluginManager;
        private readonly INewsLetterSubscriptionService _newsLetterSubscriptionService;
        private readonly IOrderService _orderService;
        private readonly IPictureService _pictureService;
        private readonly IProductService _productService;
        private readonly IReturnRequestService _returnRequestService;
        private readonly IStateProvinceService _stateProvinceService;
        private readonly IStoreContext _storeContext;
        private readonly IStoreMappingService _storeMappingService;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IWorkContext _workContext;
        private readonly MediaSettings _mediaSettings;
        private readonly OrderSettings _orderSettings;
        private readonly RewardPointsSettings _rewardPointsSettings;
        private readonly SecuritySettings _securitySettings;
        private readonly TaxSettings _taxSettings;
        private readonly VendorSettings _vendorSettings;

        #endregion

        #region Ctor

        public ExtendedCustomerModelFactory(AddressSettings addressSettings,
           CaptchaSettings captchaSettings,
           CatalogSettings catalogSettings,
           CommonSettings commonSettings,
           CustomerSettings customerSettings,
           DateTimeSettings dateTimeSettings,
           ExternalAuthenticationSettings externalAuthenticationSettings,
           ForumSettings forumSettings,
           GdprSettings gdprSettings,
           IAddressModelFactory addressModelFactory,
           IAuthenticationPluginManager authenticationPluginManager,
           ICountryService countryService,
           ICustomerAttributeParser customerAttributeParser,
           ICustomerAttributeService customerAttributeService,
           ICustomerService customerService,
           IDateTimeHelper dateTimeHelper,
           IExternalAuthenticationService externalAuthenticationService,
           IGdprService gdprService,
           IGenericAttributeService genericAttributeService,
           ILocalizationService localizationService,
           IMultiFactorAuthenticationPluginManager multiFactorAuthenticationPluginManager,
           INewsLetterSubscriptionService newsLetterSubscriptionService,
           IOrderService orderService,
           IPictureService pictureService,
           IProductService productService,
           IReturnRequestService returnRequestService,
           IStateProvinceService stateProvinceService,
           IStoreContext storeContext,
           IStoreMappingService storeMappingService,
           IUrlRecordService urlRecordService,
           IWorkContext workContext,
           MediaSettings mediaSettings,
           OrderSettings orderSettings,
           RewardPointsSettings rewardPointsSettings,
           SecuritySettings securitySettings,
           TaxSettings taxSettings,
           VendorSettings vendorSettings) : base (addressSettings,
           captchaSettings,
           catalogSettings,
           commonSettings,
           customerSettings,
           dateTimeSettings,
           externalAuthenticationSettings,
           forumSettings,
           gdprSettings,
           addressModelFactory,
           authenticationPluginManager,
           countryService,
           customerAttributeParser,
           customerAttributeService,
           customerService,
           dateTimeHelper,
           externalAuthenticationService,
           gdprService,
           genericAttributeService,
           localizationService,
           multiFactorAuthenticationPluginManager,
           newsLetterSubscriptionService,
           orderService,
           pictureService,
           productService,
           returnRequestService,
           stateProvinceService,
           storeContext,
           storeMappingService,
           urlRecordService,
           workContext,
           mediaSettings,
           orderSettings,
           rewardPointsSettings,
           securitySettings,
           taxSettings,
           vendorSettings)
        {
            _addressSettings = addressSettings;
            _captchaSettings = captchaSettings;
            _catalogSettings = catalogSettings;
            _commonSettings = commonSettings;
            _customerSettings = customerSettings;
            _dateTimeSettings = dateTimeSettings;
            _externalAuthenticationService = externalAuthenticationService;
            _externalAuthenticationSettings = externalAuthenticationSettings;
            _forumSettings = forumSettings;
            _gdprSettings = gdprSettings;
            _addressModelFactory = addressModelFactory;
            _authenticationPluginManager = authenticationPluginManager;
            _countryService = countryService;
            _customerAttributeParser = customerAttributeParser;
            _customerAttributeService = customerAttributeService;
            _customerService = customerService;
            _dateTimeHelper = dateTimeHelper;
            _gdprService = gdprService;
            _genericAttributeService = genericAttributeService;
            _localizationService = localizationService;
            _multiFactorAuthenticationPluginManager = multiFactorAuthenticationPluginManager;
            _newsLetterSubscriptionService = newsLetterSubscriptionService;
            _orderService = orderService;
            _pictureService = pictureService;
            _productService = productService;
            _returnRequestService = returnRequestService;
            _stateProvinceService = stateProvinceService;
            _storeContext = storeContext;
            _storeMappingService = storeMappingService;
            _urlRecordService = urlRecordService;
            _workContext = workContext;
            _mediaSettings = mediaSettings;
            _orderSettings = orderSettings;
            _rewardPointsSettings = rewardPointsSettings;
            _securitySettings = securitySettings;
            _taxSettings = taxSettings;
            _vendorSettings = vendorSettings;
        }

        #endregion

        #region Method
        public override async Task<CustomerNavigationModel> PrepareCustomerNavigationModelAsync(int selectedTabId = 0)
        {
            var model = await base.PrepareCustomerNavigationModelAsync(selectedTabId);
            var navItems = model.CustomerNavigationItems;

            navItems.Add(new CustomerNavigationItemModel
            {
                RouteName = MyAccountDefaults.MyProfileRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyProfile"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyProfile,
                ItemClass = "customer-myprofile"
            });

            navItems.Add(new CustomerNavigationItemModel
            {
                RouteName = MyVehicleDefaults.MyVehicleRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyVehicle"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyVehicle,
                ItemClass = "customer-myvehicle"
            });

            navItems.Add(new CustomerNavigationItemModel
            {
                //TQ 
                //later change to document default?
                RouteName = MyAccountDefaults.MyDocumentRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyDocument"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyDocument,
                ItemClass = "customer-mydocument"
            });

            navItems.Add(new CustomerNavigationItemModel
            {
                RouteName = MyAccountDefaults.MyWorkshopRoute,
                Title = await _localizationService.GetResourceAsync("MyTVO.MyWorkshop"),
                Tab = (CustomerNavigationEnum)MyAccountNavigationEnum.MyWorkshop,
                ItemClass = "customer-myworkshop"
            });

            return model;
        }

        #endregion
    }
}

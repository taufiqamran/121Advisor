using Nop.Web.Models.Customer;
using System.Threading.Tasks;

namespace MyTVO.Plugin.Widgets.MyAccount.Factories
{
    public partial interface IMyAccountFactory
    {
        Task<CustomerNavigationModel> PrepareCustomerNavigationModelAsync(int selectedTabId = 0);
    }
}

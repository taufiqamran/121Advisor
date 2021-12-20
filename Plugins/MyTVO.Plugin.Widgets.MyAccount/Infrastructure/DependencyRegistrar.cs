using Microsoft.Extensions.DependencyInjection;
using MyTVO.Plugin.Widgets.MyAccount.Factories;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Web.Factories;

namespace MyTVO.Plugin.Widgets.MyAccount.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 3;

        public void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            services.AddScoped<ICustomerModelFactory, ExtendedCustomerModelFactory>();
        }
    }
}

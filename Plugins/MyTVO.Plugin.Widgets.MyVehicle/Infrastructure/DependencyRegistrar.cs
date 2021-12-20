using Microsoft.Extensions.DependencyInjection;
using MyTVO.Plugin.Widgets.MyVehicle.Factories;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;

namespace MyTVO.Plugin.Widgets.MyVehicle.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 3;

        public void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            services.AddScoped<IMyVehicleModelFactory, MyVehicleModelFactory>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using MyTVO.Core.Services;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;


namespace MyTVO.Core.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 1;

        public virtual void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            #region services

            services.AddScoped<IMyTVO_CarService, MyTVO_CarService>();

            #endregion
        }
    }
}

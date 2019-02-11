using DotVVM.Framework.Configuration;
using DotVVM.Framework.Controls.Bootstrap4;
using Microsoft.Extensions.DependencyInjection;

namespace DotVVM4
{
    public class DotvvmStartup : IDotvvmServiceConfigurator, IDotvvmStartup
    {
        public void ConfigureServices(IDotvvmServiceCollection options)
        {
            
        }

        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            config.AddBootstrap4Configuration();
            config.RouteTable.Add("default", "", "Views/default.dothtml");
        }
    }
}
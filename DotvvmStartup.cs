using DotVVM.Framework.Configuration;
using DotVVM.Framework.Controls.Bootstrap4;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;
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
            RegisterRoutes(config);
            RegisterResources(config);
        }

        private void RegisterRoutes(DotvvmConfiguration config)
        {
            config.RouteTable.Add("Default", "", "Views/default.dothtml");
            config.RouteTable.Add("Index", "index", "Views/Index.dothtml");
        }

        private void RegisterResources(DotvvmConfiguration config)
        {

            config.Resources.Register("my-javascript", new ScriptResource(new FileResourceLocation("wwwroot/JavaScript.js")));
            config.Resources.Register("dependent-javascript", new ScriptResource(new FileResourceLocation("wwwroot/DependentJavaScript.js"))
            {
                // here you can define dependencies of your code
                Dependencies = new[] { "my-javascript" }
            });


        }
    }
}
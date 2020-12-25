using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsAzureDemo.Startup))]
namespace DevOpsAzureDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

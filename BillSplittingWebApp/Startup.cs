using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillSplittingWebApp.Startup))]
namespace BillSplittingWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

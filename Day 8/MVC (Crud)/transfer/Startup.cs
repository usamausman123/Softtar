using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(transfer.Startup))]
namespace transfer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

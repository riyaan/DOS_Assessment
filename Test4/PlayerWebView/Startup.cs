using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayerWebView.Startup))]
namespace PlayerWebView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

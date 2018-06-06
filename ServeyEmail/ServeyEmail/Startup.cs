using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServeyEmail.Startup))]
namespace ServeyEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

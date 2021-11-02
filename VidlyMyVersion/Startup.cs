using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMyVersion.Startup))]
namespace VidlyMyVersion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

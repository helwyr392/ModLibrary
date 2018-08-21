using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModLibrary.Startup))]
namespace ModLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

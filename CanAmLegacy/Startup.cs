using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanAmLegacy.Startup))]
namespace CanAmLegacy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

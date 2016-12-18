using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternetOfJoran.Startup))]
namespace InternetOfJoran
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

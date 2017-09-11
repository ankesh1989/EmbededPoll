using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserEmbed.Startup))]
namespace UserEmbed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeEmbeder.Startup))]
namespace CodeEmbeder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

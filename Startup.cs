using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mawjoud2.Startup))]
namespace Mawjoud2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

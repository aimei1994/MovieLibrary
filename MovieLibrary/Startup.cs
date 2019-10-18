using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieLibrary.Startup))]
namespace MovieLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

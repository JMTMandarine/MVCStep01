using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoardProject.Startup))]
namespace BoardProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

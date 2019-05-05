using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(socket.Startup))]
namespace socket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

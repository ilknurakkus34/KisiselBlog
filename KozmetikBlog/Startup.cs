using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KozmetikBlog.Startup))]
namespace KozmetikBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

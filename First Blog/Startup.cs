using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(First_Blog.Startup))]
namespace First_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

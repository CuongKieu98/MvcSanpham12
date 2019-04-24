using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSanpham.Startup))]
namespace MvcSanpham
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

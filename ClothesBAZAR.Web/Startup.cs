using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothesBAZAR.Web.Startup))]
namespace ClothesBAZAR.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

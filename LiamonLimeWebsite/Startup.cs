using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiamonLimeWebsite.Startup))]
namespace LiamonLimeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

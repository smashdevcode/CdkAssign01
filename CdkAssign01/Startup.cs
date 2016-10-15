using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CdkAssign01.Startup))]
namespace CdkAssign01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

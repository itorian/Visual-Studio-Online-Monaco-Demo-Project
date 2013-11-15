using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisualStudioOnlineMonacoDemo.Startup))]
namespace VisualStudioOnlineMonacoDemo
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}

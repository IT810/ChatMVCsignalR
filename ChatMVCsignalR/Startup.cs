using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatMVCsignalR.Startup))]
namespace ChatMVCsignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
